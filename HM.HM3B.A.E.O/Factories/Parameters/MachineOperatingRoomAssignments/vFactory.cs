namespace HM.HM3B.A.E.O.Factories.Parameters.MachineOperatingRoomAssignments
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Parameters.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.Interfaces.Parameters.MachineOperatingRoomAssignments;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.MachineOperatingRoomAssignments;

    internal sealed class vFactory : IvFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vFactory()
        {
        }

        public Iv Create(
            RedBlackTree<ImIndexElement, RedBlackTree<IrIndexElement, IvParameterElement>> value)
        {
            Iv parameter = null;

            try
            {
                parameter = new v(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}