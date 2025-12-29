using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ValueRangeException : Exception
    {
        private readonly float m_MinValue;
        private readonly float m_MaxValue;
        public ValueRangeException(float i_MinValue, float i_MaxValue)
            :base(string.Format("Value is out of range- the valid range between: {0}-{1}",i_MinValue, i_MaxValue))
        {
            m_MinValue = i_MinValue;
            m_MaxValue = i_MaxValue;
        }

        public float GetMinValue()
        {
            return m_MinValue;
        }
        public float GetMaxValue()
        {
            return m_MaxValue;
        }
    }
}
