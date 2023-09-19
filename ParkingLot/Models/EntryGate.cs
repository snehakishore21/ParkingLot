using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class EntryGate
    {
        public string id { get; private set; } 
        public EntryGate(string id)
        {
            this.id = id;
        }

        public Ticket GetTicket(Vehicle vehicle)
        {
            IParkingLotManager lotmanager = ParkingLotUtils.GetParkingLot(vehicle.Type);
            ParkingSlot slot = lotmanager.CheckandGetAvailableSlots();
            slot.Park(vehicle.VehicleId);
            Ticket ticket = new Ticket(DateTime.Now.Second, vehicle.VehicleId, Guid.NewGuid().ToString(), slot);
            vehicle.SetTicket(ticket);
            return ticket;
        }
    }
}
