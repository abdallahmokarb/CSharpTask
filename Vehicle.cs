using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_
{
    public class Vehicle

    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Mileage { get; private set; }
        public int FuelCapacity { get; set; }  

        public Vehicle(int id, string type, int mileage, int fuelCapacity)
        {
            Id = id;
            Type = type;
            Mileage = mileage;
            FuelCapacity = fuelCapacity;
        }

        public void AddMileage(params int[] miles)
        {
            foreach (int m in miles)
            {
                Mileage += m;
            }
        }

        public void GetFuelStatus(out string status)
        {
            if (FuelCapacity >= 50)
            {
                status = "fuel sufficient";
            }
            else
            {
                status = "fuel low";
            }
        }

        public override string ToString()
        {
            return $"vehicle id: {Id}, type: {Type}, mileage: {Mileage}, fuel: {FuelCapacity}L";
        }
    }
}
 
