namespace HM.HM3B.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ModelFactory : IModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelFactory()
        {
        }

        public Model Create()
        {
            Model model = null;

            try
            {
                model = new Model();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return model;
        }
    }
}