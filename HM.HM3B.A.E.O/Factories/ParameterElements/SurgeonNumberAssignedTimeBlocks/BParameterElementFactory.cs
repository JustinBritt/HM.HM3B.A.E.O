namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    internal sealed class BParameterElementFactory : IBParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BParameterElementFactory()
        {
        }

        public IBParameterElement Create(
            IsIndexElement sIndexElement,
            PositiveInt value)
        {
            IBParameterElement parameterElement = null;

            try
            {
                parameterElement = new BParameterElement(
                    sIndexElement,
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