
namespace Day2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Day 2 Remaining Tasks =>  5 , 8
            // Abdallah Hassan Abdallah

             Config config = Config.GetInstance();

            //---------------------------------------------------------
             config.DeviceName = "DELL Laptop";
             config.Model = "DELL G3 2022";

            //---------------------------------------------------------

             config.ShowConfig();

             Config another = Config.GetInstance();

             Console.WriteLine(config == another);

            Console.WriteLine("-------------------------------------------------");


            //---------------------------------------------------------
            

            FleetManager manager = FleetManager.GetInstance();

            manager.AddVehicle(new Vehicle(1, "truck", 45000, 70));
            manager.AddVehicle(new Vehicle(2, "van", 30000, 40));
            manager.AddVehicle(new Vehicle(3, "car", 15000, 55));

            manager[1].AddMileage(200, 300);  
            manager[2].AddMileage(100);      

             foreach (var vehicle in manager)
            {
                vehicle.GetFuelStatus(out string fuelStatus);
                Console.WriteLine(vehicle);
                Console.WriteLine("fuel status : " + fuelStatus);
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------------------");



        }
    }
}