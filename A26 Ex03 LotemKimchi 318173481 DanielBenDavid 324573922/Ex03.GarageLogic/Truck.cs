using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsCarryingHazardousMaterials;
        private float m_CargoVolume;

        public bool IsCarryingHazardousMaterials
        {
            get { return m_IsCarryingHazardousMaterials; }
            set { m_IsCarryingHazardousMaterials = value; }
        }

        public float CargoVolume
        {
            get { return m_CargoVolume; }
            set { m_CargoVolume = value; }
        }

        public Truck(string i_LicenseNumber, string i_ModelName)
            : base(i_LicenseNumber, i_ModelName)
        {
        }

        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string truckInfo = string.Format("{0}\nIs Carrying Hazardous Materials: {1}\nCargo Volume: {2}",
                vehicleInfo, 
                m_IsCarryingHazardousMaterials, 
                m_CargoVolume);

            return truckInfo;
        }
    }
}

