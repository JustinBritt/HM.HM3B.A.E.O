namespace HM.HM3B.A.E.O.Factories.Parameters.ScenarioProbabilities
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Classes.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using HM.HM3B.A.E.O.Interfaces.Parameters.ScenarioProbabilities;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities;

    internal sealed class ΡFactory : IΡFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡFactory()
        {
        }

        public IΡ Create(
            RedBlackTree<IΛIndexElement, IΡParameterElement> value)
        {
            IΡ parameter = null;

            try
            {
                parameter = new Ρ(
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