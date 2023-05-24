
using ParkingLots.Entities;


CarParking parking = new CarParking();

for(int i = 0; i < 10; i++)
{
   ParkingSpot parkingSpot = new ParkingSpot(i + 1);
   parking.ParkingSpots.Add(parkingSpot);            
}

Console.Write("Qual o tipo do veiculo?  ");
string typeVehicle = Console.ReadLine();

Console.Write("Informe a placa: ");
string plateNumber = Console.ReadLine();

Vehicle v = new Vehicle(typeVehicle, plateNumber);

Console.WriteLine("Em qual vaga gostaria de adiciona-lo?");
int n = int .Parse(Console.ReadLine());


