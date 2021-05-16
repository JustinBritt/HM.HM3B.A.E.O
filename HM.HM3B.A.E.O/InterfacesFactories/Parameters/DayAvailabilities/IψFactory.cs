namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;

    public interface IψFactory
    {
        Iψ Create(
            ImmutableList<IψParameterElement> value);
    }
}