namespace SpeedRacing
{
    public class StartUp
    {

        public static void Main(string[] args)
        {

            Dictionary<string, Car> dict = new();
            string comand = string.Empty;
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tockens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = tockens[0];
                double fuelAmont = double.Parse(tockens[1]);
                double fuelConsumption = double.Parse(tockens[2]);

                Car car = new Car(model, fuelAmont, fuelConsumption);

                dict.Add(car.Model, car);
               
            }

            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandTockens = comand.Split();
                string model = comandTockens[1];
                double distanse = double.Parse(comandTockens[2]);

                Car car1 = dict[model];
                car1.Drive(distanse);
            }

            foreach (var (name , car) in dict)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmont} {car.Travelleddistance}");
            }
            

        }
    }
}


