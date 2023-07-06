namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgeonLengthOfStayMaximums;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;

    internal sealed class SurgeonLengthOfStayMaximumsVisitorFactory : ISurgeonLengthOfStayMaximumsVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonLengthOfStayMaximumsVisitorFactory()
        {
        }

        public ISurgeonLengthOfStayMaximumsVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            ILParameterElementFactory LParameterElementFactory,
            Is s)
            where TKey : Organization
            where TValue : INullableValue<int>
        {
            ISurgeonLengthOfStayMaximumsVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonLengthOfStayMaximumsVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    LParameterElementFactory,
                    s);
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