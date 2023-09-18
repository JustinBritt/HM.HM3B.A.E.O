namespace HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients
{
    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    
    public interface ISurgeonScenarioNumberPatientsFactory
    {
        ISurgeonScenarioNumberPatients Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, ISurgeonScenarioNumberPatientsResultElement>> value);
    }
}