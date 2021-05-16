namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioUtilizedTimes
{
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    
    internal sealed class ScenarioUtilizedTimesResultElementCalculation : IScenarioUtilizedTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElementCalculation()
        {
        }

        public IScenarioUtilizedTimesResultElement Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IΛIndexElement ΛIndexElement,
            Isrt srt,
            Ih h,
            In n,
            Ix x)
        {
            return scenarioUtilizedTimesResultElementFactory.Create(
                ΛIndexElement,
                srt.Value.Select(w =>
                x.GetElementAtAsint(
                    w.sIndexElement,
                    w.rIndexElement,
                    w.tIndexElement)
                *
                n.GetElementAtAsint(
                    w.sIndexElement,
                    ΛIndexElement)
                *
                h.GetElementAtAsdecimal(
                    w.sIndexElement,
                    ΛIndexElement))
                .Sum());
        }
    }
}