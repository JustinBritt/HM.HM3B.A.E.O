namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;

    internal sealed class σParameterElementFactory : IσParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public σParameterElementFactory()
        {
        }

        public IσParameterElement Create(
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            INullableValue<decimal> value)
        {
            IσParameterElement parameterElement = null;

            try
            {
                parameterElement = new σParameterElement(
                    sIndexElement,
                    ΛIndexElement,
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