using System;

namespace D15_Elements
{
    
    internal class Program
    {
        class Element
        {
            public string name, type;
            public int Z; 
            public double meltingPoint, boilingPoint; 

            public void Print() 
            {

                Console.WriteLine($"   Element:{name}");
                Console.WriteLine($"Type:{type}");
                Console.WriteLine($"Melting point:{meltingPoint}");
                Console.WriteLine($"Boiling point: {boilingPoint}");
                Console.WriteLine("========");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 1, 2 och 3");
            Console.WriteLine("===================================");
            Element oxygen = new Element{ name = "Oxygen", Z = 8, type = "non-metal", meltingPoint = 54.36, boilingPoint = 90.188};
            Element iron = new Element { name = "Iron", Z = 26, type = "metal", meltingPoint = 1811, boilingPoint = 3134 };
            Element gold = new Element { name = "Gold", Z = 79, type = "metal", meltingPoint = 1337.33, boilingPoint = 3243 };
            oxygen.Print();
            iron.Print();
            gold.Print();

            Console.WriteLine("Uppgift 4 och 5");
            Console.WriteLine("===================================");

            Element[] elementArr = new Element[6] { oxygen, iron, gold, 
                new Element() {name = "Hydrogen", Z = 1, type = "non-metal", meltingPoint = 13.99, boilingPoint = 20.271 },
                new Element() {name = "Brom", Z = 35, type = "non-metal", meltingPoint = 265.8, boilingPoint = 332.0 },
                new Element() {name = "Quicksilver", Z = 80, type = "metal", meltingPoint = 234.3210, boilingPoint = 629.88 } };

            foreach (Element E in elementArr)
                E.Print();

            Console.WriteLine("Uppgift 6");
            Console.WriteLine("===================================");
            foreach (Element E in elementArr)
                if (E.type == "metal")
                    Console.WriteLine(E.name);

            Console.ReadLine();


        }
    }
}