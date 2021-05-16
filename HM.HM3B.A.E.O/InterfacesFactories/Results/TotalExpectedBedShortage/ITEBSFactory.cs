namespace HM.HM3B.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage
{
    using HM.HM3B.A.E.O.Interfaces.Results.TotalExpectedBedShortage;

    public interface ITEBSFactory
    {
        ITEBS Create(
            decimal value);
    }
}