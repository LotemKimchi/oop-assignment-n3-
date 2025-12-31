using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        private const int k_NumberOfWheels = 2;
        private const float k_MaxWheelAirPressure = 29f;
        private const float k_MaxBatteryHours = 2.6f;

        public static int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public static float MaxWheelAirPressure
        {
            get { return k_MaxWheelAirPressure; }
        }

        public ElectricMotorcycle(string i_LicenseNumber, string i_ModelName) : base(i_LicenseNumber, i_ModelName)
        {
            EnergySource = new ElectricEnergy(0f, k_MaxBatteryHours);
        }
    }
}
