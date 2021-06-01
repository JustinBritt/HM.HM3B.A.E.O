namespace HM.HM3B.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using HM.HM3B.A.E.O.Factories.CrossJoins;
    using HM.HM3B.A.E.O.InterfacesAbstractFactories;
    using HM.HM3B.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public IdtFactory CreatedtFactory()
        {
            IdtFactory factory = null;

            try
            {
                factory = new dtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ImrFactory CreatemrFactory()
        {
            ImrFactory factory = null;

            try
            {
                factory = new mrFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrtFactory CreatertFactory()
        {
            IrtFactory factory = null;

            try
            {
                factory = new rtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsdFactory CreatesdFactory()
        {
            IsdFactory factory = null;

            try
            {
                factory = new sdFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsdtFactory CreatesdtFactory()
        {
            IsdtFactory factory = null;

            try
            {
                factory = new sdtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslFactory CreateslFactory()
        {
            IslFactory factory = null;

            try
            {
                factory = new slFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IslΛFactory CreateslΛFactory()
        {
            IslΛFactory factory = null;

            try
            {
                factory = new slΛFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrFactory CreatesrFactory()
        {
            IsrFactory factory = null;

            try
            {
                factory = new srFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrdFactory CreatesrdFactory()
        {
            IsrdFactory factory = null;

            try
            {
                factory = new srdFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrjFactory CreatesrjFactory()
        {
            IsrjFactory factory = null;

            try
            {
                factory = new srjFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsrtFactory CreatesrtFactory()
        {
            IsrtFactory factory = null;

            try
            {
                factory = new srtFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IstFactory CreatestFactory()
        {
            IstFactory factory = null;

            try
            {
                factory = new stFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsΛFactory CreatesΛFactory()
        {
            IsΛFactory factory = null;

            try
            {
                factory = new sΛFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ItΛFactory CreatetΛFactory()
        {
            ItΛFactory factory = null;

            try
            {
                factory = new tΛFactory();
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