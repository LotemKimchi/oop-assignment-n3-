using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private readonly string m_LicenseNumber;
        private readonly string m_ModelName;
        //just in garge vehicle info?
        //private eVehicleStatus m_VehicleStatus;
        public readonly List<Wheel> m_Wheels;
        private EnergySource m_EnergySource;

        public string ModelName
        {
            get { return m_ModelName; }
        }

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
        }

        //public eVehicleStatus VehicleStatus
        //{
        //    get { return m_VehicleStatus; }
        //    set { m_VehicleStatus = value; }
        //}

        public EnergySource EnergySource
        {
            get { return m_EnergySource; }
            set { m_EnergySource = value; }
        }

        public float RemainingEnergyPercentage
        {
            get
            {
                float percentage = 0f;
                if (m_EnergySource != null && m_EnergySource.MaxEnergy > 0)
                {
                    percentage = (m_EnergySource.MaxEnergy / m_EnergySource.MaxEnergy) * 100f;
                }

                return percentage;
            }
        }

        public List<Wheel> Wheels
        {
            get { return m_Wheels; }
        }

        public Vehicle(string i_LicenseNumber, string i_ModelName)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_Wheels = new List<Wheel>();
            //m_VehicleStatus = eVehicleStatus.InRepair;

        }

        public void InitializeWheels(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure, int i_NumberOfWheels)
        {
            if (i_NumberOfWheels <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(i_NumberOfWheels), "Number of wheels must be positive");
            }

            m_Wheels.Clear();

            for (int i = 0; i < i_NumberOfWheels; i++)
            {
                Wheel wheel = new Wheel(i_ManufacturerName, i_MaxAirPressure);
                wheel.AddAirPressure(i_CurrentAirPressure);
                m_Wheels.Add(wheel);
            }
        }

        public void WheelsAirPressureToMax()
        {
            foreach (Wheel wheel in m_Wheels)
            {
                wheel.ChangeAirPressureToMax();
            }
        }

        public override string ToString()
        {
            string vehicleInfo = string.Format("Model: {0}\nLicense Number: {1}\nVehicle Status: {2}\n" +
                "Wheel Status: {3}\nEnergy Source: {4}"
                , m_ModelName, m_LicenseNumber, /*m_VehicleStatus,*/ m_Wheels, m_EnergySource);

            return vehicleInfo;
        }
    }
}
