using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var collection = new ServiceCollection();
            collection.AddScoped<IDep1, DepOne>();

            var serviceProvider = collection.BuildServiceProvider();


            var depOne = serviceProvider.GetService<IDep1>();
            One one = new One(depOne);
            one.CallAnotherMethod();
            
        }
    }

     class One
    {
        private readonly IDep1 _dep1;

        // without dependency injection code
        //public One()
        //{
        //    _dep1 = new DepOne();
        //}


        // with dependency injection code
        public One(IDep1 dep1)
        {
            _dep1 = dep1;
        }


        public void CallAnotherMethod()
        {
            Console.WriteLine("logging started from call another method function");

            _dep1.Sample1();

            Console.WriteLine("logging ended from call another method");

        }
    }

    interface IDep1
    {
        void Sample1();
    }

    class DepOne : IDep1
    {
        public void Sample1()
        {
            Console.WriteLine("logging from sample 1 and depone");
        }
    }
}