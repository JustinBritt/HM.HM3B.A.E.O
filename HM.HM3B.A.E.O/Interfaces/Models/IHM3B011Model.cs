namespace HM.HM3B.A.E.O.Interfaces.Models
{
    using HM.HM3B.A.E.O.Interfaces.CrossJoins;
    using HM.HM3B.A.E.O.Interfaces.Variables;

    public interface IHM3B011Model : IHM3BModel
    {
        Isr sr { get; }

        Iy y { get; }
    }
}