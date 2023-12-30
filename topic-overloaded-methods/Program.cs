namespace Basics
{
    public class ExampleForOverLoadedMethods
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer();
            // calling default function
            p.Print();

            // calling function with string parameter
            p.Print("abc string");

            // calling function with numeric parameter
            p.Print(100);
        }
    }

    public class Printer
    {
        public void Print() 
        {
            Console.WriteLine("printing with out message");
        }

        public void Print(string message)
        {
            Console.WriteLine("printing with message: "+ message);
        }

        public void Print(int value)
        {
            Console.WriteLine("printing with numeric value: " + value);
        }
    }

}