namespace HM.HM3B.A.E.O.Classes.Indices
{
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    
    internal sealed class m : Im
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public m(
            RedBlackTree<Device, ImIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Device, ImIndexElement> Value { get; }

        public ImIndexElement GetElementAt(
            Device value)
        {
            return this.Value[value];
        }

        public int GetM()
        {
            return this.Value.Values
                .Distinct()
                .Count();
        }
    }
}