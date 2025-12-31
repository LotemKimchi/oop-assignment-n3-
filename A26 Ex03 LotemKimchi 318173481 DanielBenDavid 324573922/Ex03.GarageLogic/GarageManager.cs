using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private Dictionary<string, GarageVehicleInfo> m_Vehicles;
        public GarageManager() 
        {
            m_Vehicles = new Dictionary<string, GarageVehicleInfo>();
        }

        public bool ContainVehcile(string i_LicenseNumber)
        {
            return m_Vehicles.ContainsKey(i_LicenseNumber);
        }

        public void AddVehicle(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhone)
        {
            string licenseNumber = i_Vehicle.LicenseNumber;

            if (m_Vehicles.ContainsKey(licenseNumber))
            {
                throw new ArgumentException("Vehicle is already exist");
            }

            GarageVehicleInfo garageVehicleInfo = new GarageVehicleInfo(i_Vehicle, i_OwnerName, i_OwnerPhone);

            m_Vehicles.Add(licenseNumber, garageVehicleInfo);
        }
        
        
        public GarageVehicleInfo GetVehicleInfo(string i_LicenseNumber)
        {
            if (!m_Vehicles.ContainsKey(i_LicenseNumber))
            {
                throw new ArgumentException("Vehicle with current license number dosn't exist");
            }

            return m_Vehicles[i_LicenseNumber];
        }

        public List<string> GetLicenseVehicles()
        {
            return new List<string>(m_Vehicles.Keys);
        }

        public void loadVehiclesFromFile(string i_File)
        {
            string[] lines = File.ReadAllLines(i_File);

            foreach (string line in lines)
            {
                if(string.IsNullOrWhiteSpace(line)){
                    continue;
                }

                if (line.StartsWith("****"))
                {
                    break;
                }

                string[] partsInLine = line.Split(',');

                if(partsInLine.Length < 9)
                {
                    throw new FormatException("Invalid line: not enough part in line");
                }

                string vehicleTypeFromFile = partsInLine[0].Trim();
                string licenseNumber = partsInLine[1].Trim();
                string modelName = partsInLine[2].Trim();

                float energyPercent = float.Parse(partsInLine[3].Trim());
                string manufacturerName = partsInLine[4].Trim();
                float wheelCurrentAir = float.Parse(partsInLine[5].Trim());

                string ownerName = partsInLine[6].Trim();
                string ownerPhone = partsInLine[7].Trim();

                if (vehicleTypeFromFile.Trim() == "Truck")
                {
                    vehicleTypeFromFile = "FuelTruck";
                }

                Vehicle vehicle = VehicleCreator.CreateVehicle(vehicleTypeFromFile, licenseNumber, modelName);

                if (vehicle == null)
                {
                    throw new ArgumentException("Wrong VehicleType");
                }

                int numberOfWheels;
                float maxAirPressure;

                GetWheelDefaultData(vehicleTypeFromFile, out numberOfWheels, out maxAirPressure);
                vehicle.InitializeWheels(manufacturerName, wheelCurrentAir, maxAirPressure, numberOfWheels);

                if (energyPercent < 0f || energyPercent > 100f)
                {
                    throw new ValueRangeException(0, 100);
                }

                float maxEnergy = vehicle.EnergySource.MaxEnergy;
                float desiredCurrent = (maxEnergy * energyPercent) / 100f;

                vehicle.EnergySource.AddEnergy(desiredCurrent);

                FillSpecificFieldsForEachVehicle(vehicleTypeFromFile, vehicle, partsInLine);

                GarageVehicleInfo garageVehicleInfo = new GarageVehicleInfo(vehicle, ownerName, ownerPhone);

                if (m_Vehicles.ContainsKey(licenseNumber))
                {
                    throw new ArgumentException("This car is already exist");
                }

                m_Vehicles.Add(licenseNumber, garageVehicleInfo);

            }
        }

        private static void GetWheelDefaultData(string i_VehicleType, out int o_NumOfWheels,out float o_MaxWheelPressure)
        {
            switch(i_VehicleType)
            {
                case "FuelMotorcycle":
                    o_NumOfWheels = FuelMotorcycle.NumberOfWheels;
                    o_MaxWheelPressure = FuelMotorcycle.MaxWheelAirPressure;
                    break;

                case "ElectricMotorcycle":
                    o_NumOfWheels = ElectricMotorcycle.NumberOfWheels;
                    o_MaxWheelPressure = ElectricMotorcycle.MaxWheelAirPressure;
                    break;

                case "FuelCar":
                    o_NumOfWheels = FuelCar.NumberOfWheels;
                    o_MaxWheelPressure = FuelCar.MaxWheelAirPressure;
                    break;

                case "ElectricCar":
                    o_NumOfWheels = ElectricCar.NumberOfWheels;
                    o_MaxWheelPressure = ElectricCar.MaxWheelAirPressure;
                    break;

                case "FuelTruck":
                    o_NumOfWheels = FuelTruck.NumberOfWheels;
                    o_MaxWheelPressure = FuelTruck.MaxWheelAirPressure;
                    break;

                default:
                    throw new ArgumentException("All the Vehicle type not match to:" +  i_VehicleType);
            }
        }

        public static void FillSpecificFieldsForEachVehicle(string i_VehicleType, Vehicle i_Vehicle, string[] i_FieldToFill)
        {
            switch (i_VehicleType)
            {
                case "FuelMotorcycle":
                case "ElectricMotorcycle":
                    Motorcycle motorcycle = (Motorcycle)i_Vehicle;
                    motorcycle.LicenseType = (eLicenseType)Enum.Parse(typeof(eLicenseType), i_FieldToFill[8]);
                    motorcycle.EngineVolumeCc = int.Parse(i_FieldToFill[9].Trim());
                    break;

                case "FuelCar":
                case "ElectricCar":
                    Car car = (Car)i_Vehicle;
                    car.CarColor = (eCarColor)Enum.Parse(typeof(eCarColor), i_FieldToFill[8].Trim());
                    car.NumOfDoors = (eNumOfDoors)int.Parse(i_FieldToFill[9].Trim());
                    break;

                case "FuelTruck":
                    Truck truck = (Truck)i_Vehicle;
                    truck.IsCarryingHazardousMaterials = bool.Parse(i_FieldToFill[8]);
                    truck.CargoVolume = float.Parse(i_FieldToFill[9]);

                    break;

                default:
                    throw new ArgumentException("All the Vehicle type not match to:" + i_VehicleType);
            }

        }
       

        public void insertVewVehicle()
        {

        }

    //    public void showLicenseNumbers()
    //    {
    //        //do list for vehicle status
    //        Vehicle List<vehicle> vehiclInRepair;
    //        Vehicle List<vehicle> vehiclFixes;
    //        Vehicle List<vehicle> vehiclPaid;

    //        //foreach( Dictionary<string, Vehicle> keyValuesVehicle in m_Vehicles)
    //        foreach( Dictionary<string, Vehicle> keyValuesVehicle in m_Vehicles)
    //        {
    //            if (keyValuesVehicle.VehicleStatus == eVehicleStatus.InRepair)
    //            {
    //                vehiclInRepair.add(keyValuesVehicle);
    //            }
    //            if (keyValuesVehicle.VehicleStatus == eVehicleStatus.Fixed)
    //            {
    //                vehiclInRepair.add(keyValuesVehicle);
    //            }
    //            if (keyValuesVehicle.VehicleStatus == eVehicleStatus.Paid)
    //            {
    //                vehiclInRepair.add(keyValuesVehicle);
    //            }
    //        }

    //        Console.WriteLine("Vehicle In Repair: {0}\nFixed vehicle: {1}\n,Vehicle on Paid:{2}",
    //            vehiclInRepair, vehiclFixes, vehiclPaid)
    //    }

    //    public bool ChangeVehicleStatus(string i_LicenseNumber, eVehicleStatus i_DesireStatus)
    //    {
    //        if (m_Vehicles.ContainsKey(i_LicenseNumber).VehicleStatus(i_DesireStatus))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public bool ChangeAirWheelToMax(string i_LicenseNumber)
    //    {
    //        m_Vehicles.ContainsKey(i_LicenseNumber).WheelsAirPressureToMax(i_LicenseNumber);
    //        //WheelsAirPressureToMax(i_LicenseNumber)
    //    }

    //    public void ChangeFuelInVehicle(string i_LicenseNumber, eFuelType i_FuelDesireType, float i_FuelQuantity)
    //    {

    //    }
    }
}
