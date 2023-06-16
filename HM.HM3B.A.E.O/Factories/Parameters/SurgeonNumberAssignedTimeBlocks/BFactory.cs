namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks;

    internal sealed class BFactory : IBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BFactory()
        {
        }

        public IB Create(
            RedBlackTree<IsIndexElement, IBParameterElement> value)
        {
            IB parameter = null;

            try
            {
                parameter = new B(
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