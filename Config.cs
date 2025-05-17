using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_
{
    internal class Config
    {
        private static Config instance;

        private Config()
        {
            DeviceName = "HP Vicus x";
            Model = "Gaming Model X2-00";
        }

        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }

            return instance;
        }

         public string DeviceName { get; set; }
        public string Model { get; set; }

        public void ShowConfig()
        {
            Console.WriteLine("device name : " + DeviceName);
            Console.WriteLine("model: " + Model);
        }

    }
}
