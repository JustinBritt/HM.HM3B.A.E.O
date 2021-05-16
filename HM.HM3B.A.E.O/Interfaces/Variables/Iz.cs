namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
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
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Ist st);
    }
}