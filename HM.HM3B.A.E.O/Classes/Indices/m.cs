namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class m : Im
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public m(
            ImmutableList<ImIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ImIndexElement> Value { get; }

        public ImIndexElement GetElementAt(
            Device value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }

        public int GetM()
        {
            return this.Value
                .Distinct()
                .Count();
        }
    }
}