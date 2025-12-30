using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        private eCarColor m_CarColor;
        private eNumOfDoors m_NumOfDoors;

        public eCarColor CarColor
        {
            get { return m_CarColor; }
            set { m_CarColor = value; }
        }

        public eNumOfDoors NumOfDoors
        {
            get { return m_NumOfDoors; }
            set { m_NumOfDoors = value; }
        }

        public Car(string i_LicenseNumber, string i_ModelName) :
            base(i_LicenseNumber, i_ModelName)
        {
        }

        public override string ToString()
        {
            string vehicleInfo = base.ToString();
            string carInfo = string.Format("{0}\nCar color: {1}\nNumber of doors: {2}",
                vehicleInfo,
                m_CarColor,
                (int)m_NumOfDoors);

            return carInfo;
        }
    }
}
