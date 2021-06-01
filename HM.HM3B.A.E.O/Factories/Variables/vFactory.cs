namespace HM.HM3B.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Classes.Variables;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;
    using HM.HM3B.A.E.O.InterfacesFactories.Variables;

    internal sealed class vFactory : IvFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vFactory()
        {
        }

        public Iv Create(
            VariableCollection<ImIndexElement, IrIndexElement> value)
        {
            Iv variable = null;

            try
            {
                variable = new v(
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