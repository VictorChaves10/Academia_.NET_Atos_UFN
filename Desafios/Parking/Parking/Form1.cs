using Parking.Entities;
using Parking.Entities.Enums;
using System.Windows.Forms;

namespace Parking
{
    public partial class Parking : Form
    {
        List<ParkingSpot> parkingSpots = new List<ParkingSpot>();

        internal bool CheckNumberPlate(Vehicle vehicle)
        {
            bool n = true;
            foreach (ParkingSpot obj in parkingSpots)
            {
                if (obj.Vehicle.NumberPlate == vehicle.NumberPlate)
                {
                    n = false;
                    break;
                }
                else
                {
                    n = true;
                }
            }
            return n;
        }
        public bool CheckParkingAvailability(int x)
        {
            bool n = true;

            foreach (ParkingSpot obj in parkingSpots)
            {
                if (obj.Id == x)
                {
                    if(obj.Status == Availability.Available)
                    {
                        n = true;
                        break;
                    }                  
                }
                else
                {
                    n = false;
                }
            }
            return n;
        }

        public Parking()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                ParkingSpot parkingSpot = new ParkingSpot(i + 1);
                parkingSpots.Add(parkingSpot);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(cbxParkingSpace.Text);
            Vehicle vehicle = new Vehicle(cbxVehicleType.Text, txbNumberPlate.Text);
            
            if(CheckParkingAvailability(n) == false)
            {
                MessageBox.Show("The spot is already taken by a vehicle", "Registration status", MessageBoxButtons.OK);
            }
            else if (CheckNumberPlate(vehicle) == false)
            {
                MessageBox.Show($"The vehicle is already occupying a spot", "Registration status", MessageBoxButtons.OK);
            }
            else
            {
                foreach (ParkingSpot obj in parkingSpots)
                {
                    if(obj.Id == n)
                    {
                        obj.AddVehicle(vehicle);
                        MessageBox.Show("Vehicle successfully registered", "Registration status", MessageBoxButtons.OK);
                        txbNumberPlate.Clear();
                        cbxParkingSpace.SelectedIndex= -1;
                        cbxVehicleType.SelectedIndex= -1;
                    }
                }
            }        
          
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}