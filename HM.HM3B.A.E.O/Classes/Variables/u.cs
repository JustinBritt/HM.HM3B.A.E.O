namespace HM.HM3B.A.E.O.Classes.Variables
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class u : Iu
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public u(
            VariableCollection<IsIndexElement, IdIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IsIndexElement, IdIndexElement> Value { get; }
    }
}