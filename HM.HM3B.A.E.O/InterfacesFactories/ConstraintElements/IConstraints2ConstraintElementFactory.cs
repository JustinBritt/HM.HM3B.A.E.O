namespace HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements
{
    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IConstraints2ConstraintElementFactory
    {
        IConstraints2ConstraintElement Create(
            IsIndexElement sIndexElement,
            Ir r,
            IB B,
            Ib b);
    }
}