namespace HM.HM3B.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Classes.Variables;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Variables;

    internal sealed class zFactory : IzFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public zFactory()
        {
        }

        public Iz Create(
            VariableCollection<IsIndexElement, ItIndexElement> value)
        {
            Iz variable = null;

            try
            {
                variable = new z(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}