namespace HM.HM3B.A.E.O.Factories.Results.SurgeonDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonDayAssignments;

    internal sealed class zFactory : IzFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public zFactory()
        {
        }

        public Iz Create(
            ImmutableList<IzResultElement> value)
        {
            Iz result = null;

            try
            {
                result = new z(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}