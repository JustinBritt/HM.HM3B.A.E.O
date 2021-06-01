namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Classes.Contexts;
    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;

    internal sealed class HM3BOutputContextFactory : IHM3BOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BOutputContextFactory()
        {
        }

        public IHM3BOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3BModel HM3BModel,
            Solution solution,
            HM3BEncodingEnum HM3BEncodingEnum)
        {
            IHM3BOutputContext context = null;

            try
            {
                context = new HM3BOutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    HM3BModel,
                    solution,
                    HM3BEncodingEnum);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}