namespace HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    public interface ISurgeonScenarioNumberPatients
    {
        List<ISurgeonScenarioNumberPatientsResultElement> GetElementsAt(
            IΛIndexElement ΛIndexElement);

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Is s,
            IΛ Λ);
    }
}