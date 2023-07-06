namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            VariableCollection<IsIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.GetElementAt(
                sIndexElement,
                tIndexElement)
                ? 1 : 0;
        }

        public ImmutableList<Tuple<Organization, FhirDateTime, bool>> GetElementsAt(
            Ist st)
        {
            return st.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.tIndexElement.Value,
                    this.GetElementAt(
                        i.sIndexElement,
                        i.tIndexElement)))
                .ToImmutableList();
        }

        public Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Is s,
            It t)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IsIndexElement, RedBlackTree<ItIndexElement, IzResultElement>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<ItIndexElement, IzResultElement> innerRedBlackTree = redBlackTreeFactory.Create<ItIndexElement, IzResultElement>();

                foreach (ItIndexElement tIndexElement in t.Value.Values)
                {
                    innerRedBlackTree.Add(
                        tIndexElement,
                        zResultElementFactory.Create(
                            sIndexElement,
                            tIndexElement,
                            this.GetElementAt(
                                sIndexElement,
                                tIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    innerRedBlackTree);
            }

            return zFactory.Create(
                outerRedBlackTree);
        }
    }
}