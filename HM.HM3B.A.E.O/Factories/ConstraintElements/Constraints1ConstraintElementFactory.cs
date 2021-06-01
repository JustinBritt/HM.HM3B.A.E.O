namespace HM.HM3B.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints1ConstraintElementFactory : IConstraints1ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElementFactory()
        {
        }

        // v and y are both variables
        public IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Iv v,
            Iy y)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    mIndexElement,
                    rIndexElement,
                    m,
                    s,
                    ζ,
                    v,
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

        // v is a variable and y is a parameter
        public IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ,
            Interfaces.Variables.Iv v)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    mIndexElement,
                    rIndexElement,
                    m,
                    s,
                    y,
                    ζ,
                    v);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }

        // v is a parameter and y is a variable
        public IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Iζ ζ,
            Interfaces.Variables.Iy y)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    mIndexElement,
                    rIndexElement,
                    m,
                    s,
                    v,
                    ζ,
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

        // v and y are both parameters
        public IConstraints1ConstraintElement Create(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ)
        {
            IConstraints1ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints1ConstraintElement(
                    mIndexElement,
                    rIndexElement,
                    m,
                    s,
                    v,
                    y,
                    ζ);
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