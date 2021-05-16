namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5LConstraintElement : IConstraints5LConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constructor: y is a variable (xx1)
        public Constraints5LConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Variables.Ib b,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = y.Value[sIndexElement, rIndexElement];

            Expression RHS = b.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: y is a parameter (xx0)
        public Constraints5LConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ib b)
        {
            int LHS = y.GetElementAtAsint(
                sIndexElement,
                rIndexElement);

            Expression RHS = b.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}