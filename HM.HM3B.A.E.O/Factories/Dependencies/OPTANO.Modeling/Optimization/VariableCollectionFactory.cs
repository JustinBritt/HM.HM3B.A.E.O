namespace HM.HM3B.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;
    using System.Collections.Generic;

    using log4net;

    using global::OPTANO.Modeling.Optimization;
    using global::OPTANO.Modeling.Optimization.Enums;

    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class VariableCollectionFactory : IVariableCollectionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariableCollectionFactory()
        {
        }

        public VariableCollection<T1> Create<T1>(
            IEnumerable<T1> indexSet1,
            Func<T1, double> lowerBoundGenerator,
            Model model,
            Func<T1, double> upperBoundGenerator,
            Func<T1, VariableType> variableTypeGenerator)
        {
            VariableCollection<T1> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1>(
                    model: model,
                    indexSet1: indexSet1,
                    lowerBoundGenerator: lowerBoundGenerator,
                    upperBoundGenerator: upperBoundGenerator,
                    variableTypeGenerator: variableTypeGenerator);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2> Create<T1, T2>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            Func<T1, T2, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, double> upperBoundGenerator,
            Func<T1, T2, VariableType> variableTypeGenerator)
        {
            VariableCollection<T1, T2> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    lowerBoundGenerator: lowerBoundGenerator,
                    upperBoundGenerator: upperBoundGenerator,
                    variableTypeGenerator: variableTypeGenerator);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2, T3> Create<T1, T2, T3>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            Func<T1, T2, T3, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, double> upperBoundGenerator,
            Func<T1, T2, T3, VariableType> variableTypeGenerator)
        {
            VariableCollection<T1, T2, T3> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2, T3>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    indexSet3: indexSet3,
                    lowerBoundGenerator: lowerBoundGenerator,
                    upperBoundGenerator: upperBoundGenerator,
                    variableTypeGenerator: variableTypeGenerator);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2, T3, T4> Create<T1, T2, T3, T4>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            IEnumerable<T4> indexSet4,
            Func<T1, T2, T3, T4, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, T4, double> upperBoundGenerator,
            Func<T1, T2, T3, T4, VariableType> variableTypeGenerator)
        {
            VariableCollection<T1, T2, T3, T4> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2, T3, T4>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    indexSet3: indexSet3,
                    indexSet4: indexSet4,
                    lowerBoundGenerator: lowerBoundGenerator,
                    upperBoundGenerator: upperBoundGenerator,
                    variableTypeGenerator: variableTypeGenerator);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            IEnumerable<T4> indexSet4,
            IEnumerable<T5> indexSet5,
            Func<T1, T2, T3, T4, T5, double> lowerBoundGenerator,
            Model model,
            Func<T1, T2, T3, T4, T5, double> upperBoundGenerator,
            Func<T1, T2, T3, T4, T5, VariableType> variableTypeGenerator)
        {
            VariableCollection<T1, T2, T3, T4, T5> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2, T3, T4, T5>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    indexSet3: indexSet3,
                    indexSet4: indexSet4,
                    indexSet5: indexSet5,
                    lowerBoundGenerator: lowerBoundGenerator,
                    upperBoundGenerator: upperBoundGenerator,
                    variableTypeGenerator: variableTypeGenerator);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2> CreateBinary<T1, T2>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            Model model)
        {
            VariableCollection<T1, T2> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => 1,
                    variableTypeGenerator: (a, b) => VariableType.Binary);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }

        public VariableCollection<T1, T2, T3> CreateBinary<T1, T2, T3>(
            IEnumerable<T1> indexSet1,
            IEnumerable<T2> indexSet2,
            IEnumerable<T3> indexSet3,
            Model model)
        {
            VariableCollection<T1, T2, T3> variableCollection = null;

            try
            {
                variableCollection = new VariableCollection<T1, T2, T3>(
                    model: model,
                    indexSet1: indexSet1,
                    indexSet2: indexSet2,
                    indexSet3: indexSet3,
                    lowerBoundGenerator: (a, b, c) => 0,
                    upperBoundGenerator: (a, b, c) => 1,
                    variableTypeGenerator: (a, b, c) => VariableType.Binary);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableCollection;
        }
    }
}