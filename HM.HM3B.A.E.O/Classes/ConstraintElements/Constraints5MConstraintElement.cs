namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;

    internal sealed class Constraints5MConstraintElement : IConstraints5MConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constructor: y is a variable (xx1)
        public Constraints5MConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Interfaces.Variables.Ib b,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = b.Value[sIndexElement, rIndexElement];

            Expression RHS = B.GetElementAtAsint(
                sIndexElement)
                *
                y.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: y is a parameter (xx0)
        public Constraints5MConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Interfaces.Variables.Ib b)
        {
            Expression LHS = b.Value[sIndexElement, rIndexElement];

            int RHS = B.GetElementAtAsint(
                sIndexElement)
                *
                y.GetElementAtAsint(
                    sIndexElement,
                    rIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}