namespace HM.HM3B.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            VariableCollection<IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IrIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[rIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.OperatingRoomDayAssignedAvailabilities.Iγ GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IγResultElementFactory γResultElementFactory,
            IγFactory γFactory,
            Ir r,
            It t)
        {
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> outerRedBlackTree = redBlackTreeFactory.Create<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>>();

            foreach (IrIndexElement rIndexElement in r.Value.Values)
            {
                RedBlackTree<ItIndexElement, IγResultElement> innerRedBlackTree = redBlackTreeFactory.Create<ItIndexElement, IγResultElement>();

                foreach (ItIndexElement tIndexElement in t.Value.Values)
                {
                    innerRedBlackTree.Add(
                        tIndexElement,
                        γResultElementFactory.Create(
                            rIndexElement,
                            tIndexElement,
                            this.GetElementAt(
                                rIndexElement,
                                tIndexElement)));
                }

                outerRedBlackTree.Add(
                    rIndexElement,
                    innerRedBlackTree);
            }

            return γFactory.Create(
                outerRedBlackTree);
        }
    }
}