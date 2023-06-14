namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints2ConstraintElement : IConstraints2ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElement(
            IsIndexElement sIndexElement,
            Ir r,
            IB B,
            Ib b)
        {
            Expression LHS = Expression.Sum(
                r.Value.Values
                .Select(
                    x => b.Value[sIndexElement, x]));

            int RHS = B.GetElementAtAsint(
                sIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}