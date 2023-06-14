namespace HM.HM3B.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class ΛIndexElementFactory : IΛIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΛIndexElementFactory()
        {
        }

        public IΛIndexElement Create(
            INullableValue<int> value)
        {
            IΛIndexElement indexElement = null;

            try
            {
                indexElement = new ΛIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}