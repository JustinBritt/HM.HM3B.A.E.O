namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonOperatingRoomAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonOperatingRoomAssignments;

    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            ImmutableList<IyParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IyParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.rIndexElement == rIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}