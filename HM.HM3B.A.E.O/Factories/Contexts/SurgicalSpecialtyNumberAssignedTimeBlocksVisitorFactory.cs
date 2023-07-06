namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;

    internal sealed class SurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory : ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory()
        {
        }

        public ISurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IBParameterElementFactory BParameterElementFactory,
            Ij j)
            where TKey : Organization
            where TValue : INullableValue<int>
        {
            ISurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgicalSpecialtyNumberAssignedTimeBlocksVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    BParameterElementFactory,
                    j);
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