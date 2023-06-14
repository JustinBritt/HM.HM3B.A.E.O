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

    internal sealed class mFactory : ImFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public mFactory()
        {
        }

        public Im Create(
            IDeviceComparer deviceComparer,
            ImmutableList<ImIndexElement> value)
        {
            Im index = null;

            try
            {
                index = new m(
                    this.CreateRedBlackTree(
                        deviceComparer,
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

        private RedBlackTree<Device, ImIndexElement> CreateRedBlackTree(
            IDeviceComparer deviceComparer,
            ImmutableList<ImIndexElement> value)
        {
            RedBlackTree<Device, ImIndexElement> redBlackTree = new RedBlackTree<Device, ImIndexElement>(
                deviceComparer);

            foreach (ImIndexElement mIndexElement in value)
            {
                redBlackTree.Add(
                    mIndexElement.Value,
                    mIndexElement);
            }

            return redBlackTree;
        }
    }
}