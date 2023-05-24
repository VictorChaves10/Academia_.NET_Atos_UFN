using Parking.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLots.Entities
{
    internal class ParkingSpot
    {
        public int NumberParkingSpot { get; set; }
        public DateTime EntryTime { get; set; }
        public Vehicle Vehicle { get; set; } = new Vehicle();
        public DateTime ExitTime { get; set; }
        public int TimeOfPermanency { get; set; }
        public Availability Status { get; set; } = Enum.Parse<Availability>("Available");


        public ParkingSpot() { }

        public ParkingSpot(int numberParkingSpot)
        {
            NumberParkingSpot = numberParkingSpot;    
        }
        public void AddVehicle(Vehicle vehicle)
        {
            EntryTime = DateTime.Now.ToLocalTime();
            Vehicle = vehicle;
            Status = Enum.Parse<Availability>("Available");
        }


        public void RemoveVehicle()
        {
            ExitTime = DateTime.Now.ToLocalTime();
            Vehicle = null;
            Status = Enum.Parse<Availability>("Available");
        }

        public void TimePermanency()
        {
            TimeSpan t = ExitTime.Subtract(EntryTime);
            TimeOfPermanency = t.Minutes;
        }

        public double PricePerPeriod()
        {
            double pricePerPeriod = 0;
            int n = TimeOfPermanency;

            if (n <= 780 && n > 60)
            {
                pricePerPeriod = (n / 60) * 5.00;
            }
            else if (n > 780)
            {
                pricePerPeriod = 5.00 * (780 / 60);
                double x = n - 780;

                if (x > 60)
                {
                    pricePerPeriod = (int)Math.Ceiling(x / 60) * 5.00;
                }
                else
                {
                    pricePerPeriod += 5.00;
                }

            }
            else
            {
                pricePerPeriod = 5.00;
            }

            return pricePerPeriod;
        }


    }
}
