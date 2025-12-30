using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicle
    {
        private readonly eLicenseType m_LicenseType;
        private readonly int m_EngineVolumeCc;

        public Motorcycle(string i_ModelName, string i_LicenseNumber, EnergySource i_EnergySource, List<Wheel> i_Wheels, 
            eLicenseType i_LicenseType, int i_EngineVolumeCc) 
            : base(i_ModelName, i_LicenseNumber, i_EnergySource, i_Wheels)
        {
            m_LicenseType = i_LicenseType;
            m_EngineVolumeCc = i_EngineVolumeCc;
        }

        public eLicenseType GetLicenseType() 
        {
            return m_LicenseType;
        }
        public int GetEngineVolumeCc()
        {
            return m_EngineVolumeCc;
        }

        //TBD
        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string MotorcycleInfo = string.Format("{0}\nLicense Type: {1}\nEngine Volume Cc: {2}"
                , vehicleInfo, m_LicenseType, m_EngineVolumeCc);

            return MotorcycleInfo;
        }
    }
}
