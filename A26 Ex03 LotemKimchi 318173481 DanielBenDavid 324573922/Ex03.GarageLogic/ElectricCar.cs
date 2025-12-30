using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        private const int k_NumberOfWheels = 5;
        private const float k_MaxWheelAirPressure = 33f;
        private const float k_MaxBatteryHours = 4.2f;

        public static int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public static float MaxWheelAirPressure
        {
            get { return k_MaxWheelAirPressure; }
        }

        public ElectricCar(string i_LicenseNumber, string i_ModelName) : base(i_LicenseNumber, i_ModelName)
        {
            EnergySource = new ElectricEnergy(0f, k_MaxBatteryHours);
        }
    }
}
