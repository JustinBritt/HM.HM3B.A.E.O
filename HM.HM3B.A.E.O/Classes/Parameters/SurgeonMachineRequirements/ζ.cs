namespace HM.HM3B.A.E.O.Classes.Parameters.SurgeonMachineRequirements
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;

    internal sealed class ζ : Iζ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ζ(
            ImmutableList<IζParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IζParameterElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ImIndexElement mIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.mIndexElement == mIndexElement)
                .Select(x => x.Value.Value.Value ? 1 : 0)
                .SingleOrDefault();
        }
    }
}