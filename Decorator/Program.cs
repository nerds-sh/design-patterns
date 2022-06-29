namespace Decorator
{
    interface IChristmasTree
    {
        string GetChristmasTreeOrnament();
    }

    class ChristmasTree : IChristmasTree
    {
        public string GetChristmasTreeOrnament()
        {
            return "This is a naked ChristmasTree!";
        }
    }

    class ChristmasTreeDecorator : IChristmasTree
    {
        private IChristmasTree _christmastree;

        public ChristmasTreeDecorator(IChristmasTree christmastree)
        {
            _christmastree = christmastree;
        }
        public virtual string GetChristmasTreeOrnament()
        {
            return _christmastree.GetChristmasTreeOrnament();
        }
    }

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
    class Program
    {
        static void Main(string[] args)
        {
            IChristmasTree brad = new ChristmasTree();
            IChristmasTree luminite = new LightsDecorator(brad);
            IChristmasTree steluta = new StarDecorator(luminite);
            IChristmasTree globuri = new GlobeDecorator(steluta);
            Console.WriteLine(globuri.GetChristmasTreeOrnament());
        }
    }

}
