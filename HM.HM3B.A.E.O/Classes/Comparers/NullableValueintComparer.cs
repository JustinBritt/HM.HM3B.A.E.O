namespace HM.HM3B.A.E.O.Classes.Comparers
{
    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Comparers;

    internal sealed class NullableValueintComparer : INullableValueintComparer
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NullableValueintComparer()
        {
        }

        public int Compare(
            INullableValue<int> x,
            INullableValue<int> y)
        {
            return x.Value.Value.CompareTo(
                y.Value.Value);
        }
    }
}