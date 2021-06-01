namespace HM.HM3B.A.E.O.Factories.Results.Gap
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.Gap;
    using HM.HM3B.A.E.O.Interfaces.Results.Gap;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.Gap;

    internal sealed class GapFactory : IGapFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GapFactory()
        {
        }

        public IGap Create(
            decimal value)
        {
            IGap result = null;

            try
            {
                result = new Gap(
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