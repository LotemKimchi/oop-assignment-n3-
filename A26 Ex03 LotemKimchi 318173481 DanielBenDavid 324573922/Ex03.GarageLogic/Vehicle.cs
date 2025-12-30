using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNumber;

        //if we dont use IEnergySource i will put this
        //private float m_RemainingEnergy;
        private eVehicleStatus m_VehicleStatus;
        public List<Wheel> m_Wheels;
        private EnergySource m_EnergySource;

        //לפי הסרטון של גיא - לא כדאי לאתחל הכל, אלא רק ליצור אובייקט של כלי רכב ולאט לאט לאתחר את הנתונים
        //בהתאם לבקשות מהמשתמש. לכן צריך לשנות את כל הקונסטרקטורים
        public Vehicle(string i_ModelName,string i_LicenseNumber,EnergySource i_EnergySource, List<Wheel> i_Wheels)
        {
            //m_ModelName = i_ModelName;
            //m_LicenseNumber = i_LicenseNumber;
            //m_EnergySource = i_EnergySource;
            //m_Wheels = i_Wheels;
            //m_VehicleStatus = eVehicleStatus.InRepair;

        }

        public string ModelName
        {
            get { return m_ModelName; }
            set { m_ModelName = value; }
        }

        //public string GetModelName()
        //{
        //    return m_ModelName;
        //}

        public string LicenseNumber
        {
            get { return m_LicenseNumber; }
            set { m_LicenseNumber = value; }
        }
        //public string GetLicenseNumber()
        //{
        //    return m_LicenseNumber;
        //}

        public eVehicleStatus VehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }

        //public eVehicleStatus GeteVehicleStatus()
        //{
        //    return m_VehicleStatus;
        //}

        public void SetVehicleStatus(eVehicleStatus vehicleStatusVal)
        {
            m_VehicleStatus = vehicleStatusVal;
        }

        public EnergySource GetEnergySource()
        {
            return (EnergySource)m_EnergySource;
        }

        public List<Wheel> GetWheels()
        {
            return m_Wheels;
        }

        public void AddAirToWheel(float i_AirPressure)
        {
            foreach (Wheel wheel in m_Wheels)
            {
                wheel.AddAirPressure(i_AirPressure);
            }
        }

        public override string ToString()
        {
            string vehicleInfo = string.Format("Model: {0}\nLicense Number: {1}\nVehicle Status: {2}\n"+
                "Wheel Status: {3}\nEnergy Source: {4}"
                , m_ModelName, m_LicenseNumber, m_VehicleStatus, m_Wheels, m_EnergySource);

            return vehicleInfo;
        }




    }
}
