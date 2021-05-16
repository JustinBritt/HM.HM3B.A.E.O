namespace HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;

    public interface IVarianceICalculation
    {
        IVarianceI Calculate(
            IVarianceIResultElementFactory varianceIResultElementFactory,
            IVarianceIFactory varianceIFactory,
            IVarianceIResultElementCalculation varianceIResultElementCalculation,
            Il l,
            It t,
            Ist st,
            ItΛ tΛ,
            IVarianceΦ varianceΦ,
            Iz z);
    }
}