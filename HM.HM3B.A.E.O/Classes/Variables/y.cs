namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    internal sealed class y : Iy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public y(
            VariableCollection<IsIndexElement, IrIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement> Value { get; }

        public bool GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement)
        {
            bool value = false;

            if (this.Value[sIndexElement, rIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomAssignments.Iy GetElementsAt(
            IyResultElementFactory yResultElementFactory,
            IyFactory yFactory,
            Isr sr)
        {
            return yFactory.Create(
                sr.Value
                .Select(
                    i => yResultElementFactory.Create(
                        i.sIndexElement,
                        i.rIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.rIndexElement)))
                .ToImmutableList());
        }
    }
}