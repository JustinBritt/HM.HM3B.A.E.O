namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    public interface Iz
    {
        VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement);

        ImmutableList<Tuple<Organization, FhirDateTime, bool>> GetElementsAt(
            Ist st);

        Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Is s,
            It t);
    }
}