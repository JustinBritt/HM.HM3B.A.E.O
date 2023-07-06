namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonNumberAssignedTimeBlocksVisitorFactory : ISurgeonNumberAssignedTimeBlocksVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonNumberAssignedTimeBlocksVisitorFactory()
        {
        }

        public ISurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IBParameterElementFactory BParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<int>
        {
            ISurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonNumberAssignedTimeBlocksVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    BParameterElementFactory,
                    s);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}