namespace HM.HM3B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Constraints;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;
    using HM.HM3B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints4Factory : IConstraints4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4Factory()
        {
        }

        public IConstraints4 Create(
            ImmutableList<IConstraints4ConstraintElement> value)
        {
            IConstraints4 constraint = null;

            try
            {
                constraint = new Constraints4(
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