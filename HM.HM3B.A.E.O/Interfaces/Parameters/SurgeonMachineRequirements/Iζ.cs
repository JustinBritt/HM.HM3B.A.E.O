namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;

    public interface Iζ
    {
        ImmutableList<IζParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement);
    }
}