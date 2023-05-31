namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
           
            
            Car car = new Car("BMW", "X3", 2006, 60, 10);
            car.FuelQuantity = 100;
            car.FuelConsumption = 2;

            car.Drive(10);
            car.Drive(1000);
            
            Console.WriteLine(car.WhoAmI());
        }
    }
}
