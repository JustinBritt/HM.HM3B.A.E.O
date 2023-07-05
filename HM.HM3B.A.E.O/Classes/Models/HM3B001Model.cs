namespace HM.HM3B.A.E.O.Classes.Models
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class HM3B001Model : 
        HM3BModel,
        IHM3B001Model
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3B001Model(
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
            // v(m, r)
            IMachineOperatingRoomAssignmentsOuterVisitor<Device, RedBlackTree<Location, INullableValue<bool>>> machineOperatingRoomAssignmentsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.MachineOperatingRoomAssignmentsOuterVisitor<Device, RedBlackTree<Location, INullableValue<bool>>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreatevParameterElementFactory(),
                this.m,
                this.r);

            this.Context.MachineOperatingRoomAssignments.AcceptVisitor(
                machineOperatingRoomAssignmentsOuterVisitor);

            this.v = parametersAbstractFactory.CreatevFactory().Create(
                machineOperatingRoomAssignmentsOuterVisitor.RedBlackTree);

            // w(j, r)
            ISurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor<Organization, RedBlackTree<Location, INullableValue<bool>>> surgicalSpecialtyOperatingRoomAssignmentsOuterVisitor = new HM.HM3B.A.E.O.Visitors.Contexts.SurgicalSpecialtyOperatingRoomAssignmentsOuterVisitor<Organization, RedBlackTree<Location, INullableValue<bool>>>(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                parameterElementsAbstractFactory.CreatewParameterElementFactory(),
                this.j,
                this.r);

            this.Context.SurgicalSpecialtyOperatingRoomAssignments.AcceptVisitor(
                surgicalSpecialtyOperatingRoomAssignmentsOuterVisitor);

            this.w = parametersAbstractFactory.CreatewFactory().Create(
                surgicalSpecialtyOperatingRoomAssignmentsOuterVisitor.RedBlackTree);

            // y(s, r)
            this.y = variablesAbstractFactory.CreateyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().CreateBinary(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
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
                        this.v,
                        this.ζ,
                        this.y)
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
                        this.b,
                        this.y)
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
                        this.b,
                        this.y)
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
                        this.w,
                        this.y)
                    .Value));

            // Constraints 10
            this.Model.AddConstraints(
                this.srt.Value
                .Select(
                    x => constraintElementsAbstractFactory.CreateConstraints10ConstraintElementFactory().Create(
                        x.rIndexElement,
                        x.sIndexElement,
                        x.tIndexElement,
                        this.x,
                        this.y)
                    .Value));
        }

        public Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v { get; }

        public Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments.Iw w { get; }

        public Interfaces.Variables.Iy y { get; }
    }
}