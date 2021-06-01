namespace HM.HM3B.A.E.O.Factories.ParameterElements.MachineOperatingRoomAssignments
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments;

    internal sealed class vParameterElementFactory : IvParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vParameterElementFactory()
        {
        }

        public IvParameterElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value)
        {
            IvParameterElement parameterElement = null;

            try
            {
                parameterElement = new vParameterElement(
                    mIndexElement,
                    rIndexElement,
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