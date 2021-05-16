namespace HM.HM3B.A.E.O.Factories.Parameters.NumberDaysPerWeek
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;

    internal sealed class WFactory : IWFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WFactory()
        {
        }

        public IW Create(
            PositiveInt value)
        {
            IW parameter = null;

            try
            {
                parameter = new W(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}