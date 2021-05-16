namespace HM.HM3B.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;

    public interface IConstraints5MFactory
    {
        IConstraints5M Create(
            ImmutableList<IConstraints5MConstraintElement> value);
    }
}