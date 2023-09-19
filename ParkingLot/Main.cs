using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLotUtils
    {
        public static IParkingLotManager ParkingLotManager2Wheeler;
        public static IParkingLotManager ParkingLotManager4Wheeler;

        public static IParkingLotManager GetParkingLot(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Wheeler_2:
                    return ParkingLotManager2Wheeler;
                case VehicleType.Wheeler_4:
                    return ParkingLotManager4Wheeler;
                default:
                    return null;
            }
        }
    }

}
