using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelTruck : Truck
    {
        private const int k_NumberOfWheels = 12;
        private const float k_MaxWheelAirPressure = 26f;
        private const float k_MaxFuelLiters = 140f;
        private const eFuelType k_FuelType = eFuelType.Soler;

        public static int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public static float MaxWheelAirPressure
        {
            get { return k_MaxWheelAirPressure; }
        }

        public FuelTruck(string i_LicenseNumber, string i_ModelName) : base(i_LicenseNumber, i_ModelName)
        {
            EnergySource = new FuelEnergy(0f, k_MaxFuelLiters, k_FuelType);
        }
    }
}
