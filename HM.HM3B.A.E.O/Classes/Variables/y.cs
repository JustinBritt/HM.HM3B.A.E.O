namespace HM.HM3B.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            VariableCollection<IsIndexElement, IrIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, rIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomAssignments.Iy GetElementsAt(
            IyResultElementFactory yResultElementFactory,
            IyFactory yFactory,
            Ir r,
            Is s)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IrIndexElement, IyResultElement> innerRedBlackTree = new RedBlackTree<IrIndexElement, IyResultElement>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    innerRedBlackTree.Add(
                        rIndexElement,
                        yResultElementFactory.Create(
                            sIndexElement,
                            rIndexElement,
                            this.GetElementAt(
                                sIndexElement,
                                rIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    innerRedBlackTree);
            }

            return yFactory.Create(
                outerRedBlackTree);
        }
    }
}