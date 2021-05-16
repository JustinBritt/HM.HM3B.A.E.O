namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints1ConstraintElementFactory
    {
        // v and y are both variables
        IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Iv v,
            Iy y);

        // v is a variable and y is a parameter
        IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ,
            Interfaces.Variables.Iv v);

        // v is a parameter and y is a variable
        IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Iζ ζ,
            Interfaces.Variables.Iy y);

        // v and y are both parameters
        IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ);
    }
}