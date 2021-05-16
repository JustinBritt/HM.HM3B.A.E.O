namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface Ib
    {
        VariableCollection<IsIndexElement, IrIndexElement> Value { get; }
    }
}