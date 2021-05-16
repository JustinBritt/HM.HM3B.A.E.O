namespace HM.HM3B.A.E.O.Classes.Models
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal abstract class HM3BModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BModel(
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM3BInputContext HM3BInputContext)
        {
            this.Context = HM3BInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // d
            this.d = indicesAbstractFactory.CreatedFactory().Create(
                this.Context.Weekdays
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(
                    (PositiveInt)x))
                .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create((PositiveInt)x))
                .ToImmutableList());

            // m
            this.m = indicesAbstractFactory.CreatemFactory().Create(
                this.Context.Machines
                .Entry
                .Where(x => x.Resource is Device)
                .Select(x => indexElementsAbstractFactory.CreatemIndexElementFactory().Create((Device)x.Resource))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            this.t = indicesAbstractFactory.CreatetFactory().Create(
                this.Context.PlanningHorizon
                .Select(x => indexElementsAbstractFactory.CreatetIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create((PositiveInt)x))
                .ToImmutableList());

            // Cross joins

            // dt
            this.dt = crossJoinsAbstractFactory.CreatedtFactory().Create(
                this.d.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatedtCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // mr
            this.mr = crossJoinsAbstractFactory.CreatemrFactory().Create(
                this.m.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatemrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rt
            this.rt = crossJoinsAbstractFactory.CreatertFactory().Create(
                this.r.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatertCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sd
            this.sd = crossJoinsAbstractFactory.CreatesdFactory().Create(
                this.s.Value
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sdt 
            this.sdt = crossJoinsAbstractFactory.CreatesdtFactory().Create(
                this.s.Value
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesdCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesdtCrossJoinElementFactory().Create(a.sIndexElement, a.dIndexElement, b))
                .ToImmutableList());

            // slΛ
            this.slΛ = crossJoinsAbstractFactory.CreateslΛFactory().Create(
                this.s.Value
                .SelectMany(b => this.l.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreateslΛCrossJoinElementFactory().Create(a.sIndexElement, a.lIndexElement, b))
                .ToImmutableList());

            // sr
            this.sr = crossJoinsAbstractFactory.CreatesrFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // srd
            this.srd = crossJoinsAbstractFactory.CreatesrdFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrdCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // srj
            this.srj = crossJoinsAbstractFactory.CreatesrjFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.j.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrjCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // srt
            this.srt = crossJoinsAbstractFactory.CreatesrtFactory().Create(
                this.s.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesrtCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // st
            this.st = crossJoinsAbstractFactory.CreatestFactory().Create(
                this.s.Value
                .SelectMany(b => this.t.Value, (a, b) => crossJoinElementsAbstractFactory.CreatestCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // tΛ
            this.tΛ = crossJoinsAbstractFactory.CreatetΛFactory().Create(
                this.t.Value
                .SelectMany(b => this.Λ.Value, (a, b) => crossJoinElementsAbstractFactory.CreatetΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // BBar(j)
            this.BBar = parametersAbstractFactory.CreateBBarFactory().Create(
                this.Context.SurgicalSpecialtyNumberAssignedTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateBBarParameterElementFactory().Create(
                    this.j.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // B(s)
            this.Bs = parametersAbstractFactory.CreateBsFactory().Create(
                this.Context.SurgeonNumberAssignedTimeBlocks
                .Select(x => parameterElementsAbstractFactory.CreateBsParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // H
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.TimeBlockLength);

            // h(s, Λ)
            this.h = parametersAbstractFactory.CreatehFactory().Create(
                this.Context.SurgeonScenarioWeightedAverageSurgicalDurations
                .Select(x => parameterElementsAbstractFactory.CreatehParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt((PositiveInt)x.Item2),
                    x.Item3))
                .ToImmutableList());

            // L(s)
            this.L = parametersAbstractFactory.CreateLFactory().Create(
                this.Context.SurgeonLengthOfStayMaximums
                .Select(x => parameterElementsAbstractFactory.CreateLParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    (PositiveInt)x.Value))
                .ToImmutableList());

            // n(s, Λ)
            this.n = parametersAbstractFactory.CreatenFactory().Create(
                this.Context.SurgeonScenarioMaximumNumberPatients
                .Select(x => parameterElementsAbstractFactory.CreatenParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt((PositiveInt)x.Item2),
                    (PositiveInt)x.Item3))
                .ToImmutableList());

            // p(s, l, Λ)
            this.p = parametersAbstractFactory.CreatepFactory().Create(
                this.Context.SurgeonDayScenarioLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreatepParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.l.GetElementAt((PositiveInt)x.Item2),
                    this.Λ.GetElementAt((PositiveInt)x.Item3),
                    (FhirDecimal)x.Item4))
                .ToImmutableList());

            // W
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                (PositiveInt)this.Context.NumberDaysPerWeek);

            // Δ(j)
            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                this.Context.SurgicalSpecialties
                .Select(x => parameterElementsAbstractFactory.CreateΔParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // ζ(s, m)
            this.ζ = parametersAbstractFactory.CreateζFactory().Create(
                this.Context.SurgeonMachineRequirements
                .Select(x => parameterElementsAbstractFactory.CreateζParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.m.GetElementAt(x.Item2),
                    (FhirBoolean)x.Item3))
                .ToImmutableList());

            // μ(s, Λ)
            this.μ = parametersAbstractFactory.CreateμFactory().Create(
                this.Context.SurgeonScenarioMaximumNumberPatientMeans
                .Select(x => parameterElementsAbstractFactory.CreateμParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item1),
                    this.Λ.GetElementAt((PositiveInt)x.Item2),
                    (FhirDecimal)x.Item3))
                .ToImmutableList());

            // Ρ(Λ)
            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                this.Context.ScenarioProbabilities
                .Select(x => parameterElementsAbstractFactory.CreateΡParameterElementFactory().Create(
                    this.Λ.GetElementAt((PositiveInt)x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // σ(s, Λ)
            this.σ = parametersAbstractFactory.CreateσFactory().Create(
               this.Context.SurgeonScenarioMaximumNumberPatientStandardDeviations
               .Select(x => parameterElementsAbstractFactory.CreateσParameterElementFactory().Create(
                   this.s.GetElementAt(x.Item1),
                   this.Λ.GetElementAt((PositiveInt)x.Item2),
                   (FhirDecimal)x.Item3))
               .ToImmutableList());

            // ψ(t)
            this.ψ = parametersAbstractFactory.CreateψFactory().Create(
                this.Context.DayAvailabilities
                .Select(x => parameterElementsAbstractFactory.CreateψParameterElementFactory().Create(
                    this.t.GetElementAt(x.Key),
                    (FhirBoolean)x.Value))
                .ToImmutableList());

            // Ω
            this.Ω = parametersAbstractFactory.CreateΩFactory().Create(
                (PositiveInt)this.Context.MaximumNumberRecoveryWardBeds);

            // Variables

            // b(s, r)
            this.b = variablesAbstractFactory.CreatebFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.r.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // u(s, d)
            this.u = variablesAbstractFactory.CreateuFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.d.Value));

            // x(s, r, t)
            this.x = variablesAbstractFactory.CreatexFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.r.Value, 
                    indexSet3: this.t.Value)); 

            // z(s, t)
            this.z = variablesAbstractFactory.CreatezFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.t.Value));

            // β(s, r, d)
            this.β = variablesAbstractFactory.CreateβFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value,
                    indexSet2: this.r.Value, 
                    indexSet3: this.d.Value, 
                    lowerBoundGenerator: (a, b, c) => 0, 
                    upperBoundGenerator: (a, b, c) => int.MaxValue, 
                    variableTypeGenerator: (a, b, c) => VariableType.Integer)); 

            // γ(r, t)
            this.γ = variablesAbstractFactory.CreateγFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.r.Value, 
                    indexSet2: this.t.Value)); 

            // Constraints
            // 1 (v, y), 5 L/M/U (v, w, y), 10 (y)
            // 2, 3, 4, 6, 7, 8, 9

            // Constraints 2
            this.Model.AddConstraints(
                this.s.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        x,
                        this.r,
                        this.Bs,
                        this.b)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.r.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        x,
                        this.s,
                        this.t,
                        this.b,
                        this.γ)
                    .Value));

            // Constraints 4
            this.Model.AddConstraints(
                this.rt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.tIndexElement,
                        this.ψ,
                        this.γ)
                    .Value));

            // Constraints 6
            this.Model.AddConstraints(
                this.sr.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints6ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        this.d,
                        this.b,
                        this.β)
                    .Value));

            // Constraints 7
            this.Model.AddConstraints(
                this.srd.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints7ConstraintElementFactory().Create(
                        x.dIndexElement,
                        x.rIndexElement,
                        x.sIndexElement,
                        this.t,
                        this.W,
                        this.x,
                        this.β)
                    .Value));

            // Constraints 8L
            this.Model.AddConstraints(
                this.sd.Value
                .SelectMany(b =>
                this.t.GetNthElementsAt(
                    b.dIndexElement.Value.Value.Value,
                    this.t.GetT() - this.W.Value.Value.Value + b.dIndexElement.Value.Value.Value,
                    this.W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.dIndexElement, b))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints8LConstraintElementFactory().Create(
                        x.Item2,
                        x.Item1,
                        x.Item3,
                        this.r,
                        this.x,
                        this.z)
                    .Value));

            // Constraints 8U
            this.Model.AddConstraints(
                this.sd.Value
                .SelectMany(b =>
                this.t.GetNthElementsAt(
                    b.dIndexElement.Value.Value.Value,
                    this.t.GetT() - this.W.Value.Value.Value + b.dIndexElement.Value.Value.Value,
                    this.W.Value.Value.Value),
                    (a, b) => Tuple.Create(a.sIndexElement, a.dIndexElement, b))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints8UConstraintElementFactory().Create(
                        x.Item2,
                        x.Item1,
                        x.Item3,
                        this.u,
                        this.z)
                    .Value));

            // Constraints 9
            this.Model.AddConstraints(
                this.rt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints9ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.tIndexElement,
                        this.s,
                        this.x,
                        this.γ)
                    .Value));

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.sd,
                    this.u)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public IHM3BInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Interfaces.Indices.Id d { get; }

        public Ij j { get; }

        public Il l { get; }

        public Im m { get; }

        public Ir r { get; }

        public Is s { get; }

        public It t { get; }

        public IΛ Λ { get; }

        public Idt dt { get; }

        public Imr mr { get; }

        public Irt rt { get; }

        public Isd sd { get; }

        public Isdt sdt { get; }

        public IslΛ slΛ { get; }

        public Isr sr { get; }

        public Isrd srd { get; }

        public Isrj srj { get; }

        public Isrt srt { get; }

        public Ist st { get; }

        public IsΛ sΛ { get; }

        public ItΛ tΛ { get; }

        public Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar { get; }

        public Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs { get; }

        public IH H { get; }

        public Ih h { get; }

        public IL L { get; }

        public In n { get; }

        public Ip p { get; }

        public IW W { get; }

        public IΔ Δ { get; }

        public Iζ ζ { get; }

        public Iμ μ { get; }

        public IΡ Ρ { get; }

        public Iσ σ { get; }

        public Iψ ψ { get; }

        public IΩ Ω { get; }

        public Ib b { get; }

        public Iu u { get; }

        public Ix x { get; }

        public Iz z { get; }

        public Iβ β { get; }

        public Iγ γ { get; }
    }
}