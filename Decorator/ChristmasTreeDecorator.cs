namespace Decorator
{
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
}