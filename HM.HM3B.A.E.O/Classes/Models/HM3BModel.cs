namespace HM.HM3B.A.E.O.Classes.Models
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

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
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    
    internal abstract class HM3BModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BModel(
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
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
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.Weekdays
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(x))
                .ToImmutableList());

            // j
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.SurgicalSpecialties
                .Select(x => x.Key)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // m
            this.m = indicesAbstractFactory.CreatemFactory().Create(
                comparersAbstractFactory.CreateDeviceComparerFactory().Create(),
                this.Context.Machines
                .Entry
                .Where(x => x.Resource is Device)
                .Select(x => indexElementsAbstractFactory.CreatemIndexElementFactory().Create((Device)x.Resource))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                comparersAbstractFactory.CreateLocationComparerFactory().Create(),
                this.Context.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.Context.Surgeons
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // t
            IPlanningHorizonVisitor<INullableValue<int>, FhirDateTime> planningHorizonVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.PlanningHorizonVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreatetIndexElementFactory(),
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory().Create());

            this.Context.PlanningHorizon.AcceptVisitor(
                planningHorizonVisitor);

            this.t = indicesAbstractFactory.CreatetFactory().Create(
                planningHorizonVisitor.RedBlackTree);

            // Λ
            this.Λ = indicesAbstractFactory.CreateΛFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.Context.Scenarios
                .Select(x => indexElementsAbstractFactory.CreateΛIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // dt
            this.dt = crossJoinsAbstractFactory.CreatedtFactory().Create(
                this.d.Value.Values
                .SelectMany(b => this.t.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatedtCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // mr
            this.mr = crossJoinsAbstractFactory.CreatemrFactory().Create(
                this.m.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatemrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rt
            this.rt = crossJoinsAbstractFactory.CreatertFactory().Create(
                this.r.Value.Values
                .SelectMany(b => this.t.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatertCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sd
            this.sd = crossJoinsAbstractFactory.CreatesdFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sdt 
            this.sdt = crossJoinsAbstractFactory.CreatesdtFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesdCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesdtCrossJoinElementFactory().Create(a.sIndexElement, a.dIndexElement, b))
                .ToImmutableList());

            // slΛ
            this.slΛ = crossJoinsAbstractFactory.CreateslΛFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.l.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateslCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.Λ.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateslΛCrossJoinElementFactory().Create(a.sIndexElement, a.lIndexElement, b))
                .ToImmutableList());

            // sr
            this.sr = crossJoinsAbstractFactory.CreatesrFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // srd
            this.srd = crossJoinsAbstractFactory.CreatesrdFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrdCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // srj
            this.srj = crossJoinsAbstractFactory.CreatesrjFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.j.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrjCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // srt
            this.srt = crossJoinsAbstractFactory.CreatesrtFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.t.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesrtCrossJoinElementFactory().Create(a.sIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // st
            this.st = crossJoinsAbstractFactory.CreatestFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.t.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatestCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sΛ
            this.sΛ = crossJoinsAbstractFactory.CreatesΛFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.Λ.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // tΛ
            this.tΛ = crossJoinsAbstractFactory.CreatetΛFactory().Create(
                this.t.Value.Values
                .SelectMany(b => this.Λ.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatetΛCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // BBar(j)
            ISurgicalSpecialtyNumberAssignedTimeBlocksVisitor<Organization, INullableValue<int>> surgicalSpecialtyNumberAssignedTimeBlocksVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgicalSpecialtyNumberAssignedTimeBlocksVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateBBarParameterElementFactory(),
                this.j);

            this.Context.SurgicalSpecialtyNumberAssignedTimeBlocks.AcceptVisitor(
                surgicalSpecialtyNumberAssignedTimeBlocksVisitor);

            this.BBar = parametersAbstractFactory.CreateBBarFactory().Create(
                surgicalSpecialtyNumberAssignedTimeBlocksVisitor.RedBlackTree);

            // B(s)
            ISurgeonNumberAssignedTimeBlocksVisitor<Organization, INullableValue<int>> surgeonNumberAssignedTimeBlocksVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonNumberAssignedTimeBlocksVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateBsParameterElementFactory(),
                this.s);

            this.Context.SurgeonNumberAssignedTimeBlocks.AcceptVisitor(
                surgeonNumberAssignedTimeBlocksVisitor);

            this.Bs = parametersAbstractFactory.CreateBsFactory().Create(
                surgeonNumberAssignedTimeBlocksVisitor.RedBlackTree);

            // H
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.TimeBlockLength);

            // h(s, Λ)
            ISurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, Duration>>(
                parameterElementsAbstractFactory.CreatehParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioWeightedAverageSurgicalDurations.AcceptVisitor(
                surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor);

            this.h = parametersAbstractFactory.CreatehFactory().Create(
                surgeonScenarioWeightedAverageSurgicalDurationsOuterVisitor.RedBlackTree);

            // L(s)
            ISurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>> surgeonLengthOfStayMaximumsVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonLengthOfStayMaximumsVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateLParameterElementFactory(),
                this.s);

            this.Context.SurgeonLengthOfStayMaximums.AcceptVisitor(
                surgeonLengthOfStayMaximumsVisitor);

            this.L = parametersAbstractFactory.CreateLFactory().Create(
                surgeonLengthOfStayMaximumsVisitor.RedBlackTree);

            // n(s, Λ)
            ISurgeonScenarioMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatientsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>>(
                parameterElementsAbstractFactory.CreatenParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatients.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientsOuterVisitor);

            this.n = parametersAbstractFactory.CreatenFactory().Create(
                surgeonScenarioMaximumNumberPatientsOuterVisitor.RedBlackTree);

            // p(s, l, Λ)
            ISurgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>(
                parameterElementsAbstractFactory.CreatepParameterElementFactory(),
                this.l,
                this.s,
                this.Λ);

            this.Context.SurgeonDayScenarioLengthOfStayProbabilities.AcceptVisitor(
                surgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor);

            this.p = parametersAbstractFactory.CreatepFactory().Create(
                surgeonDayScenarioLengthOfStayProbabilitiesOuterVisitor.RedBlackTree);

            // W
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                this.Context.NumberDaysPerWeek);

            // Δ(j)
            ISurgicalSpecialtiesVisitor<Organization, ImmutableSortedSet<Organization>> surgicalSpecialtiesVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgicalSpecialtiesVisitor<Organization, ImmutableSortedSet<Organization>>(
                parameterElementsAbstractFactory.CreateΔParameterElementFactory(),
                this.j,
                this.s);

            this.Context.SurgicalSpecialties.AcceptVisitor(
                surgicalSpecialtiesVisitor);

            this.Δ = parametersAbstractFactory.CreateΔFactory().Create(
                surgicalSpecialtiesVisitor.RedBlackTree,
                surgicalSpecialtiesVisitor.Value.ToImmutableList());

            // ζ(s, m)
            ISurgeonMachineRequirementsOuterVisitor<Organization, RedBlackTree<Device, INullableValue<bool>>> surgeonMachineRequirementsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonMachineRequirementsOuterVisitor<Organization, RedBlackTree<Device, INullableValue<bool>>>(
                parameterElementsAbstractFactory.CreateζParameterElementFactory(),
                this.m,
                this.s);

            this.Context.SurgeonMachineRequirements.AcceptVisitor(
                surgeonMachineRequirementsOuterVisitor);

            this.ζ = parametersAbstractFactory.CreateζFactory().Create(
                surgeonMachineRequirementsOuterVisitor.RedBlackTree);

            // μ(s, Λ)
            ISurgeonScenarioMaximumNumberPatientMeansOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientMeansOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientMeansOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreateμParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatientMeans.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientMeansOuterVisitor);

            this.μ = parametersAbstractFactory.CreateμFactory().Create(
                surgeonScenarioMaximumNumberPatientMeansOuterVisitor.RedBlackTree);

            // Ρ(Λ)
            IScenarioProbabilitiesVisitor<INullableValue<int>, INullableValue<decimal>> scenarioProbabilitiesVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.ScenarioProbabilitiesVisitor<INullableValue<int>, INullableValue<decimal>>(
                parameterElementsAbstractFactory.CreateΡParameterElementFactory(),
                this.Λ);

            this.Context.ScenarioProbabilities.AcceptVisitor(
                scenarioProbabilitiesVisitor);

            this.Ρ = parametersAbstractFactory.CreateΡFactory().Create(
                scenarioProbabilitiesVisitor.RedBlackTree);

            // σ(s, Λ)
            ISurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreateσParameterElementFactory(),
                this.s,
                this.Λ);

            this.Context.SurgeonScenarioMaximumNumberPatientStandardDeviations.AcceptVisitor(
                surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor);

            this.σ = parametersAbstractFactory.CreateσFactory().Create(
                surgeonScenarioMaximumNumberPatientStandardDeviationsOuterVisitor.RedBlackTree);

            // ψ(t)
            IDayAvailabilitiesVisitor<FhirDateTime, INullableValue<bool>> dayAvailabilitiesVisitor = contextsAbstractFactory.CreateDayAvailabilitiesVisitorFactory().Create<FhirDateTime, INullableValue<bool>>(
                new HM.HM3B.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees.RedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreateψParameterElementFactory(),
                this.t);

            this.Context.DayAvailabilities.AcceptVisitor(
                dayAvailabilitiesVisitor);

            this.ψ = parametersAbstractFactory.CreateψFactory().Create(
                dayAvailabilitiesVisitor.RedBlackTree);

            // Ω
            this.Ω = parametersAbstractFactory.CreateΩFactory().Create(
                this.Context.MaximumNumberRecoveryWardBeds);

            // Variables

            // b(s, r)
            this.b = variablesAbstractFactory.CreatebFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.r.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => int.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // u(s, d)
            this.u = variablesAbstractFactory.CreateuFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.d.Value.Values));

            // x(s, r, t)
            this.x = variablesAbstractFactory.CreatexFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.r.Value.Values, 
                    indexSet3: this.t.Value.Values)); 

            // z(s, t)
            this.z = variablesAbstractFactory.CreatezFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.t.Value.Values));

            // β(s, r, d)
            this.β = variablesAbstractFactory.CreateβFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values,
                    indexSet2: this.r.Value.Values, 
                    indexSet3: this.d.Value.Values, 
                    lowerBoundGenerator: (a, b, c) => 0, 
                    upperBoundGenerator: (a, b, c) => int.MaxValue, 
                    variableTypeGenerator: (a, b, c) => VariableType.Integer)); 

            // γ(r, t)
            this.γ = variablesAbstractFactory.CreateγFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.r.Value.Values, 
                    indexSet2: this.t.Value.Values)); 

            // Constraints
            // 1 (v, y), 5 L/M/U (v, w, y), 10 (y)
            // 2, 3, 4, 6, 7, 8, 9

            // Constraints 2
            this.Model.AddConstraints(
                this.s.Value.Values
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints2ConstraintElementFactory().Create(
                        x,
                        this.r,
                        this.Bs,
                        this.b)
                    .Value));

            // Constraints 3
            this.Model.AddConstraints(
                this.r.Value.Values
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