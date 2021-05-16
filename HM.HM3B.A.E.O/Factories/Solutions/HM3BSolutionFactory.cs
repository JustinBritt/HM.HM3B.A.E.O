namespace HM.HM3B.A.E.O.Factories.Solutions
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Solutions;
    using HM.HM3B.A.E.O.Interfaces.Solutions;
    using HM.HM3B.A.E.O.InterfacesFactories.Solutions;

    internal sealed class HM3BSolutionFactory : IHM3BSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BSolutionFactory()
        {
        }

        public IHM3BSolution Create()
        {
            IHM3BSolution solution = null;

            try
            {
                solution = new HM3BSolution();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return solution;
        }
    }
}