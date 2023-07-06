namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;

    internal sealed class ScenarioProbabilitiesVisitorFactory : IScenarioProbabilitiesVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioProbabilitiesVisitorFactory()
        {
        }

        public IScenarioProbabilitiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IΡParameterElementFactory ΡParameterElementFactory,
            IΛ Λ)
            where TKey : INullableValue<int>
            where TValue : INullableValue<decimal>
        {
            IScenarioProbabilitiesVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new ScenarioProbabilitiesVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    ΡParameterElementFactory,
                    Λ);
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