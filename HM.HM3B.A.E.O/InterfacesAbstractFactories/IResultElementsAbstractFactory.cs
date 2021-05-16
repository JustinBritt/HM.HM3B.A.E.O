namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface IResultElementsAbstractFactory
    {
        IEBSResultElementFactory CreateEBSResultElementFactory();

        IExpectedValueIResultElementFactory CreateExpectedValueIResultElementFactory();

        IExpectedValueΦResultElementFactory CreateExpectedValueΦResultElementFactory();

        IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory();

        IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory();

        IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory();

        IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory();

        IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory();

        ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory();

        ISurgeonNumberAssignedWeekdaysResultElementFactory CreateSurgeonNumberAssignedWeekdaysResultElementFactory();

        ISurgeonScenarioNumberPatientsResultElementFactory CreateSurgeonScenarioNumberPatientsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory();

        ITEBSResultElementFactory CreateTEBSΛResultElementFactory();

        IVarianceIResultElementFactory CreateVarianceIResultElementFactory();

        IVarianceΦResultElementFactory CreateVarianceΦResultElementFactory();

        IVHatResultElementFactory CreateVHatResultElementFactory();

        IxResultElementFactory CreatexResultElementFactory();

        IyResultElementFactory CreateyResultElementFactory();

        IzResultElementFactory CreatezResultElementFactory();

        IβResultElementFactory CreateβResultElementFactory();

        IγResultElementFactory CreateγResultElementFactory();

        Iυ2ResultElementFactory Createυ2ResultElementFactory();

        IΦHatResultElementFactory CreateΦHatResultElementFactory();
    }
}