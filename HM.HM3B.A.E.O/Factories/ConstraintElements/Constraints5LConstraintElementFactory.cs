namespace HM.HM3B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints5LConstraintElementFactory : IConstraints5LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5LConstraintElementFactory()
        {
        }

        // y is a variable
        public IConstraints5LConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Ib b,
            Iy y)
        {
            IConstraints5LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5LConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    b,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }

        // y is a parameter
        public IConstraints5LConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Ib b)
        {
            IConstraints5LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints5LConstraintElement(
                    rIndexElement,
                    sIndexElement,
                    y,
                    b);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}