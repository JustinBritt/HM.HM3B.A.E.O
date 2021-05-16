namespace HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardUtilizations
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IVHatResultElement
    {
        IΛIndexElement ΛIndexElement { get; }

        decimal Value { get; }
    }
}