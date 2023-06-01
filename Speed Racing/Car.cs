using System;
namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmont;
        private double fuelConsumptionPerKilometer;
        private double travelleddistance;



        public Car()
        {

        }

        public Car(string model, double fuelAmont, double fuelConsuption) : this()
        {
            Model = model;
            FuelAmont = fuelAmont;
            FuelConsumptionPerKilometer = fuelConsuption;
        }


        public string Model { get { return model; } set { model = value; } }
        public double FuelAmont { get { return fuelAmont; } set { fuelAmont = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double Travelleddistance { get { return travelleddistance; } set { travelleddistance = value; } }


        public void Drive(double distanse)
        {

            double fuelToReduse = distanse * FuelConsumptionPerKilometer;
            if (FuelAmont > fuelToReduse)
            {
                FuelAmont -= fuelToReduse;
                Travelleddistance += distanse;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }


    

}
