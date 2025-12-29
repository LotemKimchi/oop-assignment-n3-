using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        private readonly eCarColor m_CarColor;
        private readonly eNumOfDoors m_NumOfDoors;

        public Car(string i_ModelName, string i_LicenseNumber, EngineSource i_EnergySource, List<Wheel> i_Wheels,
            eCarColor i_CarColor, eNumOfDoors i_NumOfDoors): 
            base(i_ModelName, i_LicenseNumber, i_EnergySource, i_Wheels)
        {
            m_CarColor = i_CarColor;
            m_NumOfDoors = i_NumOfDoors;
        }

        public eCarColor GetCarColor() { 
            return m_CarColor;
        }

        public eNumOfDoors GetNumOfDoors() { 
            return m_NumOfDoors; 
        }

        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string carInfo = string.Format("{0}\nCar color: {1}\nNumber of doors: {2}", vehicleInfo, m_CarColor, (int)m_NumOfDoors);

            return carInfo;
        }
    }
}
