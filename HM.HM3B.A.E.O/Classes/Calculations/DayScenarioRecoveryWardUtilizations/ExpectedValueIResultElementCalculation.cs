namespace HM.HM3B.A.E.O.Classes.Calculations.DayScenarioRecoveryWardUtilizations
{
    using System;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;

    internal sealed class ExpectedValueIResultElementCalculation : IExpectedValueIResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueIResultElementCalculation()
        {
        }

        public IExpectedValueIResultElement Calculate(
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IExpectedValueΦ expectedValueΦ,
            Iz z)
        {
            return expectedValueIResultElementFactory.Create(
                tIndexElement,
                ΛIndexElement,
                st.Value
                .Select(w =>
                expectedValueΦ.GetElementAtAsdecimal(
                    w.sIndexElement,
                    l.GetElementAt(
                        tIndexElement.Key
                        -
                        w.tIndexElement.Key
                        +
                        (int)Math.Floor(
                            (decimal)w.tIndexElement.Key
                            /
                            (tIndexElement.Key + 1))
                        *
                        t.GetT()),
                    ΛIndexElement)
                *
                z.GetElementAtAsint(
                    w.sIndexElement,
                    w.tIndexElement))
                .Sum());
        }
    }
}