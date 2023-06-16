namespace HM.HM3B.A.E.O.Classes.Calculations.ScenarioRequiredNumberBeds
{
    using System.Collections.Generic;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    internal sealed class tStarCalculation : ItStarCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public tStarCalculation()
        {
        }

        public ItIndexElement Calculate(
            INormalFactory normalFactory,
            IRNBCalculation RNBCalculation,
            IΛIndexElement ΛIndexElement,
            It t,
            IExpectedValueI expectedValueI,
            IVarianceI varianceI,
            Iυ2 υ2)
        {
            return t.Value.Values
                .Select(i =>
                KeyValuePair.Create(
                    i,
                    RNBCalculation.Calculate(
                        normalFactory,
                        i,
                        ΛIndexElement,
                        expectedValueI,
                        varianceI,
                        υ2.GetElementAtAsdecimal(
                            ΛIndexElement))))
                .OrderBy(i => i.Value)
                .LastOrDefault()
                .Key;
        }
    }
}