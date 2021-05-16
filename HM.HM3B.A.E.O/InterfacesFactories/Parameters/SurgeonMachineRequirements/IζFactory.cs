namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;

    public interface IζFactory
    {
        Iζ Create(
            ImmutableList<IζParameterElement> value);
    }
}