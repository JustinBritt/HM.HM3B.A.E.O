namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class wParameterElementFactory : IwParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wParameterElementFactory()
        {
        }

        public IwParameterElement Create(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement,
            FhirBoolean value)
        {
            IwParameterElement parameterElement = null;

            try
            {
                parameterElement = new wParameterElement(
                    jIndexElement,
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