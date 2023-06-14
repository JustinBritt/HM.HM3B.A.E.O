namespace HM.HM3B.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Indices;
    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Indices;
    
    internal sealed class ΛFactory : IΛFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΛFactory()
        {
        }

        public IΛ Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IΛIndexElement> value)
        {
            IΛ index = null;

            try
            {
                index = new Λ(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, IΛIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IΛIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IΛIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IΛIndexElement>(
                nullableValueintComparer);

            foreach (IΛIndexElement ΛIndexElement in value)
            {
                redBlackTree.Add(
                    ΛIndexElement.Value,
                    ΛIndexElement);
            }

            return redBlackTree;
        }
    }
}