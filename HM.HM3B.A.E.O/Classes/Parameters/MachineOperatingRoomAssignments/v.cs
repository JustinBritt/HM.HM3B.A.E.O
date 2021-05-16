namespace HM.HM3B.A.E.O.Classes.Parameters.MachineOperatingRoomAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            ImmutableList<IvParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IvParameterElement> Value { get; }

        public int GetElementAtAsint(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.mIndexElement == mIndexElement && x.rIndexElement == rIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}