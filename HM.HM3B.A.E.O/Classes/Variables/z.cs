namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    internal sealed class z : Iz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public z(
            VariableCollection<IsIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement)
        {
            return this.GetElementAt(
                sIndexElement,
                tIndexElement)
                ? 1 : 0;
        }

        public ImmutableList<Tuple<Organization, FhirDateTime, bool>> GetElementsAt(
            Ist st)
        {
            return st.Value
                .Select(
                i => Tuple.Create(
                    i.sIndexElement.Value,
                    i.tIndexElement.Value,
                    this.GetElementAt(
                        i.sIndexElement,
                        i.tIndexElement)))
                .ToImmutableList();
        }

        public Interfaces.Results.SurgeonDayAssignments.Iz GetElementsAt(
            IzResultElementFactory zResultElementFactory,
            IzFactory zFactory,
            Ist st)
        {
            return zFactory.Create(
                st.Value
                .Select(
                    i => zResultElementFactory.Create(
                        i.sIndexElement,
                        i.tIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.tIndexElement)))
                .ToImmutableList());
        }
    }
}