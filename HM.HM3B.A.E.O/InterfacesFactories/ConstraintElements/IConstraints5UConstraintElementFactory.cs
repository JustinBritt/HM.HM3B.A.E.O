namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints5UConstraintElementFactory
    {
        // w and y are both variables
        IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Iw w,
            Iy y);

        // w is a variable and y is a parameter
        IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Interfaces.Variables.Iw w);

        // w is a parameter and y is a variable
        IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments.Iw w,
            Interfaces.Variables.Iy y);

        // w and y are both parameters
        IConstraints5UConstraintElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IB BBar,
            Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks.IB Bs,
            Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments.Iw w,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y);
    }
}