namespace HM.HM3B.A.E.O.Factories.Results.SurgeonOperatingRoomAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomAssignments;

    internal sealed class yFactory : IyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public yFactory()
        {
        }

        public Iy Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, IyResultElement>> value)
        {
            Iy result = null;

            try
            {
                result = new y(
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