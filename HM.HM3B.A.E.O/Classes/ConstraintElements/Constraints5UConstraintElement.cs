namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    internal sealed class Constraints5UConstraintElement : IConstraints5UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constructor: w and y are both variables (x11)
        public Constraints5UConstraintElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Variables.Iw w,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = Bs.GetElementAtAsint(
                sIndexElement)
                *
                y.Value[sIndexElement, rIndexElement];

            Expression RHS = BBar.GetElementAtAsint(
                jIndexElement)
                *
                w.Value[jIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: w is a variable and y is a parameter (x10)
        public Constraints5UConstraintElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Interfaces.Variables.Iw w)
        {
            int LHS = Bs.GetElementAtAsint(
                sIndexElement)
                *
                y.GetElementAtAsint(
                    sIndexElement,
                    rIndexElement);

            Expression RHS = BBar.GetElementAtAsint(
                jIndexElement)
                *
                w.Value[jIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: w is a parameter and y is a variable (x01)
        public Constraints5UConstraintElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments.Iw w,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = Bs.GetElementAtAsint(
                sIndexElement)
                *
                y.Value[sIndexElement, rIndexElement];

            int RHS = BBar.GetElementAtAsint(
                jIndexElement)
                *
                w.GetElementAtAsint(
                    jIndexElement,
                    rIndexElement);

            this.Value = LHS <= RHS;
        }

        // Constructor: w and y are both parameters (x00)
        public Constraints5UConstraintElement(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments.Iw w,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y)
        {
            // Not needed  
        }

        public Constraint Value { get; }
    }
}