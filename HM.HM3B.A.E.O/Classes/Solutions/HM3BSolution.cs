namespace HM.HM3B.A.E.O.Classes.Solutions
{
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Common;
    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Interfaces;

    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Configurations;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;
    using HM.HM3B.A.E.O.Interfaces.Solutions;
    using HM.HM3B.A.E.O.Interfaces.SolverConfigurations;

    internal sealed class HM3BSolution : IHM3BSolution
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BSolution()
        {
        }

        public Task<IHM3BOutputContext> Solve(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IHM3BConfiguration HM3BConfiguration,
            IHM3BInputContext HM3BInputContext,
            ISolverConfiguration solverConfiguration,
            HM3BEncodingEnum HM3BEncodingEnum)
        {
            IHM3BOutputContext HM3BOutputContext = null;

            return Task.Run(() => 
            {
                using (ModelScope modelScope = dependenciesAbstractFactory.CreateModelScopeFactory().Create(HM3BConfiguration.Value))
                {
                    IHM3BModel model = modelsAbstractFactory.CreateHM3BModelFactory().Create(
                        comparersAbstractFactory,
                        constraintElementsAbstractFactory,
                        constraintsAbstractFactory,
                        contextsAbstractFactory,
                        crossJoinElementsAbstractFactory,
                        crossJoinsAbstractFactory,
                        dependenciesAbstractFactory,
                        indexElementsAbstractFactory,
                        indicesAbstractFactory,
                        objectiveFunctionsAbstractFactory,
                        parameterElementsAbstractFactory,
                        parametersAbstractFactory,
                        variablesAbstractFactory,
                        HM3BInputContext,
                        HM3BEncodingEnum);

                    using (ISolver solver = dependenciesAbstractFactory.CreateSolverFactory().Create(solverConfiguration))
                    {
                        Solution solution = solver?.Solve(model?.Model);

                        if (solution.ModelStatus == OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                        {
                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            HM3BOutputContext = contextsAbstractFactory.CreateHM3BOutputContextFactory().Create(
                                calculationsAbstractFactory,
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution,
                                HM3BEncodingEnum);
                        }
                    }
                }

                return HM3BOutputContext;
            });
        }
    }
}