namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;

    public interface IhFactory
    {
        Ih Create(
            ImmutableList<IhParameterElement> value);
    }
}