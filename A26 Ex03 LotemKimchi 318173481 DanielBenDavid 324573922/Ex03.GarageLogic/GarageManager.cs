using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private Dictionary<string,Vehicle> m_Vehicles;
        public GarageManager() 
        {
            m_Vehicles = new Dictionary<string,Vehicle>();
        }

        public bool ContainVehciles(string i_LicenseNumber)
        {
            return m_Vehicles.ContainsKey(i_LicenseNumber);
        }

        public void AddVehicles(Vehicle i_Vehicle)
        {
            string licenseNumber = i_Vehicle.LicenseNumber;

            if (m_Vehicles.ContainsKey(licenseNumber))
            {
                throw new ArgumentException("Vehicle is alreadt exist");
            }

            m_Vehicles.Add(licenseNumber, i_Vehicle);
        }
        

        public Vehicle GetVehicle(string i_LicenseNumber)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle with current license number dosn't exist");
            }

            return m_Vehicles[i_LicenseNumber];
        }
    }
}
