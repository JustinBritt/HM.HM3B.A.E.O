namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Parameters.DayAvailabilities;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints4ConstraintElement : IConstraints4ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Iψ ψ,
            Iγ γ)
        {
            Expression LHS = γ.Value[rIndexElement, tIndexElement];

            int RHS = 1 - ψ.GetElementAtAsint(
                tIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}