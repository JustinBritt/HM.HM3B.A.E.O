namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    public interface IΡFactory
    {
        IΡ Create(
            ImmutableList<IΡParameterElement> value);
    }
}