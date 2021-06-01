namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.CrossJoinElements;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IdtCrossJoinElementFactory CreatedtCrossJoinElementFactory()
        {
            IdtCrossJoinElementFactory factory = null;

            try
            {
                factory = new dtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ImrCrossJoinElementFactory CreatemrCrossJoinElementFactory()
        {
            ImrCrossJoinElementFactory factory = null;

            try
            {
                factory = new mrCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrtCrossJoinElementFactory CreatertCrossJoinElementFactory()
        {
            IrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new rtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsdCrossJoinElementFactory CreatesdCrossJoinElementFactory()
        {
            IsdCrossJoinElementFactory factory = null;

            try
            {
                factory = new sdCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsdtCrossJoinElementFactory CreatesdtCrossJoinElementFactory()
        {
            IsdtCrossJoinElementFactory factory = null;

            try
            {
                factory = new sdtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslCrossJoinElementFactory CreateslCrossJoinElementFactory()
        {
            IslCrossJoinElementFactory factory = null;

            try
            {
                factory = new slCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslΛCrossJoinElementFactory CreateslΛCrossJoinElementFactory()
        {
            IslΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new slΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrCrossJoinElementFactory CreatesrCrossJoinElementFactory()
        {
            IsrCrossJoinElementFactory factory = null;

            try
            {
                factory = new srCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrdCrossJoinElementFactory CreatesrdCrossJoinElementFactory()
        {
            IsrdCrossJoinElementFactory factory = null;

            try
            {
                factory = new srdCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrjCrossJoinElementFactory CreatesrjCrossJoinElementFactory()
        {
            IsrjCrossJoinElementFactory factory = null;

            try
            {
                factory = new srjCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrtCrossJoinElementFactory CreatesrtCrossJoinElementFactory()
        {
            IsrtCrossJoinElementFactory factory = null;

            try
            {
                factory = new srtCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IstCrossJoinElementFactory CreatestCrossJoinElementFactory()
        {
            IstCrossJoinElementFactory factory = null;

            try
            {
                factory = new stCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsΛCrossJoinElementFactory CreatesΛCrossJoinElementFactory()
        {
            IsΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new sΛCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItΛCrossJoinElementFactory CreatetΛCrossJoinElementFactory()
        {
            ItΛCrossJoinElementFactory factory = null;

            try
            {
                factory = new tΛCrossJoinElementFactory();
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