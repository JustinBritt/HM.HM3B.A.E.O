namespace HM.HM3B.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Enums;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.Interfaces.Contexts;
    using HM.HM3B.A.E.O.Interfaces.Models;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioExpectedBedShortages;
    using HM.HM3B.A.E.O.Interfaces.Results.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    
    internal sealed class HM3BOutputContext : IHM3BOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IComparersAbstractFactory comparersAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IHM3BModel HM3BModel,
            Solution solution,
            HM3BEncodingEnum HM3BEncodingEnum)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // x(s, r, t)
            Ix x = HM3BModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreatexResultElementFactory(),
                resultsAbstractFactory.CreatexFactory(),
                HM3BModel.srt);

            this.SurgeonOperatingRoomDayAssignments = x
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonNumberAssignedOperatingRooms
            this.SurgeonNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateSurgeonNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                HM3BModel.s,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonNumberAssignedWeekdays
            this.SurgeonNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysFactory(),
                calculationsAbstractFactory.CreateSurgeonNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                HM3BModel.s,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonScenarioNumberPatients
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients = calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonScenarioNumberPatientsFactory(),
                calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory().Create(),
                HM3BModel.rt,
                HM3BModel.sΛ,
                HM3BModel.n,
                x);
            
            this.SurgeonScenarioNumberPatients = surgeonScenarioNumberPatients.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgicalSpecialtyNumberAssignedOperatingRooms
            this.SurgicalSpecialtyNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                HM3BModel.Δ,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgicalSpecialtyNumberAssignedWeekdays
            this.SurgicalSpecialtyNumberAssignedWeekdays = calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementFactory(),
                resultsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysFactory(),
                calculationsAbstractFactory.CreateSurgicalSpecialtyNumberAssignedWeekdaysResultElementCalculationFactory().Create(),
                HM3BModel.Δ,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // y(s, r)
            Iy y = HM3BEncodingEnum switch
            {
                HM3BEncodingEnum.E001 => ((IHM3B001Model)HM3BModel).y.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateyResultElementFactory(),
                    resultsAbstractFactory.CreateyFactory(),
                    ((IHM3B001Model)HM3BModel).r,
                    ((IHM3B001Model)HM3BModel).s),

                HM3BEncodingEnum.E011 => ((IHM3B011Model)HM3BModel).y.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateyResultElementFactory(),
                    resultsAbstractFactory.CreateyFactory(),
                    ((IHM3B011Model)HM3BModel).r,
                    ((IHM3B011Model)HM3BModel).s),
                
                HM3BEncodingEnum.E101 => ((IHM3B101Model)HM3BModel).y.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateyResultElementFactory(),
                    resultsAbstractFactory.CreateyFactory(),
                    ((IHM3B101Model)HM3BModel).r,
                    ((IHM3B101Model)HM3BModel).s),

                HM3BEncodingEnum.E111 => ((IHM3B111Model)HM3BModel).y.GetElementsAt(
                    dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                    resultElementsAbstractFactory.CreateyResultElementFactory(),
                    resultsAbstractFactory.CreateyFactory(),
                    ((IHM3B111Model)HM3BModel).r,
                    ((IHM3B111Model)HM3BModel).s),

                _ => null
            };

            if (y != null)
            {
                this.SurgeonOperatingRoomAssignments = y
                    .GetValueForOutputContext(
                    comparersAbstractFactory.CreateLocationComparerFactory(),
                    comparersAbstractFactory.CreateOrganizationComparerFactory(),
                    dependenciesAbstractFactory.CreateNullableValueFactory());
            }

            // z(s, t) 
            Iz z = HM3BModel.z.GetElementsAt(
                resultElementsAbstractFactory.CreatezResultElementFactory(),
                resultsAbstractFactory.CreatezFactory(),
                HM3BModel.st);

            this.SurgeonDayAssignments = z
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // β(s, r, d)
            this.SurgeonOperatingRoomDayNumberAssignedTimeBlocks = HM3BModel.β.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.CreateβResultElementFactory(),
                resultsAbstractFactory.CreateβFactory(),
                HM3BModel.d,
                HM3BModel.r,
                HM3BModel.s)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // γ(r, t)
            this.OperatingRoomDayAssignedAvailabilities = HM3BModel.γ.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.CreateγResultElementFactory(),
                resultsAbstractFactory.CreateγFactory(),
                HM3BModel.r,
                HM3BModel.t)
                .GetValueForOutputContext(
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory(),
                comparersAbstractFactory.CreateLocationComparerFactory(),
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                dependenciesAbstractFactory.CreateRedBlackTreeFactory());

            // ScenarioNumberPatients(Λ)
            this.ScenarioNumberPatients = calculationsAbstractFactory.CreateScenarioNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateScenarioNumberPatientsFactory(),
                calculationsAbstractFactory.CreateScenarioNumberPatientsResultElementCalculationFactory().Create(),
                HM3BModel.Λ,
                surgeonScenarioNumberPatients)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ExpectedValueΦ(s, l, Λ)
            IExpectedValueΦ expectedValueΦ = calculationsAbstractFactory.CreateExpectedValueΦCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateExpectedValueΦResultElementFactory(),
                resultsAbstractFactory.CreateExpectedValueΦFactory(),
                calculationsAbstractFactory.CreateExpectedValueΦResultElementCalculationFactory().Create(),
                HM3BModel.l,
                HM3BModel.t,
                HM3BModel.slΛ,
                HM3BModel.L,
                HM3BModel.p,
                HM3BModel.μ);

            // VarianceΦ(s, l, Λ)
            IVarianceΦ varianceΦ = calculationsAbstractFactory.CreateVarianceΦCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateVarianceΦResultElementFactory(),
                resultsAbstractFactory.CreateVarianceΦFactory(),
                calculationsAbstractFactory.CreateVarianceΦResultElementCalculationFactory().Create(),
                HM3BModel.l,
                HM3BModel.t,
                HM3BModel.slΛ,
                HM3BModel.L,
                HM3BModel.p,
                HM3BModel.μ,
                HM3BModel.σ);

            // ExpectedValueI(t, Λ)
            Interfaces.Results.DayScenarioRecoveryWardUtilizations.IExpectedValueI expectedValueI = calculationsAbstractFactory.CreateExpectedValueICalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateExpectedValueIResultElementFactory(),
                resultsAbstractFactory.CreateExpectedValueIFactory(),
                calculationsAbstractFactory.CreateExpectedValueIResultElementCalculationFactory().Create(),
                HM3BModel.l,
                HM3BModel.t,
                HM3BModel.st,
                HM3BModel.tΛ,
                expectedValueΦ,
                z);

            this.DayScenarioRecoveryWardUtilizationExpectedValues = expectedValueI
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // VarianceI(t, Λ)
            IVarianceI varianceI = calculationsAbstractFactory.CreateVarianceICalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateVarianceIResultElementFactory(),
                resultsAbstractFactory.CreateVarianceIFactory(),
                calculationsAbstractFactory.CreateVarianceIResultElementCalculationFactory().Create(),
                HM3BModel.l,
                HM3BModel.t,
                HM3BModel.st,
                HM3BModel.tΛ,
                varianceΦ,
                z);

            this.DayScenarioRecoveryWardUtilizationVariances = varianceI
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // EBS(t, Λ)
            IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                resultsAbstractFactory.CreateEBSFactory(),
                calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                HM3BModel.tΛ,
                HM3BModel.Ω,
                expectedValueI,
                varianceI);

            this.DayScenarioExpectedBedShortages = EBS
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TEBS(Λ)
            Interfaces.Results.ScenarioTotalExpectedBedShortages.ITEBS TEBS_Λ = calculationsAbstractFactory.CreateTEBSΛCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateTEBSΛResultElementFactory(),
                resultsAbstractFactory.CreateTEBSΛFactory(),
                calculationsAbstractFactory.CreateTEBSΛResultElementCalculationFactory().Create(),
                HM3BModel.t,
                HM3BModel.Λ,
                EBS);

            this.ScenarioTotalExpectedBedShortages = TEBS_Λ
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TEBS
            this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTEBSFactory(),
                HM3BModel.Λ,
                HM3BModel.Ρ,
                TEBS_Λ)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioTotalTimes(Λ)
            IScenarioTotalTimes scenarioTotalTimes = calculationsAbstractFactory.CreateScenarioTotalTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioTotalTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioTotalTimesFactory(),
                calculationsAbstractFactory.CreateScenarioTotalTimesResultElementCalculationFactory().Create(),
                HM3BModel.Λ,
                HM3BModel.srt,
                HM3BModel.H,
                x);
            
            this.ScenarioTotalTimes = scenarioTotalTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUtilizedTimes(Λ)
            IScenarioUtilizedTimes scenarioUtilizedTimes = calculationsAbstractFactory.CreateScenarioUtilizedTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUtilizedTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUtilizedTimesFactory(),
                calculationsAbstractFactory.CreateScenarioUtilizedTimesResultElementCalculationFactory().Create(),
                HM3BModel.Λ,
                HM3BModel.srt,
                HM3BModel.h,
                HM3BModel.n,
                x);

            this.ScenarioUtilizedTimes = scenarioUtilizedTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUnutilizedTimes(Λ)
            IScenarioUnutilizedTimes scenarioUnutilizedTimes = calculationsAbstractFactory.CreateScenarioUnutilizedTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUnutilizedTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUnutilizedTimesFactory(),
                calculationsAbstractFactory.CreateScenarioUnutilizedTimesResultElementCalculationFactory().Create(),
                HM3BModel.Λ,
                scenarioTotalTimes,
                scenarioUtilizedTimes);

            this.ScenarioUnutilizedTimes = scenarioUnutilizedTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUnderutilizations(Λ)
            this.ScenarioUnderutilizations = calculationsAbstractFactory.CreateScenarioUnderutilizationsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUnderutilizationsResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUnderutilizationsFactory(),
                calculationsAbstractFactory.CreateScenarioUnderutilizationsResultElementCalculationFactory().Create(),
                HM3BModel.Λ,
                scenarioTotalTimes,
                scenarioUnutilizedTimes)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ΦHat(s, l, Λ)
            this.SurgeonDayScenarioCumulativeNumberPatients = calculationsAbstractFactory.CreateΦHatCalculationFactory().Create()
                .Calculate(
                calculationsAbstractFactory.CreateExpectedValueIResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateExpectedValueΦResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateVarianceIResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateVarianceΦResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateVHatResultElementCalculationFactory(),
                calculationsAbstractFactory.Createυ2ResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateΦHatResultElementCalculationFactory(),
                calculationsAbstractFactory.CreateExpectedValueICalculationFactory(),
                calculationsAbstractFactory.CreateExpectedValueΦCalculationFactory(),
                calculationsAbstractFactory.CreateMRNBCalculationFactory(),
                calculationsAbstractFactory.CreateRNBCalculationFactory(),
                calculationsAbstractFactory.CreatetStarCalculationFactory(),
                calculationsAbstractFactory.CreateVarianceICalculationFactory(),
                calculationsAbstractFactory.CreateVarianceΦCalculationFactory(),
                calculationsAbstractFactory.CreateVHatCalculationFactory(),
                calculationsAbstractFactory.Createυ2CalculationFactory(),
                dependenciesAbstractFactory.CreateNormalFactory(),
                resultElementsAbstractFactory.CreateExpectedValueIResultElementFactory(),
                resultElementsAbstractFactory.CreateExpectedValueΦResultElementFactory(),
                resultElementsAbstractFactory.CreateVarianceIResultElementFactory(),
                resultElementsAbstractFactory.CreateVarianceΦResultElementFactory(),
                resultElementsAbstractFactory.CreateVHatResultElementFactory(),
                resultElementsAbstractFactory.Createυ2ResultElementFactory(),
                resultElementsAbstractFactory.CreateΦHatResultElementFactory(),
                resultsAbstractFactory.CreateExpectedValueIFactory(),
                resultsAbstractFactory.CreateExpectedValueΦFactory(),
                resultsAbstractFactory.CreateVarianceIFactory(),
                resultsAbstractFactory.CreateVarianceΦFactory(),
                resultsAbstractFactory.CreateVHatFactory(),
                resultsAbstractFactory.Createυ2Factory(),
                resultsAbstractFactory.CreateΦHatFactory(),
                HM3BModel.l,
                HM3BModel.t,
                HM3BModel.Λ,
                HM3BModel.slΛ,
                HM3BModel.st,
                HM3BModel.tΛ,
                HM3BModel.L,
                HM3BModel.p,
                HM3BModel.μ,
                HM3BModel.σ,
                HM3BModel.Ω,
                z)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioExpectedBedShortages { get; }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationExpectedValues { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<int>>> ScenarioNumberPatients { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalTimes { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnderutilizations { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUnutilizedTimes { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioUtilizedTimes { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedOperatingRooms { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonNumberAssignedWeekdays { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedOperatingRooms { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>>> SurgicalSpecialtyNumberAssignedWeekdays { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioTotalExpectedBedShortages { get; }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardUtilizationVariances { get; }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> SurgeonOperatingRoomDayAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAssignments { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<bool>>> SurgeonDayAssignments { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<int>>>> SurgeonOperatingRoomDayNumberAssignedTimeBlocks { get; }

        public RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>> OperatingRoomDayAssignedAvailabilities { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> SurgeonDayScenarioCumulativeNumberPatients { get; }
    }
}