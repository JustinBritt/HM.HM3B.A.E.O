namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface Iw
    {
        ImmutableList<IwParameterElement> Value { get; }

        int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement);
    }
}