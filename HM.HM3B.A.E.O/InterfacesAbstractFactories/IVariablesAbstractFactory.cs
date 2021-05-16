namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        IbFactory CreatebFactory();

        IuFactory CreateuFactory();

        IvFactory CreatevFactory();

        IwFactory CreatewFactory();

        IxFactory CreatexFactory();

        IyFactory CreateyFactory();

        IzFactory CreatezFactory();

        IβFactory CreateβFactory();

        IγFactory CreateγFactory();
    }
}