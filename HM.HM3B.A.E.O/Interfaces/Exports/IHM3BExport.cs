namespace HM.HM3B.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;

    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Configurations;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.SolverConfigurations;

    public interface IHM3BExport
    {
        Task<IHM3BOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IHM3BConfiguration HM3BConfiguration,
            IHM3BInputContext HM3BInputContext,
            ISolverConfiguration solverConfiguration,
            HM3BEncodingEnum HM3BEncodingEnum);
    }
}