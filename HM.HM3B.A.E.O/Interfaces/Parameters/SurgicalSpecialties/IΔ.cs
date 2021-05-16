namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface IΔ
    {
        ImmutableList<IΔParameterElement> Value { get; }

        bool IsSurgeonMemberOfSurgicalSpecialty(
            IjIndexElement jIndexElement,
            IsIndexElement sIndexElement);
    }
}