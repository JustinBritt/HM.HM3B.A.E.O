namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    public interface IParameterElementsAbstractFactory
    {
        HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory CreateBBarParameterElementFactory();

        HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory CreateBsParameterElementFactory();

        IhParameterElementFactory CreatehParameterElementFactory();

        ILParameterElementFactory CreateLParameterElementFactory();

        InParameterElementFactory CreatenParameterElementFactory();

        IpParameterElementFactory CreatepParameterElementFactory();

        IvParameterElementFactory CreatevParameterElementFactory();

        IwParameterElementFactory CreatewParameterElementFactory();

        IyParameterElementFactory CreateyParameterElementFactory();

        IΔParameterElementFactory CreateΔParameterElementFactory();

        IζParameterElementFactory CreateζParameterElementFactory();

        IμParameterElementFactory CreateμParameterElementFactory();

        IΡParameterElementFactory CreateΡParameterElementFactory();

        IσParameterElementFactory CreateσParameterElementFactory();

        IψParameterElementFactory CreateψParameterElementFactory();
    }
}