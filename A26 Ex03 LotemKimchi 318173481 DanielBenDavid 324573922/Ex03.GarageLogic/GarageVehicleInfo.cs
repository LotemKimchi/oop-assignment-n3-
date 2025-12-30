using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GarageVehicleInfo
    {
        private readonly Vehicle r_Vehicle;
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhone;
        private eVehicleStatus m_VehicleStatus;

        public string OwnerName
        {
            get { return r_OwnerName; }
        }

        public string OwnerPhone
        {
            get { return r_OwnerPhone; }
        }

        public eVehicleStatus VehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }

        public Vehicle Vehicle
        {
            get { return r_Vehicle; }
        }

        public GarageVehicleInfo(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhone)
        {
            r_Vehicle = i_Vehicle;
            r_OwnerName = i_OwnerName;
            r_OwnerPhone = i_OwnerPhone;
            m_VehicleStatus = eVehicleStatus.InRepair;
        }

        public override string ToString()
        {
            string vehicleInfo = string.Format("OwnerName: {0},\nOwnerNumPhone: {1},\nVehicleStatus: {2}",
                r_OwnerName, r_OwnerPhone, m_VehicleStatus);

            return vehicleInfo;
        }
    }
}
