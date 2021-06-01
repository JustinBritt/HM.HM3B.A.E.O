namespace HM.HM3B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints10ConstraintElementFactory : IConstraints10ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10ConstraintElementFactory()
        {
        }

        // y is a variable
        public IConstraints10ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Ix x,
            Iy y)
        {
            IConstraints10ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints10ConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    tIndexElement,
                    x,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }

        // y is a parameter
        public IConstraints10ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ix x)
        {
            IConstraints10ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints10ConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    tIndexElement,
                    y,
                    x);
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