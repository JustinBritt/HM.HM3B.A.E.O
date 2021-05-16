namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints5MConstraintElementFactory
    {
        // y is a variable
        IConstraints5MConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Ib b,
            Iy y);

        // y is a parameter
        IConstraints5MConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            IB B,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Interfaces.Variables.Ib b);
    }
}