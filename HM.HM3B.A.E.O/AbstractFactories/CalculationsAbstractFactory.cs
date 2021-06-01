namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Factories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Factories.Calculations.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.Factories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardServiceLevels;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioRequiredNumberBeds;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonNumberAssignedWeekdays;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedOperatingRooms;
    using HM.HM3B.A.E.O.InterfacesFactories.Calculations.SurgicalSpecialtyNumberAssignedWeekdays;

    internal sealed class CalculationsAbstractFactory : ICalculationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CalculationsAbstractFactory()
        {
        }

        public IEBSCalculationFactory CreateEBSCalculationFactory()
        {
            IEBSCalculationFactory factory = null;

            try
            {
                factory = new EBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory()
        {
            IEBSResultElementCalculationFactory factory = null;

            try
            {
                factory = new EBSResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueICalculationFactory CreateExpectedValueICalculationFactory()
        {
            IExpectedValueICalculationFactory factory = null;

            try
            {
                factory = new ExpectedValueICalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueIResultElementCalculationFactory CreateExpectedValueIResultElementCalculationFactory()
        {
            IExpectedValueIResultElementCalculationFactory factory = null;

            try
            {
                factory = new ExpectedValueIResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueΦCalculationFactory CreateExpectedValueΦCalculationFactory()
        {
            IExpectedValueΦCalculationFactory factory = null;

            try
            {
                factory = new ExpectedValueΦCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IExpectedValueΦResultElementCalculationFactory CreateExpectedValueΦResultElementCalculationFactory()
        {
            IExpectedValueΦResultElementCalculationFactory factory = null;

            try
            {
                factory = new ExpectedValueΦResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMRNBCalculationFactory CreateMRNBCalculationFactory()
        {
            IMRNBCalculationFactory factory = null;

            try
            {
                factory = new MRNBCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRNBCalculationFactory CreateRNBCalculationFactory()
        {
            IRNBCalculationFactory factory = null;

            try
            {
                factory = new RNBCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory()
        {
            IScenarioNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory()
        {
            IScenarioNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory()
        {
            IScenarioTotalTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory()
        {
            IScenarioTotalTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioTotalTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory()
        {
            IScenarioUnderutilizationsCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory()
        {
            IScenarioUnderutilizationsResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnderutilizationsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory()
        {
            IScenarioUnutilizedTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory()
        {
            IScenarioUnutilizedTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUnutilizedTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory()
        {
            IScenarioUtilizedTimesCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory()
        {
            IScenarioUtilizedTimesResultElementCalculationFactory factory = null;

            try
            {
                factory = new ScenarioUtilizedTimesResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            ISurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedWeekdaysCalculationFactory CreateSurgeonNumberAssignedWeekdaysCalculationFactory()
        {
            ISurgeonNumberAssignedWeekdaysCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedWeekdaysCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory()
        {
            ISurgeonNumberAssignedWeekdaysResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonNumberAssignedWeekdaysResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory()
        {
            ISurgeonScenarioNumberPatientsCalculationFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory()
        {
            ISurgeonScenarioNumberPatientsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgeonScenarioNumberPatientsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory()
        {
            ISurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory factory = null;

            try
            {
                factory = new SurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM3B.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage.ITEBSCalculationFactory CreateTEBSCalculationFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.Calculations.TotalExpectedBedShortage.ITEBSCalculationFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.Calculations.TotalExpectedBedShortage.TEBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages.ITEBSCalculationFactory CreateTEBSΛCalculationFactory()
        {
            HM.HM3B.A.E.O.InterfacesFactories.Calculations.ScenarioTotalExpectedBedShortages.ITEBSCalculationFactory factory = null;

            try
            {
                factory = new HM.HM3B.A.E.O.Factories.Calculations.ScenarioTotalExpectedBedShortages.TEBSCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITEBSResultElementCalculationFactory CreateTEBSΛResultElementCalculationFactory()
        {
            ITEBSResultElementCalculationFactory factory = null;

            try
            {
                factory = new TEBSResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItStarCalculationFactory CreatetStarCalculationFactory()
        {
            ItStarCalculationFactory factory = null;

            try
            {
                factory = new tStarCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceICalculationFactory CreateVarianceICalculationFactory()
        {
            IVarianceICalculationFactory factory = null;

            try
            {
                factory = new VarianceICalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceIResultElementCalculationFactory CreateVarianceIResultElementCalculationFactory()
        {
            IVarianceIResultElementCalculationFactory factory = null;

            try
            {
                factory = new VarianceIResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceΦCalculationFactory CreateVarianceΦCalculationFactory()
        {
            IVarianceΦCalculationFactory factory = null;

            try
            {
                factory = new VarianceΦCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVarianceΦResultElementCalculationFactory CreateVarianceΦResultElementCalculationFactory()
        {
            IVarianceΦResultElementCalculationFactory factory = null;

            try
            {
                factory = new VarianceΦResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVHatCalculationFactory CreateVHatCalculationFactory()
        {
            IVHatCalculationFactory factory = null;

            try
            {
                factory = new VHatCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVHatResultElementCalculationFactory CreateVHatResultElementCalculationFactory()
        {
            IVHatResultElementCalculationFactory factory = null;

            try
            {
                factory = new VHatResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iυ2CalculationFactory Createυ2CalculationFactory()
        {
            Iυ2CalculationFactory factory = null;

            try
            {
                factory = new υ2CalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public Iυ2ResultElementCalculationFactory Createυ2ResultElementCalculationFactory()
        {
            Iυ2ResultElementCalculationFactory factory = null;

            try
            {
                factory = new υ2ResultElementCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦHatCalculationFactory CreateΦHatCalculationFactory()
        {
            IΦHatCalculationFactory factory = null;

            try
            {
                factory = new ΦHatCalculationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΦHatResultElementCalculationFactory CreateΦHatResultElementCalculationFactory()
        {
            IΦHatResultElementCalculationFactory factory = null;

            try
            {
                factory = new ΦHatResultElementCalculationFactory();
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