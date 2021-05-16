namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints5LConstraintElementFactory
    {
        // y is a variable
        IConstraints5LConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Ib b,
            Iy y);

        // y is a parameter
        IConstraints5LConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ib b);
    }
}