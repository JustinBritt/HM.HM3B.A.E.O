﻿namespace HM.HM3B.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using HM.HM3B.A.E.O.Interfaces.IndexElements;
    using HM.HM3B.A.E.O.Interfaces.Indices;
    using HM.HM3B.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using HM.HM3B.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;
    using HM.HM3B.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks;

    public interface Iβ
    {
        VariableCollection<IsIndexElement, IrIndexElement, IdIndexElement> Value { get; }

        int GetElementAt(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement,
            IdIndexElement dIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayNumberAssignedTimeBlocks.Iβ GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IβResultElementFactory βResultElementFactory,
            IβFactory βFactory,
            Id d,
            Ir r,
            Is s);
    }
}