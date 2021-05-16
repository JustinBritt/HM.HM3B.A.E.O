﻿namespace HM.HM3B.A.E.O.Factories.Parameters.SurgeonScenarioMaximumNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using HM.HM3B.A.E.O.Classes.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.ParameterElements.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.Interfaces.Parameters.SurgeonScenarioMaximumNumberPatients;
    using HM.HM3B.A.E.O.InterfacesFactories.Parameters.SurgeonScenarioMaximumNumberPatients;

    internal sealed class σFactory : IσFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public σFactory()
        {
        }

        public Iσ Create(
            ImmutableList<IσParameterElement> value)
        {
            Iσ parameter = null;

            try
            {
                parameter = new σ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}