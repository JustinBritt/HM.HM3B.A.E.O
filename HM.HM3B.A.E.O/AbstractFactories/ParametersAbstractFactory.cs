namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.Factories.Parameters.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Factories.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.Factories.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Factories.Parameters.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.Parameters.TimeBlockLength;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonMachineRequirements;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.TimeBlockLength;

    internal sealed class ParametersAbstractFactory : IParametersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ParametersAbstractFactory()
        {
        }

        public HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory CreateBBarFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory CreateBsFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonNumberAssignedTimeBlocks.IBFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.Parameters.SurgeonNumberAssignedTimeBlocks.BFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHFactory CreateHFactory()
        {
            IHFactory factory = null;

            try
            {
                factory = new HFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IhFactory CreatehFactory()
        {
            IhFactory factory = null;

            try
            {
                factory = new hFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ILFactory CreateLFactory()
        {
            ILFactory factory = null;

            try
            {
                factory = new LFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public InFactory CreatenFactory()
        {
            InFactory factory = null;

            try
            {
                factory = new nFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IvFactory CreatevFactory()
        {
            IvFactory factory = null;

            try
            {
                factory = new vFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWFactory CreateWFactory()
        {
            IWFactory factory = null;

            try
            {
                factory = new WFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwFactory CreatewFactory()
        {
            IwFactory factory = null;

            try
            {
                factory = new wFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IyFactory CreateyFactory()
        {
            IyFactory factory = null;

            try
            {
                factory = new yFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΔFactory CreateΔFactory()
        {
            IΔFactory factory = null;

            try
            {
                factory = new ΔFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IζFactory CreateζFactory()
        {
            IζFactory factory = null;

            try
            {
                factory = new ζFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IμFactory CreateμFactory()
        {
            IμFactory factory = null;

            try
            {
                factory = new μFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΡFactory CreateΡFactory()
        {
            IΡFactory factory = null;

            try
            {
                factory = new ΡFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IσFactory CreateσFactory()
        {
            IσFactory factory = null;

            try
            {
                factory = new σFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IψFactory CreateψFactory()
        {
            IψFactory factory = null;

            try
            {
                factory = new ψFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΩFactory CreateΩFactory()
        {
            IΩFactory factory = null;

            try
            {
                factory = new ΩFactory();
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