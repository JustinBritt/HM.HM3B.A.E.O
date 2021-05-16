namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Constraints;

    public interface IConstraintsAbstractFactory
    {
        IConstraints1Factory CreateConstraints1Factory();

        IConstraints2Factory CreateConstraints2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5LFactory CreateConstraints5LFactory();

        IConstraints5MFactory CreateConstraints5MFactory();

        IConstraints5UFactory CreateConstraints5UFactory();

        IConstraints6Factory CreateConstraints6Factory();

        IConstraints7Factory CreateConstraints7Factory();

        IConstraints8LFactory CreateConstraints8LFactory();

        IConstraints8UFactory CreateConstraints8UFactory();

        IConstraints9Factory CreateConstraints9Factory();

        IConstraints10Factory CreateConstraints10Factory();
    }
}