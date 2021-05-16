﻿namespace HM.HM3B.A.E.O.Interfaces.Calculations.DayScenarioRecoveryWardUtilizations
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardUtilizations;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayScenarioCumulativeNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardUtilizations;

    public interface IExpectedValueIResultElementCalculation
    {
        IExpectedValueIResultElement Calculate(
            IExpectedValueIResultElementFactory expectedValueIResultElementFactory,
            ItIndexElement tIndexElement,
            IΛIndexElement ΛIndexElement,
            Il l,
            It t,
            Ist st,
            IExpectedValueΦ expectedValueΦ,
            Iz z);
    }
}