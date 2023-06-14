namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonMachineRequirements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;

    internal sealed class ζParameterElementFactory : IζParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ζParameterElementFactory()
        {
        }

        public IζParameterElement Create(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement,
            INullableValue<bool> value)
        {
            IζParameterElement parameterElement = null;

            try
            {
                parameterElement = new ζParameterElement(
                    sIndexElement,
                    mIndexElement,
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