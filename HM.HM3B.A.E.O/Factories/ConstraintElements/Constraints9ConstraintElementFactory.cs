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

    internal sealed class Constraints9ConstraintElementFactory : IConstraints9ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElementFactory()
        {
        }

        public IConstraints9ConstraintElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Ix x,
            Iγ γ)
        {
            IConstraints9ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints9ConstraintElement(
                    rIndexElement,
                    tIndexElement,
                    s,
                    x,
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