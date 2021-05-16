namespace HM.HM3B.A.E.O.InterfacesFactories.ObjectiveFunctions
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface IObjectiveFunctionFactory
    {
        IObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Isd sd,
            Iu u);
    }
}