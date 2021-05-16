namespace HM.HM3B.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;

    internal sealed class mr : Imr
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mr(
            ImmutableList<ImrCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ImrCrossJoinElement> Value { get; }
    }
}