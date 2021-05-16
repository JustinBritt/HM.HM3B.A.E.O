namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    internal sealed class Constraints8UConstraintElement : IConstraints8UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8UConstraintElement(
            IdIndexElement dIndexElement,
            IsIndexElement sIndexElement,
            ItIndexElement tIndexElement,
            Iu u,
            Iz z)
        {
            Expression LHS = z.Value[sIndexElement, tIndexElement];

            Expression RHS = u.Value[sIndexElement, dIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}