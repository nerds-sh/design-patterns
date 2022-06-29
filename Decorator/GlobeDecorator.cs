namespace Decorator
{
    class GlobeDecorator : ChristmasTreeDecorator
    {
        public GlobeDecorator(IChristmasTree christmastree) : base(christmastree) { }
        public override string GetChristmasTreeOrnament()
        {
            string ornament = base.GetChristmasTreeOrnament();
            ornament += ", with globes";
            return ornament;
        }

    }
}