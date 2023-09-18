namespace HM.HM3B.A.E.O.Classes.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Generic;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    
    internal sealed class SurgeonScenarioNumberPatients : ISurgeonScenarioNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatients(
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, ISurgeonScenarioNumberPatientsResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, ISurgeonScenarioNumberPatientsResultElement>> Value { get; }

        public List<ISurgeonScenarioNumberPatientsResultElement> GetElementsAt(
            IΛIndexElement ΛIndexElement)
        {
            return this.Value.Values.SelectMany(w => w.Values).Where(w => w.ΛIndexElement == ΛIndexElement).ToList();
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Is s,
            IΛ Λ)
        {
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> outerRedBlackTree = new(
                new HM.HM3B.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<INullableValue<int>, INullableValue<int>> innerRedBlackTree = new(
                    new HM.HM3B.A.E.O.Classes.Comparers.NullableValueintComparer());

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.Value[sIndexElement][ΛIndexElement].Value));
                }

                outerRedBlackTree.Add(
                    sIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}