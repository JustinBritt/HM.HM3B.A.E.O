namespace HM.HM3B.A.E.O.Factories.Results.NumberOfExploredNodes
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.NumberOfExploredNodes;
    using HM.HM3B.A.E.O.Interfaces.Results.NumberOfExploredNodes;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodesFactory : INumberOfExploredNodesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodesFactory()
        {
        }

        public INumberOfExploredNodes Create(
            long value)
        {
            INumberOfExploredNodes result = null;

            try
            {
                result = new NumberOfExploredNodes(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}