namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.Factories.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyOperatingRoomAssignments;

    internal sealed class ParameterElementsAbstractFactory : IParameterElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParameterElementsAbstractFactory()
        {
        }

        public HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory CreateBBarParameterElementFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.IBParameterElementFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks.BParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory CreateBsParameterElementFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonNumberAssignedTimeBlocks.IBParameterElementFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.ParameterElements.SurgeonNumberAssignedTimeBlocks.BParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IhParameterElementFactory CreatehParameterElementFactory()
        {
            IhParameterElementFactory factory = null;

            try
            {
                factory = new hParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public ILParameterElementFactory CreateLParameterElementFactory()
        {
            ILParameterElementFactory factory = null;

            try
            {
                factory = new LParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public InParameterElementFactory CreatenParameterElementFactory()
        {
            InParameterElementFactory factory = null;

            try
            {
                factory = new nParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpParameterElementFactory CreatepParameterElementFactory()
        {
            IpParameterElementFactory factory = null;

            try
            {
                factory = new pParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IvParameterElementFactory CreatevParameterElementFactory()
        {
            IvParameterElementFactory factory = null;

            try
            {
                factory = new vParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwParameterElementFactory CreatewParameterElementFactory()
        {
            IwParameterElementFactory factory = null;

            try
            {
                factory = new wParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IyParameterElementFactory CreateyParameterElementFactory()
        {
            IyParameterElementFactory factory = null;

            try
            {
                factory = new yParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΔParameterElementFactory CreateΔParameterElementFactory()
        {
            IΔParameterElementFactory factory = null;

            try
            {
                factory = new ΔParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IζParameterElementFactory CreateζParameterElementFactory()
        {
            IζParameterElementFactory factory = null;

            try
            {
                factory = new ζParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IμParameterElementFactory CreateμParameterElementFactory()
        {
            IμParameterElementFactory factory = null;

            try
            {
                factory = new μParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IΡParameterElementFactory CreateΡParameterElementFactory()
        {
            IΡParameterElementFactory factory = null;

            try
            {
                factory = new ΡParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IσParameterElementFactory CreateσParameterElementFactory()
        {
            IσParameterElementFactory factory = null;

            try
            {
                factory = new σParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IψParameterElementFactory CreateψParameterElementFactory()
        {
            IψParameterElementFactory factory = null;

            try
            {
                factory = new ψParameterElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}