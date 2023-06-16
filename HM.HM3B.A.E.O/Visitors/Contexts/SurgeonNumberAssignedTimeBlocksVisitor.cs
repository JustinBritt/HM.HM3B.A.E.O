namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue> : ISurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedTimeBlocksVisitor(
            IBParameterElementFactory BParameterElementFactory,
            Is s)
        {
            this.BParameterElementFactory = BParameterElementFactory;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, IBParameterElement>();
        }

        private IBParameterElementFactory BParameterElementFactory { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, IBParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                sIndexElement,
                this.BParameterElementFactory.Create(
                    sIndexElement,
                    obj.Value));
        }
    }
}