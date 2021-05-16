namespace HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks
{
    using System.Collections.Immutable;
 
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonNumberAssignedTimeBlocks;

    public interface IB
    {
        ImmutableList<IBParameterElement> Value { get; }

        int GetElementAtAsint(
            IsIndexElement sIndexElement);
    }
}