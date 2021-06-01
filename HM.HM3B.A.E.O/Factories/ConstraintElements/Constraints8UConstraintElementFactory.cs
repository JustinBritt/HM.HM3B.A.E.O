namespace HM.HM3B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints8UConstraintElementFactory : IConstraints8UConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8UConstraintElementFactory()
        {
        }

        public IConstraints8UConstraintElement Create(
            IdIndexElement dIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iu u,
            Iz z)
        {
            IConstraints8UConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints8UConstraintElement(
                    dIndexElement,
                    sIndexElement,
                    tIndexElement,
                    u,
                    z);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}