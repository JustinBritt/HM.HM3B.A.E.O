namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints8UConstraintElementFactory
    {
        IConstraints8UConstraintElement Create(
            IdIndexElement dIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iu u,
            Iz z);
    }
}