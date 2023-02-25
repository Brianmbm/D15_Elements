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
                Console.WriteLine($"Element:{name}");
                Console.WriteLine($"Type:{type}");
                Console.WriteLine($"Melting point:{meltingPoint}");
                Console.WriteLine($"Boiling point: {boilingPoint}");

            }
        }
        static void Main(string[] args)
        {
            Element oxygen = new Element{ name = "Oxygen", Z = 8, type = "non-metal", meltingPoint = 54.36, boilingPoint = 90.188};
            Element iron = new Element { name = "Iron", Z = 26, type = "metal", meltingPoint = 1811, boilingPoint = 3134 };
            Element gold = new Element { name = "Gold", Z = 79, type = "metal", meltingPoint = 1337.33, boilingPoint = 3243 };
            oxygen.Print();
            iron.Print();
            gold.Print();   

        }
    }
}