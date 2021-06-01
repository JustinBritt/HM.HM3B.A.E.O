namespace HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;

    internal sealed class ΔParameterElementFactory : IΔParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΔParameterElementFactory()
        {
        }

        public IΔParameterElement Create(
            IjIndexElement jIndexElement,
            ImmutableList<IsIndexElement> value)
        {
            IΔParameterElement parameterElement = null;

            try
            {
                parameterElement = new ΔParameterElement(
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