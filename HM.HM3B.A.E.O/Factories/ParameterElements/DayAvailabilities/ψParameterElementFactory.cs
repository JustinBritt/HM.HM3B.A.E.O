namespace HM.HM3B.A.E.O.Factories.ParameterElements.DayAvailabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;

    internal sealed class ψParameterElementFactory : IψParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ψParameterElementFactory()
        {
        }

        public IψParameterElement Create(
            ItIndexElement tIndexElement,
            INullableValue<bool> value)
        {
            IψParameterElement parameterElement = null;

            try
            {
                parameterElement = new ψParameterElement(
                    tIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}