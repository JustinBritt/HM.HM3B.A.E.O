namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonMachineRequirementsOuterVisitor<TKey, TValue> : ISurgeonMachineRequirementsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Device, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMachineRequirementsOuterVisitor(
            IζParameterElementFactory ζParameterElementFactory,
            Im m,
            Is s)
        {
            this.ζParameterElementFactory = ζParameterElementFactory;

            this.m = m;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>>();
        }

        private IζParameterElementFactory ζParameterElementFactory { get; }

        private Im m { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, RedBlackTree<ImIndexElement, IζParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            RedBlackTree<Device, INullableValue<bool>> value = obj.Value;

            ISurgeonMachineRequirementsInnerVisitor<Device, INullableValue<bool>> innerVisitor = new SurgeonMachineRequirementsInnerVisitor<Device, INullableValue<bool>>(
                this.ζParameterElementFactory,
                sIndexElement,
                this.m);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                sIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}