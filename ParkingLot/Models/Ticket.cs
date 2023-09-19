using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class Ticket
    {
        public int entryTime { get; private set; }

        public int exitTime { get; private set; }

        public string vehicleId { get; private set; }

        public string ticketId { get; private set; }


        public ParkingSlot parkingLot { get; private set; }

        public Ticket(int entryTime, string vehicleId, string ticketId, ParkingSlot parkingLot)
        {
            this.entryTime = entryTime;
            this.vehicleId = vehicleId;
            this.ticketId = ticketId;
            this.parkingLot = parkingLot;
        }

        public void CloseTicketSetExitTime(int exitTime)
        {
            this.exitTime = exitTime;
            this.vehicleId = string.Empty;
        }
    }
}
