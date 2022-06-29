
namespace Patterns.FlyweightClasses
{
    abstract class Task
    {
        abstract public void Run(string fileName);
    }

    class VocaleCounter : Task
    {
        public override void Run(string fileName)
        {
            string fileText = ResourceManager.Instance().GetFileContents(fileName);
            int counter = 0;
            foreach (char c in fileText)
            {
                if ("aeiouAEIOU".Contains(c))
                    counter++;
            }
            Console.WriteLine("Fisierul '" + fileName + "' contine " + counter.ToString() + " vocale!");
        }
    }

    class ConsoaneCounter : Task
    {
        public override void Run(string fileName)
        {
            string fileText = ResourceManager.Instance().GetFileContents(fileName);
            int counter = 0;
            foreach (char c in fileText)
            {
                if ("qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM".Contains(c))
                    counter++;
            }
            Console.WriteLine("Fisierul '" + fileName + "' contine " + counter.ToString() + " consoane!");
        }
    }

    class NonLitereCounter : Task
    {
        public override void Run(string fileName)
        {
            string fileText = ResourceManager.Instance().GetFileContents(fileName);
            int counter = 0;
            foreach (char c in fileText)
            {
                if (!Char.IsLetter(c))
                    counter++;
            }
            Console.WriteLine("Fisierul '" + fileName + "' contine " + counter.ToString() + " caractere care nu sunt litere!");
        }
    }

    class TextPrinter : Task
    {
        public override void Run(string fileName)
        {
            string fileText = ResourceManager.Instance().GetFileContents(fileName);
            Console.WriteLine("Fisierul '" + fileName + "' contine textul: '" + fileText + "'.");
        }
    }
}
