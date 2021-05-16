namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            ImmutableList<IlIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int day)
        {
            return this.Value
                .Where(x => x.Value.Value.Value == day)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            PositiveInt day)
        {
            return this.Value
                .Where(x => x.Value == day)
                .SingleOrDefault();
        }
    }
}