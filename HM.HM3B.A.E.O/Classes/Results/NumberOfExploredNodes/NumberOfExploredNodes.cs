namespace HM.HM3B.A.E.O.Classes.Results.NumberOfExploredNodes
{
    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Results.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodes : INumberOfExploredNodes
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodes(
            long value)
        {
            this.Value = value;
        }

        public long Value { get; }

        public long GetValueForOutputContext()
        {
            return this.Value;
        }
    }
}