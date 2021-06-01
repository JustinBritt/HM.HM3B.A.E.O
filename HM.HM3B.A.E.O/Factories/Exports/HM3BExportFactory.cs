namespace HM.HM3B.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Exports;
    using HM.HM3B.A.E.O.Interfaces.Exports;
    using HM.HM3B.A.E.O.InterfacesFactories.Exports;

    internal sealed class HM3BExportFactory : IHM3BExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM3BExportFactory()
        {
        }

        public IHM3BExport Create()
        {
            IHM3BExport export = null;

            try
            {
                export = new HM3BExport();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}