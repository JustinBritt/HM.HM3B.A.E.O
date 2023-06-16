namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonLengthOfStayMaximums
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonLengthOfStayMaximums;

    internal sealed class LFactory : ILFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LFactory()
        {
        }

        public IL Create(
            RedBlackTree<IsIndexElement, ILParameterElement> value)
        {
            IL parameter = null;

            try
            {
                parameter = new L(
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