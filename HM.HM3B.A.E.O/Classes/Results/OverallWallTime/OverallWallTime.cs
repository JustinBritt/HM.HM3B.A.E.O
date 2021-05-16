namespace HM.HM3B.A.E.O.Classes.Results.OverallWallTime
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.Results.OverallWallTime;

    internal sealed class OverallWallTime : IOverallWallTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OverallWallTime(
            TimeSpan value)
        {
            this.Value = value;
        }

        public TimeSpan Value { get; }

        public TimeSpan GetValueForOutputContext()
        {
            return this.Value;
        }
    }
}