namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IrIndexElement rIndexElement,
            Is s,
            It t,
            Ib b,
            Iγ γ)
        {
            Expression LHS = Expression.Sum(
                s.Value.Values
                .Select(
                    x => b.Value[x, rIndexElement]));

            Expression RHS = Expression.Sum(
                t.Value
                .Select(
                    x => γ.Value[rIndexElement, x]));

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}