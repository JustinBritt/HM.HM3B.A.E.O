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

    internal sealed class Constraints8LConstraintElementFactory : IConstraints8LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8LConstraintElementFactory()
        {
        }

        public IConstraints8LConstraintElement Create(
            IdIndexElement dIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ir r,
            Ix x,
            Iz z)
        {
            IConstraints8LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints8LConstraintElement(
                    dIndexElement,
                    sIndexElement,
                    tIndexElement,
                    r,
                    x,
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