namespace HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages
{
    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioExpectedBedShortages;

    public interface IEBSCalculationFactory
    {
        IEBSCalculation Create();
    }
}