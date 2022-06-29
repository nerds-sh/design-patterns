
namespace Patterns.FlyweightClasses
{
    class ResourceManager
    {
        private ResourceManager() { }
        public static ResourceManager instance = null;
        public static ResourceManager Instance()
        {
            if (instance == null)
                instance = new ResourceManager();

            return instance;
        }

        private Dictionary<string, string> contents = new Dictionary<string, string>();
        public string GetFileContents(string fileName)
        {
            if (!contents.ContainsKey(fileName))
            {
                contents.Add(fileName, File.ReadAllText(fileName));
                Console.WriteLine("Manager: fisierul '" + fileName + "' a fost citit.");
            }

            return contents[fileName];
        }
    }
}
