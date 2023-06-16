namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            RedBlackTree<INullableValue<int>, IlIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        public IlIndexElement GetElementAt(
            int day)
        {
            return this.Value.Values
                .Where(x => x.Value.Value.Value == day)
                .SingleOrDefault();
        }

        public IlIndexElement GetElementAt(
            INullableValue<int> day)
        {
            return this.Value[day];
        }
    }
}