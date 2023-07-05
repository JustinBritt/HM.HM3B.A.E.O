namespace HM.HM3B.A.E.O.Classes.Models
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class HM3B110Model : 
        HM3BModel,
        IHM3B110Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3B110Model(
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
            IHM3BInputContext HM3BInputContext) :
            base(
                comparersAbstractFactory,
                constraintElementsAbstractFactory,
                constraintsAbstractFactory,
                contextsAbstractFactory,
                crossJoinElementsAbstractFactory,
                crossJoinsAbstractFactory,
                dependenciesAbstractFactory,
                indexElementsAbstractFactory,
                indicesAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                parametersAbstractFactory,
                variablesAbstractFactory,
                HM3BInputContext)
        {
            // y(s, r)
            ISurgeonOperatingRoomAssignmentsOuterVisitor<Organization, RedBlackTree<Location, INullableValue<bool>>> surgeonOperatingRoomAssignmentsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgeonOperatingRoomAssignmentsOuterVisitor<Organization, RedBlackTree<Location, INullableValue<bool>>>(
                parameterElementsAbstractFactory.CreateyParameterElementFactory(),
                this.r,
                this.s);

            this.Context.SurgeonOperatingRoomAssignments.AcceptVisitor(
                surgeonOperatingRoomAssignmentsOuterVisitor);

            this.y = parametersAbstractFactory.CreateyFactory().Create(
                surgeonOperatingRoomAssignmentsOuterVisitor.RedBlackTree);

            // v(m, r)
            this.v = variablesAbstractFactory.CreatevFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.m.Value.Values, 
                    indexSet2: this.r.Value.Values)); 

            // w(j, r)
            this.w = variablesAbstractFactory.CreatewFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model,
                    indexSet1: this.j.Value.Values, 
                    indexSet2: this.r.Value.Values)); 

            // Constraints 1
            this.Model.AddConstraints(
                this.mr.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints1ConstraintElementFactory().Create(
                        x.mIndexElement,
                        x.rIndexElement,
                        this.m,
                        this.s,
                        this.y,
                        this.ζ,
                        this.v)
                    .Value));

            // Constraints 5L
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5LConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        this.y,
                        this.b)
                    .Value));

            // Constraints 5M
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5MConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        this.Bs,
                        this.y,
                        this.b)
                    .Value));

            // Constraints 5U
            this.Model.AddConstraints(
                this.srj.Value
                .Where(
                    x => this.Δ.IsSurgeonMemberOfSurgicalSpecialty(
                        x.jIndexElement,
                        x.sIndexElement))
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints5UConstraintElementFactory().Create(
                        x.jIndexElement,
                        x.rIndexElement,
                        x.sIndexElement,
                        this.BBar,
                        this.Bs,
                        this.y,
                        this.w)
                    .Value));

            // Constraints 10
            this.Model.AddConstraints(
                this.srt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints10ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        x.tIndexElement,
                        this.y,
                        this.x)
                    .Value));
        }

        public Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y { get; }

        public Interfaces.Variables.Iv v { get; }

        public Interfaces.Variables.Iw w { get; }
    }
}