namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints6ConstraintElement : IConstraints6ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElement(
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            Id d,
            Ib b,
            Iβ β)
        {
            Expression LHS = Expression.Sum(
                d.Value
                .Select(
                    x => β.Value[sIndexElement, rIndexElement, x]));

            Expression RHS = b.Value[sIndexElement, rIndexElement];

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}