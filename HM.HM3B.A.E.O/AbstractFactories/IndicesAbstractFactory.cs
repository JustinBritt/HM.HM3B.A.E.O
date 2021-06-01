namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.Indices;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.Indices;

    internal sealed class IndicesAbstractFactory : IIndicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndicesAbstractFactory()
        {
        }

        public IdFactory CreatedFactory()
        {
            IdFactory factory = null;

            try
            {
                factory = new dFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IjFactory CreatejFactory()
        {
            IjFactory factory = null;

            try
            {
                factory = new jFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IlFactory CreatelFactory()
        {
            IlFactory factory = null;

            try
            {
                factory = new lFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ImFactory CreatemFactory()
        {
            ImFactory factory = null;

            try
            {
                factory = new mFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrFactory CreaterFactory()
        {
            IrFactory factory = null;

            try
            {
                factory = new rFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsFactory CreatesFactory()
        {
            IsFactory factory = null;

            try
            {
                factory = new sFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItFactory CreatetFactory()
        {
            ItFactory factory = null;

            try
            {
                factory = new tFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IΛFactory CreateΛFactory()
        {
            IΛFactory factory = null;

            try
            {
                factory = new ΛFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}