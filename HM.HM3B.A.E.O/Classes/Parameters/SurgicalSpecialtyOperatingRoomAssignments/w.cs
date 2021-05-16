namespace HM.HM3B.A.E.O.Classes.Parameters.SurgicalSpecialtyOperatingRoomAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            ImmutableList<IwParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IwParameterElement> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement && x.rIndexElement == rIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}