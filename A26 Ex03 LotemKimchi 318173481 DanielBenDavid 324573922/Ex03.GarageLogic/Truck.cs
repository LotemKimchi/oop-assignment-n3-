using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        private readonly bool m_IsCarryingHazardousMaterials;
        private readonly float m_CargoVolume;

        public Truck(string i_ModelName, string i_LicenseNumber, EnergySource i_EnergySource, List<Wheel> i_Wheels,
            bool i_IsCarryingHazardousMaterials, float i_CargoVolume)
            : base(i_ModelName, i_LicenseNumber, i_EnergySource, i_Wheels)
        {
            m_IsCarryingHazardousMaterials = i_IsCarryingHazardousMaterials;
            m_CargoVolume = i_CargoVolume;
        }

        public bool GetIsCarryingHazardousMaterials()
        {
            return m_IsCarryingHazardousMaterials;
        }

        public float GetCargoVolume()
        {
            return m_CargoVolume;
        }

        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string TruckInfo = string.Format("{0}\nIs Carrying Hazardous Materials: {1}\nCargo Volume Cc: {2}"
                , vehicleInfo, m_IsCarryingHazardousMaterials, m_CargoVolume);

            return TruckInfo;
        }
    }
}
}
