namespace HM.HM3B.A.E.O.Classes.Calculations.TotalExpectedBedShortage
{
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Calculations.TotalExpectedBedShortage;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage;

    internal sealed class TEBSCalculation : ITEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculation()
        {
        }

        public Interfaces.Results.TotalExpectedBedShortage.ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            IΛ Λ,
            IΡ Ρ,
            Interfaces.Results.ScenarioTotalExpectedBedShortages.ITEBS TEBS)
        {
            return TEBSFactory.Create(
                Λ.Value.Values
                .Select(w =>
                Ρ.GetElementAtAsdecimal(
                    w)
                *
                TEBS.GetElementAtAsdecimal(
                    w))
                .Sum());
        }
    }
}