namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class β : Interfaces.Variables.Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            VariableCollection<IsIndexElement, IrIndexElement, IdIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement, IdIndexElement> Value { get; }

        public int GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[sIndexElement, rIndexElement, dIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[sIndexElement, rIndexElement, dIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks.Iβ GetElementsAt(
            IβResultElementFactory βResultElementFactory,
            IβFactory βFactory,
            Id d,
            Ir r,
            Is s)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>> firstInnerRedBlackTree = new RedBlackTree<IrIndexElement, RedBlackTree<IdIndexElement, IβResultElement>>();

                foreach (IrIndexElement rIndexElement in r.Value.Values)
                {
                    RedBlackTree<IdIndexElement, IβResultElement> secondInnerRedBlackTree = new RedBlackTree<IdIndexElement, IβResultElement>();

                    foreach (IdIndexElement dIndexElement in d.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            dIndexElement,
                            βResultElementFactory.Create(
                                sIndexElement,
                                rIndexElement,
                                dIndexElement,
                                this.GetElementAt(
                                    sIndexElement,
                                    rIndexElement,
                                    dIndexElement)));
                    }

                    firstInnerRedBlackTree.Add(
                        rIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    firstInnerRedBlackTree);
            }

            return βFactory.Create(
                outerRedBlackTree);
        }
    }
}           