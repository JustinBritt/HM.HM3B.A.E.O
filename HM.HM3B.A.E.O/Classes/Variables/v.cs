namespace HM.HM3B.A.E.O.Classes.Variables
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            VariableCollection<ImIndexElement, IrIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<ImIndexElement, IrIndexElement> Value { get; }
    }
}