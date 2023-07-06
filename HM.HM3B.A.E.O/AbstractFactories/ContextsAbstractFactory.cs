namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.Contexts;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public IDayAvailabilitiesVisitorFactory CreateDayAvailabilitiesVisitorFactory()
        {
            IDayAvailabilitiesVisitorFactory factory = null;

            try
            {
                factory = new DayAvailabilitiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM3BInputContextFactory CreateHM3BInputContextFactory()
        {
            IHM3BInputContextFactory factory = null;

            try
            {
                factory = new HM3BInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHM3BOutputContextFactory CreateHM3BOutputContextFactory()
        {
            IHM3BOutputContextFactory factory = null;

            try
            {
                factory = new HM3BOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory()
        {
            IPlanningHorizonVisitorFactory factory = null;

            try
            {
                factory = new PlanningHorizonVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioProbabilitiesVisitorFactory CreateScenarioProbabilitiesVisitorFactory()
        {
            IScenarioProbabilitiesVisitorFactory factory = null;

            try
            {
                factory = new ScenarioProbabilitiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonLengthOfStayMaximumsVisitorFactory CreateSurgeonLengthOfStayMaximumsVisitorFactory()
        {
            ISurgeonLengthOfStayMaximumsVisitorFactory factory = null;

            try
            {
                factory = new SurgeonLengthOfStayMaximumsVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedTimeBlocksVisitorFactory CreateSurgeonNumberAssignedTimeBlocksVisitorFactory()
        {
            ISurgeonNumberAssignedTimeBlocksVisitorFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedTimeBlocksVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtiesVisitorFactory CreateSurgicalSpecialtiesVisitorFactory()
        {
            ISurgicalSpecialtiesVisitorFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtiesVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory CreateSurgicalSpecialtyNumberAssignedTimeBlocksVisitor()
        {
            ISurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedTimeBlocksVisitorFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}