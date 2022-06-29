namespace Decorator
{
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
