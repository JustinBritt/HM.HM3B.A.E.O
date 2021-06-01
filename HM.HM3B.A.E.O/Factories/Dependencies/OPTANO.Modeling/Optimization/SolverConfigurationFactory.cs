namespace HM.HM3B.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Linq;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationFactory()
        {
        }

        public SolverConfiguration Create<T>()
            where T : global::OPTANO.Modeling.Optimization.SolverConfiguration
        {
            global::OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = (SolverConfiguration)Activator.CreateInstance(
                    this.GetSolverConfigurationType<T>());
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solverConfiguration;
        }

        private Type GetSolverConfigurationType<T>()
            where T : global::OPTANO.Modeling.Optimization.SolverConfiguration
        {
            return typeof(T)
                .Assembly
                .GetExportedTypes()
                .Where(w => w.FullName == typeof(T).FullName)
                .SingleOrDefault();
        }
    }
}