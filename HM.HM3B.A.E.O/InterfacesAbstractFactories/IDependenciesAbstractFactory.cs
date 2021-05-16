namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization.Configuration;

    public interface IDependenciesAbstractFactory
    {
        IConfigurationFactory CreateConfigurationFactory();

        IModelFactory CreateModelFactory();

        IModelScopeFactory CreateModelScopeFactory();

        INormalFactory CreateNormalFactory();

        INullableValueFactory CreateNullableValueFactory();

        IObjectiveFactory CreateObjectiveFactory();

        ISolverFactory CreateSolverFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();

        IVariableFactory CreateVariableFactory();

        IVariableCollectionFactory CreateVariableCollectionFactory();
    }
}