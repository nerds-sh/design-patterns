namespace Decorator
{
    class LightsDecorator : ChristmasTreeDecorator
    {
        public LightsDecorator(IChristmasTree christmastree) : base(christmastree) { }
        public override string GetChristmasTreeOrnament()
        {
            string ornament = base.GetChristmasTreeOrnament();
            ornament += ", with lights";
            return ornament;
        }

    }
}