﻿namespace HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonDayScenarioCumulativeNumberPatients
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayScenarioCumulativeNumberPatients;

    public interface IVarianceΦCalculation
    {
        IVarianceΦ Calculate(
            IVarianceΦResultElementFactory varianceΦResultElementFactory,
            IVarianceΦFactory varianceΦFactory,
            IVarianceΦResultElementCalculation varianceΦResultElementCalculation,
            Il l,
            Is s,
            It t,
            IΛ Λ,
            IslΛ slΛ,
            IL L,
            Ip p,
            Iμ μ,
            Iσ σ);
    }
}