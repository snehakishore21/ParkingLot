using ParkingLot.Models;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            IParkingLotManager manager2Wheeler = ParkingLotManagerCreater.CreateParkingLotManager(VehicleType.Wheeler_2);
            IParkingLotManager manager4wheeler = ParkingLotManagerCreater.CreateParkingLotManager(VehicleType.Wheeler_4);

            manager2Wheeler.AddParkingSlot(new Parking2Wheeler("1"));

        }
    }
}