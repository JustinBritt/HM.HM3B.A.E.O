namespace HM.HM3B.A.E.O.Factories.Dependencies.MathNet.Numerics.Distributions
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.MathNet.Numerics.Distributions;

    internal sealed class NormalFactory : INormalFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NormalFactory()
        {
        }

        public global::MathNet.Numerics.Distributions.IDistribution Create()
        {
            global::MathNet.Numerics.Distributions.IDistribution distribution = null;

            try
            {
                distribution = new global::MathNet.Numerics.Distributions.Normal();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return distribution;
        }
    }
}