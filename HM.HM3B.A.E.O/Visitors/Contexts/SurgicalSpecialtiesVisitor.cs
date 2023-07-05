namespace HM.HM3B.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgicalSpecialtiesVisitor<TKey, TValue> : ISurgicalSpecialtiesVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : IImmutableSet<Organization>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtiesVisitor(
            IRedBlackTreeFactory redBlackTreeFactory,
            IΔParameterElementFactory ΔParameterElementFactory,
            Ij j,
            Is s)
        {
            this.ΔParameterElementFactory = ΔParameterElementFactory;

            this.j = j;

            this.s = s;

            this.Value = new List<IΔParameterElement>();

            this.RedBlackTree = redBlackTreeFactory.Create<IjIndexElement, ImmutableList<IsIndexElement>>();
        }

        private IΔParameterElementFactory ΔParameterElementFactory { get; }

        private Ij j { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IjIndexElement, ImmutableList<IsIndexElement>> RedBlackTree { get; }

        public List<IΔParameterElement> Value { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = this.j.GetElementAt(
                obj.Key);

            ImmutableList<IsIndexElement> value = obj.Value.Select(w => this.s.GetElementAt(w)).ToImmutableList();

            this.RedBlackTree.Add(
                jIndexElement,
                value);

            this.Value.Add(
                this.ΔParameterElementFactory.Create(
                    jIndexElement,
                    value));
        }
    }
}