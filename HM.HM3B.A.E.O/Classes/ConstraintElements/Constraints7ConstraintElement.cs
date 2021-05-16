namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.NumberDaysPerWeek;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints7ConstraintElement : IConstraints7ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints7ConstraintElement(
            IdIndexElement dIndexElement,
            IrIndexElement rIndexElement,
            IsIndexElement sIndexElement,
            It t,
            IW W,
            Ix x,
            Iβ β)
        {
            OPTANO.Modeling.Optimization.Expression LHS = OPTANO.Modeling.Optimization.Expression.Sum(
                t.GetNthElementsAt(
                    dIndexElement.Value.Value.Value,
                    t.GetT() - W.Value.Value.Value + dIndexElement.Value.Value.Value,
                    W.Value.Value.Value)
                .Select(
                   y => x.Value[sIndexElement, rIndexElement, y]));

            OPTANO.Modeling.Optimization.Expression RHS = β.Value[sIndexElement, rIndexElement, dIndexElement];
 
            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}