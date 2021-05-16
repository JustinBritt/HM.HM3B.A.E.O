namespace HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IVarianceΦResultElementCalculation
    {
        IVarianceΦResultElement Calculate(
            IVarianceΦResultElementFactory varianceΦResultElementFactory,
            IlIndexElement lIndexElement,
            IsIndexElement sIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            IL L,
            Ip p,
            Iμ μ,
            Iσ σ);
    }
}