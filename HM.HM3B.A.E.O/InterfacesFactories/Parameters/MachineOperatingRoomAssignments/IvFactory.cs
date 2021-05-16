namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.MachineOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments;

    public interface IvFactory
    {
        Iv Create(
            ImmutableList<IvParameterElement> value);
    }
}