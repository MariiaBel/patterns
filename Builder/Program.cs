using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            BuildeHouser builderH = new BuildeHouser();
            BuilderCastle builderC = new BuilderCastle();


            director.Builder = builderH;

            Console.WriteLine("Standart house: ");
            director.BuildMinStructure();
            Console.WriteLine(builderH.GetHouse().ListParts());

            Console.WriteLine("Full featured house:");
            director.BuildMaxStructure();
            Console.WriteLine(builderH.GetHouse().ListParts());

            // Паттерн Строитель можно использовать без класса
            // Директор.
            Console.WriteLine("Custom product:");
            builderH.BuildBasemant();
            Console.Write(builderH.GetHouse().ListParts());

            Console.WriteLine(new string('-', 30));
            
            director.Builder = builderC;

            Console.WriteLine("Castle: ");
            director.BuildMaxStructure();
            Console.WriteLine(builderC.GetCastle().ListParts());
            Console.ReadKey();
        }
    }
}
