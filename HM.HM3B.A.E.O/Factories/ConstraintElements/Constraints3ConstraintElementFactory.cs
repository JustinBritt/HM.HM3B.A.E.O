namespace HM.HM3B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints3ConstraintElementFactory : IConstraints3ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElementFactory()
        {
        }

        public IConstraints3ConstraintElement Create(
            IrIndexElement rIndexElement,
            Is s,
            It t,
            Ib b,
            Iγ γ)
        {
            IConstraints3ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints3ConstraintElement(
                    rIndexElement,
                    s,
                    t,
                    b,
                    γ);
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