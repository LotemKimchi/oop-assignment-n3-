using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class EnergySource
    {
        protected float m_CurrentEnergy;
        protected readonly float m_MaxEnergyCapacity;

        public float CurrentEnergy
        {
            get { return m_CurrentEnergy; }
        }

        public float MaxEnergy
        {
            get { return m_MaxEnergyCapacity; }
        }

        public EnergySource(float i_CurrentEnergy, float i_MaxEnergy)
        {
            m_CurrentEnergy = i_CurrentEnergy;
            m_MaxEnergyCapacity = i_MaxEnergy;
        }

        public void AddEnergy(float i_AmountEnergy)
        {
            if (m_CurrentEnergy + i_AmountEnergy > m_MaxEnergyCapacity)
            {
                throw new ValueRangeException(0, m_MaxEnergyCapacity);
            }

            if (i_AmountEnergy < 0)
            {
                throw new ArgumentException("Energy amount must be positive");
            }

            m_CurrentEnergy += i_AmountEnergy;
        }
    }

    public class FuelEnergy : EnergySource
    {
        private readonly eFuelType m_FuelType;

        public eFuelType FuelType
        {
            get { return m_FuelType; }
        }

        public FuelEnergy(float i_CurrentLiter, float i_MaxLiter, eFuelType i_FuelType): 
            base(i_CurrentLiter, i_MaxLiter)
        {
            m_FuelType = i_FuelType;
        }
    }

    public class ElectricEnergy : EnergySource
    {
        public ElectricEnergy(float i_CurrentEnergy, float i_MaxLiter) :
        base(i_CurrentEnergy, i_MaxLiter)
        { }
        
    }
}
