using System.Text;

namespace Indexer
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            //emp1.firstName = "Will";
            //emp1.lastName = "John";
            //emp1.city = "LA";
            //Console.WriteLine($"{emp1.firstName}");
            //Console.WriteLine($"{emp1.lastName}");

            //Console.WriteLine($"{emp1[0]}");
            //Console.WriteLine($"{emp1[1]}");
            //Console.WriteLine($"{emp1[2]}");



            //Car car = new Car();
            //string color = car.CarColor();
            //Console.WriteLine(color);

            //String str = new String("abdba");
            //bool bo = str.IsPolindrome();
            //Console.WriteLine(bo);

            Console.WriteLine("Write number");
            string x = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(x);
            Console.WriteLine(stringBuilder.IsSimpleNumber());
        }
    }
}
