namespace HM.HM3B.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Contexts;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using HM.HM3B.A.E.O.InterfacesVisitors.Contexts;
    using HM.HM3B.A.E.O.Visitors.Contexts;
    
    internal sealed class SurgicalSpecialtiesVisitorFactory : ISurgicalSpecialtiesVisitorFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtiesVisitorFactory()
        {
        }

        public ISurgicalSpecialtiesVisitor<TKey, TValue> Create<TKey, TValue>(
            IRedBlackTreeFactory redBlackTreeFactory,
            IΔParameterElementFactory ΔParameterElementFactory,
            Ij j,
            Is s)
            where TKey : Organization
            where TValue : IImmutableSet<Organization>
        {
            ISurgicalSpecialtiesVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgicalSpecialtiesVisitor<TKey, TValue>(
                    redBlackTreeFactory,
                    ΔParameterElementFactory,
                    j,
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