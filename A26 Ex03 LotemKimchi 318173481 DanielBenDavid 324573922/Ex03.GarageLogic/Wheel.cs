using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrenAirPressure;
        private float m_MaxAirPressure;

        public Wheel( string i_ManufacturerName, float i_AirPressure)
        {
            m_ManufacturerName = i_ManufacturerName;
            m_CurrenAirPressure = i_AirPressure;

        }

        public void AddAirPressure(float i_AirPressure)
        {
            //maby do here axeption?
            if(m_CurrenAirPressure + i_AirPressure <= m_MaxAirPressure)
            {
                m_CurrenAirPressure += i_AirPressure;
            }
            else
            {
                throw ValueRangeException;
            }
        }
    }
}
