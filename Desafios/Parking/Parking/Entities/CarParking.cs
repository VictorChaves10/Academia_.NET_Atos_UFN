using Parking.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLots.Entities
{
    internal class CarParking
    {
        public List<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();

        public CarParking() { }

        public void AddVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpot obj in ParkingSpots)
            {
                if(obj.Vehicle.NumberPlate != vehicle.NumberPlate && CheckParkingAvailability())
                {
                    obj.AddVehicle(vehicle);
                }
            }                               
        }
        public bool CheckParkingAvailability()
        {
            bool n = true;
            foreach (ParkingSpot obj in ParkingSpots)
            {
                if (obj.Status == Availability.Available)
                {
                    n = true;
                    break;
                }
                else
                {
                    n = false;
                }
            }
            return n;
        } 


    }
}
