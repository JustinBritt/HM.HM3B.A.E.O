namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Factories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Factories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Factories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Factories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class ResultElementsAbstractFactory : IResultElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultElementsAbstractFactory()
        {
        }

        public IEBSResultElementFactory CreateEBSResultElementFactory()
        {
            IEBSResultElementFactory factory = null;

            try
            {
                factory = new EBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueIResultElementFactory CreateExpectedValueIResultElementFactory()
        {
            IExpectedValueIResultElementFactory factory = null;

            try
            {
                factory = new ExpectedValueIResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueΦResultElementFactory CreateExpectedValueΦResultElementFactory()
        {
            IExpectedValueΦResultElementFactory factory = null;

            try
            {
                factory = new ExpectedValueΦResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsResultElementFactory CreateScenarioNumberPatientsResultElementFactory()
        {
            IScenarioNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesResultElementFactory CreateScenarioTotalTimesResultElementFactory()
        {
            IScenarioTotalTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsResultElementFactory CreateScenarioUnderutilizationsResultElementFactory()
        {
            IScenarioUnderutilizationsResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesResultElementFactory CreateScenarioUnutilizedTimesResultElementFactory()
        {
            IScenarioUnutilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesResultElementFactory CreateScenarioUtilizedTimesResultElementFactory()
        {
            IScenarioUtilizedTimesResultElementFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedWeekdaysResultElementFactory CreateSurgeonNumberAssignedWeekdaysResultElementFactory()
        {
            ISurgeonNumberAssignedWeekdaysResultElementFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedWeekdaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsResultElementFactory CreateSurgeonScenarioNumberPatientsResultElementFactory()
        {
            ISurgeonScenarioNumberPatientsResultElementFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITEBSResultElementFactory CreateTEBSΛResultElementFactory()
        {
            ITEBSResultElementFactory factory = null;

            try
            {
                factory = new TEBSResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceIResultElementFactory CreateVarianceIResultElementFactory()
        {
            IVarianceIResultElementFactory factory = null;

            try
            {
                factory = new VarianceIResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceΦResultElementFactory CreateVarianceΦResultElementFactory()
        {
            IVarianceΦResultElementFactory factory = null;

            try
            {
                factory = new VarianceΦResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVHatResultElementFactory CreateVHatResultElementFactory()
        {
            IVHatResultElementFactory factory = null;

            try
            {
                factory = new VHatResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IxResultElementFactory CreatexResultElementFactory()
        {
            IxResultElementFactory factory = null;

            try
            {
                factory = new xResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IyResultElementFactory CreateyResultElementFactory()
        {
            IyResultElementFactory factory = null;

            try
            {
                factory = new yResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IzResultElementFactory CreatezResultElementFactory()
        {
            IzResultElementFactory factory = null;

            try
            {
                factory = new zResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IβResultElementFactory CreateβResultElementFactory()
        {
            IβResultElementFactory factory = null;

            try
            {
                factory = new βResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IγResultElementFactory CreateγResultElementFactory()
        {
            IγResultElementFactory factory = null;

            try
            {
                factory = new γResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iυ2ResultElementFactory Createυ2ResultElementFactory()
        {
            Iυ2ResultElementFactory factory = null;

            try
            {
                factory = new υ2ResultElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦHatResultElementFactory CreateΦHatResultElementFactory()
        {
            IΦHatResultElementFactory factory = null;

            try
            {
                factory = new ΦHatResultElementFactory();
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