using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class FleetManager : IEnumerable<Vehicle>
    {
        private static FleetManager instance;
        private List<Vehicle> vehicles = new List<Vehicle>();

        private FleetManager() { }

        public static FleetManager GetInstance()
        {
            if (instance == null)
            {
                instance = new FleetManager();
            }
            return instance;
        }

        public void AddVehicle(Vehicle v)
        {
            vehicles.Add(v);
        }

        public Vehicle this[int id]
        {
            get => vehicles.FirstOrDefault(v => v.Id == id);
        }

        public Vehicle this[string type]
        {
            get => vehicles.FirstOrDefault(v => v.Type.ToLower() == type.ToLower());
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
