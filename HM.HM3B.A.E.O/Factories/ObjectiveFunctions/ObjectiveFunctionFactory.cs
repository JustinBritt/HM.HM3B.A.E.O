namespace HM.HM3B.A.E.O.Factories.ObjectiveFunctions
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.ObjectiveFunctions;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.ObjectiveFunctions;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using HM.HM3B.A.E.O.InterfacesFactories.ObjectiveFunctions;

    internal sealed class ObjectiveFunctionFactory : IObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveFunctionFactory()
        {
        }

        public IObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Isd sd,
            Iu u)
        {
            IObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction(
                    objectiveFactory,
                    sd,
                    u);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return objectiveFunction;
        }
    }
}