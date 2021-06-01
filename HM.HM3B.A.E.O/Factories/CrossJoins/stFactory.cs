namespace HM.HM3B.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class stFactory : IstFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public stFactory()
        {
        }

        public Ist Create(
            ImmutableList<IstCrossJoinElement> value)
        {
            Ist crossJoin = null;

            try
            {
                crossJoin = new st(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}