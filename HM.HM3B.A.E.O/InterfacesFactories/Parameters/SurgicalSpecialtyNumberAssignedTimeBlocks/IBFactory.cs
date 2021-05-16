namespace HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;

    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgicalSpecialtyNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgicalSpecialtyNumberAssignedTimeBlocks;

    public interface IBFactory
    {
        IB Create(
            ImmutableList<IBParameterElement> value);
    }
}