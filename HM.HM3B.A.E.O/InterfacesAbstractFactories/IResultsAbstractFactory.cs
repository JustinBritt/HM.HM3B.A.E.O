namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Results.BestBound;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.Gap;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgicalSpecialtyNumberAssignedWeekdays;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IEBSFactory CreateEBSFactory();

        IExpectedValueIFactory CreateExpectedValueIFactory();

        IExpectedValueΦFactory CreateExpectedValueΦFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        IScenarioNumberPatientsFactory CreateScenarioNumberPatientsFactory();

        IScenarioTotalTimesFactory CreateScenarioTotalTimesFactory();

        IScenarioUnderutilizationsFactory CreateScenarioUnderutilizationsFactory();

        IScenarioUnutilizedTimesFactory CreateScenarioUnutilizedTimesFactory();

        IScenarioUtilizedTimesFactory CreateScenarioUtilizedTimesFactory();

        ISurgeonNumberAssignedOperatingRoomsFactory CreateSurgeonNumberAssignedOperatingRoomsFactory();

        ISurgeonNumberAssignedWeekdaysFactory CreateSurgeonNumberAssignedWeekdaysFactory();

        ISurgeonScenarioNumberPatientsFactory CreateSurgeonScenarioNumberPatientsFactory();

        ISurgicalSpecialtyNumberAssignedOperatingRoomsFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory();

        ISurgicalSpecialtyNumberAssignedWeekdaysFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory();

        HM.HM3B.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage.ITEBSFactory CreateTEBSFactory();

        HM.HM3B.A.E.O.InterfacesFactories.Results.ScenarioTotalExpectedBedShortages.ITEBSFactory CreateTEBSΛFactory();

        IVarianceIFactory CreateVarianceIFactory();

        IVarianceΦFactory CreateVarianceΦFactory();

        IVHatFactory CreateVHatFactory();

        IxFactory CreatexFactory();

        IyFactory CreateyFactory();

        IzFactory CreatezFactory();

        IβFactory CreateβFactory();

        IγFactory CreateγFactory();

        Iυ2Factory Createυ2Factory();

        IΦHatFactory CreateΦHatFactory();
    }
}