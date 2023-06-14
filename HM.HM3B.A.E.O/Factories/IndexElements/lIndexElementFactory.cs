namespace HM.HM3B.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class lIndexElementFactory : IlIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lIndexElementFactory()
        {
        }

        public IlIndexElement Create(
            INullableValue<int> value)
        {
            IlIndexElement indexElement = null;

            try
            {
                indexElement = new lIndexElement(
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