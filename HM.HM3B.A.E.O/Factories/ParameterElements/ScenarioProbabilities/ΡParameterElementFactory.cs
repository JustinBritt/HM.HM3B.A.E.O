namespace HM.HM3B.A.E.O.Factories.ParameterElements.ScenarioProbabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;

    internal sealed class ΡParameterElementFactory : IΡParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡParameterElementFactory()
        {
        }

        public IΡParameterElement Create(
            IΛIndexElement ΛIndexElement,
            FhirDecimal value)
        {
            IΡParameterElement parameterElement = null;

            try
            {
                parameterElement = new ΡParameterElement(
                    ΛIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}