namespace HM.HM3B.A.E.O.Factories.Comparers
{
    using HM.HM3B.A.E.O.Classes.Comparers;
    using HM.HM3B.A.E.O.Interfaces.Comparers;
    using HM.HM3B.A.E.O.InterfacesFactories.Comparers;

    internal sealed class NullableValueintComparerFactory : INullableValueintComparerFactory
    {
        public NullableValueintComparerFactory()
        {
        }

        public INullableValueintComparer Create()
        {
            INullableValueintComparer instance = null;

            try
            {
                instance = new NullableValueintComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}