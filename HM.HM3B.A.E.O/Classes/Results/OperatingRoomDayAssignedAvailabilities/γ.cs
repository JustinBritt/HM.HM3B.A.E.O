namespace HM.HM3B.A.E.O.Classes.Results.OperatingRoomDayAssignedAvailabilities
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Results.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IγResultElement>> Value { get; }

        public ImmutableList<Tuple<Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            List<Tuple<Location, FhirDateTime, INullableValue<bool>>> list = new List<Tuple<Location, FhirDateTime, INullableValue<bool>>>();

            foreach (var item in this.Value.Values.Distinct())
            {
                foreach (var item2 in item.Values.Distinct())
                {
                    list.Add(
                        Tuple.Create(
                            item2.rIndexElement.Value,
                            item2.tIndexElement.Value,
                            nullableValueFactory.Create<bool>(
                                item2.Value)));
                }
            }

            return list.ToImmutableList();
        }
    }
}