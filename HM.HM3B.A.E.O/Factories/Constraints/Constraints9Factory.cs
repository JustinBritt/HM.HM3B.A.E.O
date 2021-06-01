namespace HM.HM3B.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Constraints;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.Constraints;
    using HM.HM3B.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints9Factory : IConstraints9Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9Factory()
        {
        }

        public IConstraints9 Create(
            ImmutableList<IConstraints9ConstraintElement> value)
        {
            IConstraints9 constraint = null;

            try
            {
                constraint = new Constraints9(
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