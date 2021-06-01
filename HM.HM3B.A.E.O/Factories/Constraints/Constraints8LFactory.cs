namespace HM.HM3B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Constraints;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;
    using HM.HM3B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints8LFactory : IConstraints8LFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8LFactory()
        {
        }

        public IConstraints8L Create(
            ImmutableList<IConstraints8LConstraintElement> value)
        {
            IConstraints8L constraint = null;

            try
            {
                constraint = new Constraints8L(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}