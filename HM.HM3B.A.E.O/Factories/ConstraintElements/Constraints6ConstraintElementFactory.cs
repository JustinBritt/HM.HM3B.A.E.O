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

    internal sealed class Constraints6ConstraintElementFactory : IConstraints6ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElementFactory()
        {
        }

        public IConstraints6ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Id d,
            Ib b,
            Iβ β)
        {
            IConstraints6ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints6ConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    d,
                    b,
                    β);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}