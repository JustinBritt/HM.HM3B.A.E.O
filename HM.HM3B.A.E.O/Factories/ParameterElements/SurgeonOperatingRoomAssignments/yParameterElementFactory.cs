namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomAssignments
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;

    internal sealed class yParameterElementFactory : IyParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yParameterElementFactory()
        {
        }

        public IyParameterElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value)
        {
            IyParameterElement parameterElement = null;

            try
            {
                parameterElement = new yParameterElement(
                    sIndexElement,
                    rIndexElement,
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