
namespace Car_class
{
    public class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;


        public double Drive(int km)
        
        {
            double requiredFuel = km * FuelFor1Km;

            if (CurrentFuel >= requiredFuel)
            {
                
                
                Console.WriteLine($"New traveled {km} km. Current Fuel: {CurrentFuel -= requiredFuel} liters. New Millage {Millage+=km}");
                return CurrentFuel ;
            }

            else
            {
                Console.WriteLine($"Not enough fuel. Maximum distance: {CurrentFuel / FuelFor1Km} km.");
                return CurrentFuel;
            }
            
             
        }
    }
}
