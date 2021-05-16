namespace HM.HM3B.A.E.O.InterfacesFactories.Results.OverallWallTime
{
    using System;

    using HM.HM3B.A.E.O.Interfaces.Results.OverallWallTime;

    public interface IOverallWallTimeFactory
    {
        IOverallWallTime Create(
            TimeSpan value);
    }
}