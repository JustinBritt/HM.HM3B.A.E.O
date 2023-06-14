namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonLengthOfStayMaximums
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;

    internal sealed class LParameterElementFactory : ILParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LParameterElementFactory()
        {
        }

        public ILParameterElement Create(
            IsIndexElement sIndexElement,
            INullableValue<int> value)
        {
            ILParameterElement parameterElement = null;

            try
            {
                parameterElement = new LParameterElement(
                    sIndexElement,
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