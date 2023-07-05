namespace HM.HM3B.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees
{
    using System;
    using System.Collections.Generic;

    using log4net;

    using global::NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;

    internal sealed class RedBlackTreeFactory : IRedBlackTreeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RedBlackTreeFactory()
        {
        }

        public RedBlackTree<TKey, TValue> Create<TKey, TValue>()
        {
            RedBlackTree<TKey, TValue> instance = null;

            try
            {
                instance = new RedBlackTree<TKey, TValue>();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public RedBlackTree<TKey, TValue> Create<TKey, TValue>(
            IComparer<TKey> comparer)
        {
            RedBlackTree<TKey, TValue> instance = null;

            try
            {
                instance = new RedBlackTree<TKey, TValue>(
                    comparer);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}