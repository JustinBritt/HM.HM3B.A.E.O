namespace HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations;

    public interface IVHatResultElementFactory
    {
        IVHatResultElement Create(
            IΛIndexElement ΛIndexElement,
            decimal value);
    }
}