namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class Λ : IΛ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Λ(
            ImmutableList<IΛIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IΛIndexElement> Value { get; }

        public IΛIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}