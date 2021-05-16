namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Iu
    {
        VariableCollection<IsIndexElement, IdIndexElement> Value { get; }
    }
}