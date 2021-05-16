namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.OperatingRoomDayAssignedAvailabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.OperatingRoomDayAssignedAvailabilities;

    internal sealed class γ : Iγ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γ(
            VariableCollection<IrIndexElement, ItIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IrIndexElement, ItIndexElement> Value { get; }

        public bool GetElementAt(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement)
        {
            bool value = false;

            if (this.Value[rIndexElement, tIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.OperatingRoomDayAssignedAvailabilities.Iγ GetElementsAt(
            IγResultElementFactory γResultElementFactory,
            IγFactory γFactory,
            Irt rt)
        {
            return γFactory.Create(
                rt.Value
                .Select(
                    i => γResultElementFactory.Create(
                        i.rIndexElement,
                        i.tIndexElement,
                        this.GetElementAt(
                            i.rIndexElement,
                            i.tIndexElement)))
                .ToImmutableList());
        }
    }
}