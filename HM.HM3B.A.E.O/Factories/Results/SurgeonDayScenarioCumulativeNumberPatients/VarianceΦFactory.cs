namespace HM.HM3B.A.E.O.Factories.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;

    internal sealed class VarianceΦFactory : IVarianceΦFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceΦFactory()
        {
        }

        public IVarianceΦ Create(
            ImmutableList<IVarianceΦResultElement> value)
        {
            IVarianceΦ result = null;

            try
            {
                result = new VarianceΦ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}