namespace HM.HM3B.A.E.O.Factories.Results.SurgeonDayScenarioCumulativeNumberPatients
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;
    
    internal sealed class ExpectedValueΦFactory : IExpectedValueΦFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ExpectedValueΦFactory()
        {
        }

        public IExpectedValueΦ Create(
            ImmutableList<IExpectedValueΦResultElement> value,
            Il l,
            Is s,
            IΛ Λ)
        {
            IExpectedValueΦ result = null;

            try
            {
                result = new ExpectedValueΦ(
                    this.CreateRedBlackTree(
                        value,
                        l,
                        s,
                        Λ));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }

        private RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>> CreateRedBlackTree(
            ImmutableList<IExpectedValueΦResultElement> value,
            Il l,
            Is s,
            IΛ Λ)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>> outerRedBlackTree = new RedBlackTree<IsIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>>();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>> firstInnerRedBlackTree = new RedBlackTree<IlIndexElement, RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>>();

                foreach (IlIndexElement lIndexElement in l.Value.Values)
                {
                    RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement> secondInnerRedBlackTree = new RedBlackTree<IΛIndexElement, IExpectedValueΦResultElement>();

                    foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                    {
                        secondInnerRedBlackTree.Add(
                            ΛIndexElement,
                            value.Where(w => w.sIndexElement == sIndexElement && w.lIndexElement == lIndexElement && w.ΛIndexElement == ΛIndexElement).SingleOrDefault());
                    }

                    firstInnerRedBlackTree.Add(
                        lIndexElement,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    firstInnerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}