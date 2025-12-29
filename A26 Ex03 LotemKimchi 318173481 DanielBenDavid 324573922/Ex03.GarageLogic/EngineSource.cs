using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class EngineSource
    {
        protected float m_CurrentEnergy;
        protected readonly float m_MaxEnergyCapacity;

        public EngineSource(float i_CurrentEnergy, float i_MaxEnergy)
        {
            m_CurrentEnergy = i_CurrentEnergy;
            m_MaxEnergyCapacity = i_MaxEnergy;
        }

        public float GetCurrentEnergy()
        {
            return m_CurrentEnergy;
        }

        public float GetMaxEnergy()
        {
            return m_MaxEnergyCapacity;
        }

        public void AddEnergy(float i_AmountEnergy)
        {
            if (m_CurrentEnergy + i_AmountEnergy > m_MaxEnergyCapacity)
            {
                throw new ValueRangeException(0, m_MaxEnergyCapacity);
            }

            m_CurrentEnergy += i_AmountEnergy;
        }
    }

    public class FuelEnergy : EngineSource
    {
        private readonly eFuelType m_FuelType;

        public FuelEnergy(float i_CurrentLiter, float i_MaxLiter, eFuelType i_FuelType): 
            base(i_CurrentLiter, i_MaxLiter)
        {
            m_FuelType = i_FuelType;
        }

        public eFuelType GetFuelType()
        {
            return m_FuelType;
        }

    }

    public class ElectricEnergy : EngineSource
    {
        public ElectricEnergy(float i_CurrentEnergy, float i_MaxLiter) :
        base(i_CurrentEnergy, i_MaxLiter)
        { }
        
    }
}
