namespace HM.HM3B.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;

    public interface IHM3BOutputContextFactory
    {
        IHM3BOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3BModel HM3BModel,
            Solution solution,
            HM3BEncodingEnum HM3BEncodingEnum);
    }
}