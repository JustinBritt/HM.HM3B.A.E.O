namespace HM.HM3B.A.E.O.Classes.Parameters.MaximumNumberRecoveryWardBeds
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Parameters.MaximumNumberRecoveryWardBeds;

    internal sealed class Ω : IΩ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ω(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        public INullableValue<int> Value { get; }
    }
}