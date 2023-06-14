namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints9ConstraintElement : IConstraints9ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElement(
            IrIndexElement rIndexElement,
            ItIndexElement tIndexElement,
            Is s,
            Ix x,
            Iγ γ)
        {
            Expression LHS = Expression.Sum(
                s.Value.Values
                .Select(
                    y => x.Value[y, rIndexElement, tIndexElement]));

            Expression RHS = γ.Value[rIndexElement, tIndexElement];

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}