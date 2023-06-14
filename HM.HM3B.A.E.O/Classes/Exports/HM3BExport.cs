namespace HM.HM3B.A.E.O.Classes.Exports
{
    using System.Threading.Tasks;

    using log4net;

    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Configurations;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Exports;
    using HM.HM3B.A.E.O.Interfaces.SolverConfigurations;

    public sealed class HM3BExport : IHM3BExport
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BExport()
        {
        }

        public Task<IHM3BOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM3BConfiguration HM3BConfiguration,
            IHM3BInputContext HM3BInputContext,
            ISolverConfiguration solverConfiguration,
            HM3BEncodingEnum HM3BEncodingEnum)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateHM3BSolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateComparersAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                HM3BConfiguration,
                HM3BInputContext,
                solverConfiguration,
                HM3BEncodingEnum);
        }
    }
}