namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonMachineRequirements
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements;

    internal sealed class ζFactory : IζFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ζFactory()
        {
        }

        public Iζ Create(
            RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> value)
        {
            Iζ parameter = null;

            try
            {
                parameter = new ζ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}