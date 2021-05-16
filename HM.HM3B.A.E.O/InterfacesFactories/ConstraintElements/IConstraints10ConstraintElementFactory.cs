namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints10ConstraintElementFactory
    {
        // y is a variable
        IConstraints10ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ix x,
            Iy y);

        // y is a parameter
        IConstraints10ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ix x);
    }
}