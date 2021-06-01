namespace HM.HM3B.A.E.O.Factories.Parameters.SurgicalSpecialties
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;

    internal sealed class ΔFactory : IΔFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΔFactory()
        {
        }

        public IΔ Create(
            ImmutableList<IΔParameterElement> value)
        {
            IΔ parameter = null;

            try
            {
                parameter = new Δ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}