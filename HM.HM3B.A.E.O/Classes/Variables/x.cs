namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, rIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Isrt srt)
        {
            return xFactory.Create(
                srt.Value
                .Select(
                    i => xResultElementFactory.Create(
                        i.sIndexElement,
                        i.rIndexElement,
                        i.tIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.rIndexElement,
                            i.tIndexElement)))
                .ToImmutableList());
        }
    }
}