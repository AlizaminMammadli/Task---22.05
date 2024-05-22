using System.Security.Cryptography.X509Certificates;

namespace Car_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Chevrolet";
            car.Model = "Aveo";
            car.CurrentFuel = 23;
            car.FuelFor1Km = 0.06;
            car.Millage = 279000;

            Console.WriteLine(car.Drive(383));       
        
        }
         
    }
}
