using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLotManagerCreater
    {
        public static IParkingLotManager CreateParkingLotManager(VehicleType vehicleType)
        {
            IParkingLotManager parkingLotManager;
            switch(vehicleType)
            {
                case VehicleType.Wheeler_2:
                    parkingLotManager = new ParkingLot2WheelerManager(new Dictionary<string, ParkingSlot>());
                    break;
                case VehicleType.Wheeler_4:
                    parkingLotManager = new ParkingLot4WheelerManager(new Dictionary<string, ParkingSlot>());
                    break;
                default:
                    parkingLotManager = new ParkingLotDefaultManager(new Dictionary<string, ParkingSlot>());
                    break;
            }
            return parkingLotManager;
        }
    }

    public interface IParkingLotManager
    {
        public void AddParkingSlot(ParkingSlot parkingSlot);
        public ParkingSlot CheckandGetAvailableSlots();
    }

    public class ParkingLotDefaultManager : IParkingLotManager
    {
        public static Dictionary<string, ParkingSlot> parkingSlots2Wheeler = new Dictionary<string, ParkingSlot>();
        public ParkingLotDefaultManager(Dictionary<string, ParkingSlot> parkingSlotsInput)
        {
            parkingSlots2Wheeler = parkingSlotsInput;
        }

        public void AddParkingSlot(ParkingSlot parkingSlot)
        {
            parkingSlots2Wheeler.Add(parkingSlot.SlotId, parkingSlot);
        }
        public ParkingSlot CheckandGetAvailableSlots()
        {
            foreach (ParkingSlot parkingSlot in parkingSlots2Wheeler.Values)
            {
                if (parkingSlot.IsAvailable())
                {
                    return parkingSlot;
                }
            }
            throw new Exception("Slot Not Available");
        }
    }


    public class ParkingLot2WheelerManager : IParkingLotManager
    {
        public static Dictionary<string, ParkingSlot> parkingSlots2Wheeler = new Dictionary<string, ParkingSlot>();
        public ParkingLot2WheelerManager(Dictionary<string, ParkingSlot> parkingSlotsInput)
        {
            ParkingLotUtils.ParkingLotManager2Wheeler = this;
            parkingSlots2Wheeler = parkingSlotsInput;
        }

        public void AddParkingSlot(ParkingSlot parkingSlot)
        {
            parkingSlots2Wheeler.Add(parkingSlot.SlotId, parkingSlot);
        }
        public ParkingSlot CheckandGetAvailableSlots()
        {
            foreach(ParkingSlot parkingSlot in parkingSlots2Wheeler.Values)
            {
                if(parkingSlot.IsAvailable())
                {
                    return parkingSlot;
                }
            }
            throw new Exception("Slot Not Available for 2 Wheeler");
        }
    }

    public class ParkingLot4WheelerManager : IParkingLotManager
    {
        Dictionary<string, ParkingSlot> parkingSlots4Wheeler = new Dictionary<string, ParkingSlot>();
        public ParkingLot4WheelerManager(Dictionary<string, ParkingSlot> parkingSlotsInput)
        {
            ParkingLotUtils.ParkingLotManager4Wheeler = this;
            parkingSlots4Wheeler = parkingSlotsInput;
        }
        public void AddParkingSlot(ParkingSlot parkingSlot)
        {
            parkingSlots4Wheeler.Add(parkingSlot.SlotId, parkingSlot);
        }

        public ParkingSlot CheckandGetAvailableSlots()
        {
            foreach (ParkingSlot parkingSlot in parkingSlots4Wheeler.Values)
            {
                if (parkingSlot.IsAvailable())
                {
                    return parkingSlot;
                }
            }
            throw new Exception("Slot Not Available for 4 Wheeler");
        }
    }
}
