namespace HM.HM3B.A.E.O.Classes.Variables
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    internal sealed class β : Interfaces.Variables.Iβ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public β(
            VariableCollection<IsIndexElement, IrIndexElement, IdIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IrIndexElement, IdIndexElement> Value { get; }

        public int GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement)
        {
            int value = 0;

            int rounded = (int)Math.Round(
                this.Value[sIndexElement, rIndexElement, dIndexElement].Value,
                0,
                MidpointRounding.AwayFromZero);

            if (this.Value[sIndexElement, rIndexElement, dIndexElement].Value.IsAlmost(rounded))
            {
                value = rounded;
            }

            return value;
        }

        public Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks.Iβ GetElementsAt(
            IβResultElementFactory βResultElementFactory,
            IβFactory βFactory,
            Isrd srd)
        {
            return βFactory.Create(
                srd.Value
                .Select(
                    i => βResultElementFactory.Create(
                        i.sIndexElement,
                        i.rIndexElement,
                        i.dIndexElement,
                        this.GetElementAt(
                            i.sIndexElement,
                            i.rIndexElement,
                            i.dIndexElement)))
                .ToImmutableList());
        }
    }
}           