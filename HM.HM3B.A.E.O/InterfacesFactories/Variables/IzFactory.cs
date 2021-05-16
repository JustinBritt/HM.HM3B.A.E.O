namespace HM.HM3B.A.E.O.InterfacesFactories.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IzFactory
    {
        Iz Create(
            VariableCollection<IsIndexElement, ItIndexElement> value);
    }
}