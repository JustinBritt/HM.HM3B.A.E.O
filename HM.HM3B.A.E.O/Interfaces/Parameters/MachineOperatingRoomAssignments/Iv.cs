namespace HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;

    public interface Iv
    {
        ImmutableList<IvParameterElement> Value { get; }

        int GetElementAtAsint(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement);
    }
}