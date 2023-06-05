using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year ,
            double fuelQ , double fuelC) : this(make , model , year)
        {
            FuelQuantity = fuelQ;
            FuelConsumption = fuelC;
        }

        public Car(string make, string model, int year,
            double fuelQ, double fuelC , Engine engine , Tire[] tire) : this(make, model, year , fuelQ , fuelC)
        {
            this.Engine = engine;
            this.Tires = tire;
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }



        public void Drive(double distance)
        {
            double need = distance * fuelConsumption;
            if (FuelQuantity - need >= 0)
            {
                FuelQuantity -= need;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        internal bool WhoAmI()
        {
            throw new NotImplementedException();
        }
    }
}