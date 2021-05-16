namespace HM.HM3B.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;

    public interface IrtFactory
    {
        Irt Create(
            ImmutableList<IrtCrossJoinElement> value);
    }
}