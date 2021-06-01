namespace HM.HM3B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Constraints;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;
    using HM.HM3B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints6Factory : IConstraints6Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6Factory()
        {
        }

        public IConstraints6 Create(
            ImmutableList<IConstraints6ConstraintElement> value)
        {
            IConstraints6 constraint = null;

            try
            {
                constraint = new Constraints6(
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