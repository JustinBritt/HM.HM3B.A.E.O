namespace HM.HM3B.A.E.O.Classes.Parameters.NumberDaysPerWeek
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;

    internal sealed class W : IW
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public W(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        public INullableValue<int> Value { get; }
    }
}