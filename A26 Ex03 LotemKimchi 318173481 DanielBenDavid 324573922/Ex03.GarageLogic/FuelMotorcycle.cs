using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelMotorcycle : Motorcycle
    {
        private const int k_NumberOfWheels = 2;
        private const float k_MaxWheelAirPressure = 29f;
        private const float k_MaxFuelLiters = 6.8f;
        private const eFuelType k_FuelType = eFuelType.Octan98;

        public static int NumberOfWheels
        {
            get { return k_NumberOfWheels; }
        }

        public static float MaxWheelAirPressure
        {
            get { return k_MaxWheelAirPressure; }
        }

        public FuelMotorcycle(string i_LicenseNumber, string i_ModelName) : base(i_LicenseNumber, i_ModelName)
        {
            EnergySource = new FuelEnergy(0f, k_MaxFuelLiters, k_FuelType);
        }
    }
}
