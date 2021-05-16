namespace HM.HM3B.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;

    internal sealed class srd : Isrd
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public srd(
            ImmutableList<IsrdCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsrdCrossJoinElement> Value { get; }
    }
}