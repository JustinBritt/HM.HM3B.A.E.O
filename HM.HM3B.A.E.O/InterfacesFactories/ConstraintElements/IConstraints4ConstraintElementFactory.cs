namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Iψ ψ,
            Iγ γ);
    }
}