namespace HM.HM3B.A.E.O.Factories.Results.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Results.TotalExpectedBedShortage;
    using HM.HM3B.A.E.O.Interfaces.Results.TotalExpectedBedShortage;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.TotalExpectedBedShortage;

    internal sealed class TEBSFactory : ITEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSFactory()
        {
        }

        public ITEBS Create(
            decimal value)
        {
            ITEBS result = null;

            try
            {
                result = new TEBS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}