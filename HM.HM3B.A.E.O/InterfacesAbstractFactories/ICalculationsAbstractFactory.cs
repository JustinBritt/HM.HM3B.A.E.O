namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface ICalculationsAbstractFactory
    {
        IEBSCalculationFactory CreateEBSCalculationFactory();

        IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory();

        IExpectedValueICalculationFactory CreateExpectedValueICalculationFactory();

        IExpectedValueIResultElementCalculationFactory CreateExpectedValueIResultElementCalculationFactory();

        IExpectedValueΦCalculationFactory CreateExpectedValueΦCalculationFactory();

        IExpectedValueΦResultElementCalculationFactory CreateExpectedValueΦResultElementCalculationFactory();

        IMRNBCalculationFactory CreateMRNBCalculationFactory();

        IRNBCalculationFactory CreateRNBCalculationFactory();

        IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory();

        IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory();

        IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory();

        IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory();

        IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory();

        IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory();

        IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory();

        IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory();

        IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory();

        IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgeonNumberAssignedWeekdaysCalculationFactory CreateSurgeonNumberAssignedWeekdaysCalculationFactory();

        ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory();

        ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory();

        ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory();

        HM.HM3B.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage.ITEBSCalculationFactory CreateTEBSCalculationFactory();

        HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages.ITEBSCalculationFactory CreateTEBSΛCalculationFactory();

        ITEBSResultElementCalculationFactory CreateTEBSΛResultElementCalculationFactory();

        ItStarCalculationFactory CreatetStarCalculationFactory();

        IVarianceICalculationFactory CreateVarianceICalculationFactory();

        IVarianceIResultElementCalculationFactory CreateVarianceIResultElementCalculationFactory();

        IVarianceΦCalculationFactory CreateVarianceΦCalculationFactory();

        IVarianceΦResultElementCalculationFactory CreateVarianceΦResultElementCalculationFactory();

        IVHatCalculationFactory CreateVHatCalculationFactory();

        IVHatResultElementCalculationFactory CreateVHatResultElementCalculationFactory();

        Iυ2CalculationFactory Createυ2CalculationFactory();

        Iυ2ResultElementCalculationFactory Createυ2ResultElementCalculationFactory();

        IΦHatCalculationFactory CreateΦHatCalculationFactory();

        IΦHatResultElementCalculationFactory CreateΦHatResultElementCalculationFactory();
    }
}