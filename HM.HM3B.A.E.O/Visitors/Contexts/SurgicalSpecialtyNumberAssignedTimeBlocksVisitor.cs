namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal class SurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue> : ISurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedTimeBlocksVisitor(
            IBParameterElementFactory BParameterElementFactory,
            Ij j)
        {
            this.BParameterElementFactory = BParameterElementFactory;

            this.j = j;

            this.RedBlackTree = new RedBlackTree<IjIndexElement, IBParameterElement>();
        }

        private IBParameterElementFactory BParameterElementFactory { get; }

        private Ij j { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IjIndexElement, IBParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = this.j.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                jIndexElement,
                this.BParameterElementFactory.Create(
                    jIndexElement,
                    obj.Value));
        }
    }
}