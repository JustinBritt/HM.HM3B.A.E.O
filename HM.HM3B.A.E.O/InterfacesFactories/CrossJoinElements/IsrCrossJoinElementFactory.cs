﻿namespace HM.HM3B.A.E.O.InterfacesFactories.CrossJoinElements
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoinElements;
    using HM.HM3B.A.E.O.Interfaces.IndexElements;

    public interface IsrCrossJoinElementFactory
    {
        IsrCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IrIndexElement rIndexElement);
    }
}