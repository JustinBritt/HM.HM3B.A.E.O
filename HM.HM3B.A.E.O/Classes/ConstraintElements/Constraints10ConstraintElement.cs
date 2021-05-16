namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints10ConstraintElement : IConstraints10ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constructor: y is a variable (xx1)
        public Constraints10ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ix x,
            Iy y)
        {
            Expression LHS = x.Value[sIndexElement, rIndexElement, tIndexElement];

            Expression RHS = y.Value[sIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: y is a parameter (xx0)
        public Constraints10ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ix x)
        {
            Expression LHS = x.Value[sIndexElement, rIndexElement, tIndexElement];

            int RHS = y.GetElementAtAsint(
                sIndexElement,
                rIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}