using System.Reflection;
using System.Xml.Schema;

namespace class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Task1
            Car MyCar = new Car("Jeep", "Wrangler", 1920, 2);
            MyCar.ShowFullInfo();
            MotorCycle myBike = new MotorCycle("Yamaha", "R15", 8000, 2);
            myBike.ShowFullInfo();

        }
    }


    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string Brand, string Model, double Mile)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Mile = Mile;
        }

    }

    class Car : Vehicle
    {
        public int DoorsNum;

        public Car(string Brand, string Model, double Mile, int DoorsNum) : base(Brand, Model, Mile)
        {
            this.DoorsNum = DoorsNum;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand} Model:{Model} Mile:{Mile} DoorsNume:{DoorsNum}");
        }
    }

    class MotorCycle : Vehicle
    {
        public int WheelNum;

        public MotorCycle(string Brand, string Model, double Mile, int WheelNum) : base(Brand, Model, Mile)
        {
            this.WheelNum = WheelNum;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand} Model:{Model} WheelNum:{WheelNum}");
        }
    }

}


