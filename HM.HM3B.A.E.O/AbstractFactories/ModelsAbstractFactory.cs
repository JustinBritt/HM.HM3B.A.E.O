namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.Models;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.Models;

    internal sealed class ModelsAbstractFactory : IModelsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelsAbstractFactory()
        {
        }

        public IHM3BModelFactory CreateHM3BModelFactory()
        {
            IHM3BModelFactory factory = null;

            try
            {
                factory = new HM3BModelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}