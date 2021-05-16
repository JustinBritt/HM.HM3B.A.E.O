namespace HM.HM3B.A.E.O.Factories.Parameters.MaximumNumberRecoveryWardBeds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;

    internal sealed class ΩFactory : IΩFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΩFactory()
        {
        }

        public IΩ Create(
            PositiveInt value)
        {
            IΩ parameter = null;

            try
            {
                parameter = new Ω(
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