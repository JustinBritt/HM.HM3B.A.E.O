namespace HM.HM3B.A.E.O.Classes.CrossJoins
{
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;

    internal sealed class rt : Irt
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rt(
            ImmutableList<IrtCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrtCrossJoinElement> Value { get; }
    }
}