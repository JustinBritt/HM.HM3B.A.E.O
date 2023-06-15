namespace HM.HM3B.A.E.O.Factories.Comparers
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Comparers;
    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Comparers;

    internal sealed class FhirDateTimeComparerFactory : IFhirDateTimeComparerFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FhirDateTimeComparerFactory()
        {
        }

        public IFhirDateTimeComparer Create()
        {
            IFhirDateTimeComparer instance = null;

            try
            {
                instance = new FhirDateTimeComparer();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}