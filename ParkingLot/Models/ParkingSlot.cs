using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public enum ParkingLotType
    {
        Wheeler_4,
        Wheeler_2
    }

    public class ParkingSlot
    {
        private ParkingLotType type;
        public ParkingLotType Type { get => type; private set => type = value; }

        private bool isAvailable = true;

        private string slotNumber = string.Empty;

        public string SlotId { get => slotNumber; private set => slotNumber = value; }

        private string vehicleId = string.Empty;

        public string VehicleId { get => vehicleId; private set => vehicleId = value; }

        public ParkingSlot(string slotId, ParkingLotType type)
        {
            this.Type = type;
            this.SlotId = slotId;
        }
        public void Park(string vehicleId)
        {
            this.VehicleId = vehicleId;
            isAvailable = false;
        }

        public void RemovePark()
        {
            isAvailable = true;
            this.VehicleId = string.Empty;
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }

    }

    public class Parking2Wheeler : ParkingSlot
    {
        public Parking2Wheeler(string slotId) : base(slotId, ParkingLotType.Wheeler_2)
        {
        }
    }

    public class Parking4Wheeler : ParkingSlot
    {
        public Parking4Wheeler(string slotId) : base(slotId, ParkingLotType.Wheeler_4)
        {
        }
    }
}
