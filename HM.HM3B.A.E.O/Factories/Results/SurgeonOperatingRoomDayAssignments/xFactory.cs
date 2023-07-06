namespace HM.HM3B.A.E.O.Factories.Results.SurgeonOperatingRoomDayAssignments
{
    using System;

    using NGenerics.DataStructures.Trees;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
   
    internal sealed class xFactory : IxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xFactory()
        {
        }

        public Ix Create(
            RedBlackTree<IsIndexElement, RedBlackTree<IrIndexElement, RedBlackTree<ItIndexElement, IxResultElement>>> value)
        {
            Ix result = null;

            try
            {
                result = new x(
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