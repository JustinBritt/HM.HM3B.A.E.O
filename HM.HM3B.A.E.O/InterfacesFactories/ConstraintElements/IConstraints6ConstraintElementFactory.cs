namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints6ConstraintElementFactory
    {
        IConstraints6ConstraintElement Create(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Id d,
            Ib b,
            Iβ β);
    }
}