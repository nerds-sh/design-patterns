namespace Decorator
{
    class StarDecorator : ChristmasTreeDecorator
    {
        public StarDecorator(IChristmasTree christmastree) : base(christmastree) { }
        public override string GetChristmasTreeOrnament()
        {
            string ornament = base.GetChristmasTreeOrnament();
            ornament += ", with a shining star";
            return ornament;
        }

    }
}