namespace HM.HM3B.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using HM.HM3B.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using HM.HM3B.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;
    
    internal sealed class SurgeonScenarioNumberPatientsCalculation : ISurgeonScenarioNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsCalculation()
        {
        }

        public ISurgeonScenarioNumberPatients Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            ISurgeonScenarioNumberPatientsFactory surgeonScenarioNumberPatientsFactory,
            ISurgeonScenarioNumberPatientsResultElementCalculation surgeonScenarioNumberPatientsResultElementCalculation,
            Is s,
            IΛ Λ,
            Irt rt,
            In n,
            Ix x)
        {
            RedBlackTree<IsIndexElement, RedBlackTree<IΛIndexElement, ISurgeonScenarioNumberPatientsResultElement>> outerRedBlackTree = new();

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<IΛIndexElement, ISurgeonScenarioNumberPatientsResultElement> innerRedBlackTree = new();

                foreach (IΛIndexElement ΛIndexElement in Λ.Value.Values)
                {
                    innerRedBlackTree.Add(
                        ΛIndexElement,
                        surgeonScenarioNumberPatientsResultElementCalculation.Calculate(
                            surgeonScenarioNumberPatientsResultElementFactory,
                            sIndexElement,
                            ΛIndexElement,
                            rt,
                            n,
                            x));
                }

                outerRedBlackTree.Add(
                    sIndexElement,
                    innerRedBlackTree);
            }

            return surgeonScenarioNumberPatientsFactory.Create(
                outerRedBlackTree);
        }
    }
}