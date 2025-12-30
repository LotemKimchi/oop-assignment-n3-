using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        private eLicenseType m_LicenseType;
        private int m_EngineVolumeCc;

        public eLicenseType LicenseType
        {
            get { return m_LicenseType; }
            set { m_LicenseType = value; }
        }

        public int EngineVolumeCc
        {
            get { return m_EngineVolumeCc; }
            set { m_EngineVolumeCc = value; }
        }

        public Motorcycle(string i_LicenseNumber, string i_ModelName) 
            : base(i_LicenseNumber, i_ModelName)
        {
        }

        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string MotorcycleInfo = string.Format("{0}\nLicense Type: {1}\nEngine Volume Cc: {2}"
                , vehicleInfo, m_LicenseType, m_EngineVolumeCc);

            return MotorcycleInfo;
        }
    }
}
