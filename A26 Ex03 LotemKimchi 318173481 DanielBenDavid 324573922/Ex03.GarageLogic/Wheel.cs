using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrenAirPressure;
        private float m_MaxAirPressure;

        public Wheel( string i_ManufacturerName, float i_MaxAirPressure)
        {
            m_ManufacturerName = i_ManufacturerName;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        public float CurrentAirPressur
        {
            get { return m_CurrenAirPressure; }
        }

        public float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
        }

        public string _ManufacturerName
        {
            get { return m_ManufacturerName; }
        }

        public void ChangeAirPressureToMax()
        {
            m_CurrenAirPressure = m_MaxAirPressure;
        }

        public void AddAirPressure(float i_AirPressureToAdd)
        {
            if (i_AirPressureToAdd < 0)
            {
                throw new ArgumentException("air pressure must be positive");
            }

            if (m_CurrenAirPressure + i_AirPressureToAdd > m_MaxAirPressure)
            {
                throw new ValueRangeException(0, m_MaxAirPressure);
            }

            m_CurrenAirPressure += i_AirPressureToAdd;
        }
    }
}
