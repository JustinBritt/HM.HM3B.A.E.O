namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;

    internal sealed class BParameterElementFactory : IBParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BParameterElementFactory()
        {
        }

        public IBParameterElement Create(
            IjIndexElement jIndexElement,
            PositiveInt value)
        {
            IBParameterElement parameterElement = null;

            try
            {
                parameterElement = new BParameterElement(
                    jIndexElement,
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