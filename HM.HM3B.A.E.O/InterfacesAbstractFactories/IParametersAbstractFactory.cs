namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;

    public interface IParametersAbstractFactory
    {
        HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory();

        HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory();

        IHFactory CreateHFactory();

        IhFactory CreatehFactory();

        ILFactory CreateLFactory();

        InFactory CreatenFactory();

        IpFactory CreatepFactory();

        IvFactory CreatevFactory();

        IWFactory CreateWFactory();

        IwFactory CreatewFactory();

        IyFactory CreateyFactory();

        IΔFactory CreateΔFactory();

        IζFactory CreateζFactory();

        IμFactory CreateμFactory();

        IΡFactory CreateΡFactory();

        IσFactory CreateσFactory();

        IψFactory CreateψFactory();

        IΩFactory CreateΩFactory();
    }
}