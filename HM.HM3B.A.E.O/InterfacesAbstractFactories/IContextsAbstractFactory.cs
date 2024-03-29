﻿namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory();

        IHM3BInputContextFactory CreateHM3BInputContextFactory();

        IHM3BOutputContextFactory CreateHM3BOutputContextFactory();

        IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory();

        IScenarioProbabilitiesVisitorFactory CreateScenarioProbabilitiesVisitorFactory();

        ISurgeonLengthOfStayMaximumsVisitorFactory CreateSurgeonLengthOfStayMaximumsVisitorFactory();

        ISurgeonNumberAssignedTimeBlocksVisitorFactory CreateSurgeonNumberAssignedTimeBlocksVisitorFactory();

        ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory();

        ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory CreateSurgicalSpecialtyNumberAssignedTimeBlocksVisitor();
    }
}