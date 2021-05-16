namespace HM.HM3B.A.E.O.InterfacesAbstractFactories
{
    using HM.HM3B.A.E.O.InterfacesFactories.ConstraintElements;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory();

        IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory();

        IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory();

        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory();

        IConstraints5MConstraintElementFactory CreateConstraints5MConstraintElementFactory();

        IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory();

        IConstraints6ConstraintElementFactory CreateConstraints6ConstraintElementFactory();

        IConstraints7ConstraintElementFactory CreateConstraints7ConstraintElementFactory();

        IConstraints8LConstraintElementFactory CreateConstraints8LConstraintElementFactory();

        IConstraints8UConstraintElementFactory CreateConstraints8UConstraintElementFactory();

        IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory();

        IConstraints10ConstraintElementFactory CreateConstraints10ConstraintElementFactory();
    }
}