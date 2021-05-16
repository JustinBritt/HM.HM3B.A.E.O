namespace HM.HM3B.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.ConstraintElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonMachineRequirements;

    internal sealed class Constraints1ConstraintElement : IConstraints1ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Constructor: v and y are both variables (1x1)
        public Constraints1ConstraintElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Iζ ζ,
            Interfaces.Variables.Iv v,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = Expression.Sum(
                s.Value
                .Select(
                    x => y.Value[x, rIndexElement]
                    *
                    ζ.GetElementAtAsint(
                        x,
                        mIndexElement)));

            Expression RHS = m.GetM()
                *
                v.Value[mIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: v is a variable and y is a parameter (1x0)
        public Constraints1ConstraintElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ,
            Interfaces.Variables.Iv v)
        {
            int LHS = s.Value
                .Select(
                x => y.GetElementAtAsint(
                    x,
                    rIndexElement)
                *
                ζ.GetElementAtAsint(
                    x,
                    mIndexElement))
                .Sum();

            Expression RHS = m.GetM()
                *
                v.Value[mIndexElement, rIndexElement];

            this.Value = LHS <= RHS;
        }

        // Constructor: v is a parameter and y is a variable (0x1)
        public Constraints1ConstraintElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Iζ ζ,
            Interfaces.Variables.Iy y)
        {
            Expression LHS = Expression.Sum(
                s.Value
                .Select(
                    x => y.Value[x, rIndexElement]
                    *
                    ζ.GetElementAtAsint(
                        x,
                        mIndexElement)));

            int RHS = m.GetM()
                *
                v.GetElementAtAsint(
                    mIndexElement,
                    rIndexElement);

            this.Value = LHS <= RHS;
        }

        // Constructor: v and y are both parameters (0x0)
        public Constraints1ConstraintElement(
            ImIndexElement mIndexElement,
            IrIndexElement rIndexElement,
            Im m,
            Is s,
            Interfaces.Parameters.MachineOperatingRoomAssignments.Iv v,
            Interfaces.Parameters.SurgeonOperatingRoomAssignments.Iy y,
            Iζ ζ)
        {
            // Not needed
        }

        public Constraint Value { get; }
    }
}