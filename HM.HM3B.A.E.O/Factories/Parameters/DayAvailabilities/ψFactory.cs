namespace HM.HM3B.A.E.O.Factories.Parameters.DayAvailabilities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;

    internal sealed class ψFactory : IψFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ψFactory()
        {
        }

        public Iψ Create(
            ImmutableList<IψParameterElement> value)
        {
            Iψ parameter = null;

            try
            {
                parameter = new ψ(
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