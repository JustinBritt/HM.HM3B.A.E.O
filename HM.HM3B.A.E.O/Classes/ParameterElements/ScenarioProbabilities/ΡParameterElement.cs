namespace HM.HM3B.A.E.O.Classes.ParameterElements.ScenarioProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    internal sealed class ΡParameterElement : IΡParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡParameterElement(
            IΛIndexElement ΛIndexElement,
            INullableValue<decimal> value)
        {
            this.ΛIndexElement = ΛIndexElement;

            this.Value = value;
        }

        public IΛIndexElement ΛIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}