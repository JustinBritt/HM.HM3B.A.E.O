namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IHM3BModelFactory CreateHM3BModelFactory();
    }
}