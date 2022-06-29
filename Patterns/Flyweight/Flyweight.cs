
using Patterns.FlyweightClasses;

namespace Patterns {
    class Flyweight {
        public static void Run() {
            File.WriteAllText("bruh.txt", "Fisierul in care textul acesta se afla se rescrie de fiecare data la run.");
            File.WriteAllText("masina.txt", "Vroom vroom, mentenanta este inevitabila pe Skoda.");

               new VocaleCounter().Run("bruh.txt");
             new ConsoaneCounter().Run("bruh.txt");
            new NonLitereCounter().Run("bruh.txt");
            new NonLitereCounter().Run("masina.txt");
                 new TextPrinter().Run("bruh.txt");
                 new TextPrinter().Run("masina.txt");
        }
    }
}
