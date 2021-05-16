namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.ObjectiveFunctions;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IObjectiveFunctionFactory CreateObjectiveFunctionFactory();
    }
}