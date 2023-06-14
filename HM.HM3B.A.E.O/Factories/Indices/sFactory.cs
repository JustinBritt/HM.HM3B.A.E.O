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
    
    internal sealed class sFactory : IsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sFactory()
        {
        }

        public Is Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value)
        {
            Is index = null;

            try
            {
                index = new s(
                    this.CreateRedBlackTree(
                        organizationComparer,
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

        private RedBlackTree<Organization, IsIndexElement> CreateRedBlackTree(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value)
        {
            RedBlackTree<Organization, IsIndexElement> redBlackTree = new RedBlackTree<Organization, IsIndexElement>(
                organizationComparer);

            foreach (IsIndexElement sIndexElement in value)
            {
                redBlackTree.Add(
                    sIndexElement.Value,
                    sIndexElement);
            }

            return redBlackTree;
        }
    }
}