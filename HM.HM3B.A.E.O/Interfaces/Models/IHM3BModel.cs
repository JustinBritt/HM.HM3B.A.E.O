namespace HM.HM3B.A.E.O.Interfaces.Models
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonDayScenarioLengthOfStayProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioWeightedAverageSurgicalDurations;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using HM.HM3B.A.E.O.Interfaces.Parameters.TimeBlockLength;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    
    public interface IHM3BModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Il l { get; }

        Ir r { get; }

        Is s { get; }

        It t { get; }

        IΛ Λ { get; }

        Irt rt { get; }

        IslΛ slΛ { get; }

        Isrd srd { get; }

        Isrt srt { get; }

        Ist st { get; }

        IsΛ sΛ { get; }

        ItΛ tΛ { get; }

        IH H { get; }

        Ih h { get; }

        IL L { get; }

        In n { get; }

        Ip p { get; }

        IΔ Δ { get; }

        Iμ μ { get; }

        IΡ Ρ { get; }

        Iσ σ { get; }

        IΩ Ω { get; }

        Ix x { get; }

        Iz z { get; }

        Iβ β { get; }

        Iγ γ { get; }
    }
}