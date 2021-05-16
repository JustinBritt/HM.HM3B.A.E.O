namespace HM.HM3B.A.E.O.InterfacesFactories.Results.ObjectiveValue
{
    using HM.HM3B.A.E.O.Interfaces.Results.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}