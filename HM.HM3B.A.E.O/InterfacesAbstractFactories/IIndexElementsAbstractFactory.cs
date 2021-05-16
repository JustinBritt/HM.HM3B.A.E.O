namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        IdIndexElementFactory CreatedIndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IlIndexElementFactory CreatelIndexElementFactory();

        ImIndexElementFactory CreatemIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        ItIndexElementFactory CreatetIndexElementFactory();

        IΛIndexElementFactory CreateΛIndexElementFactory();
    }
}