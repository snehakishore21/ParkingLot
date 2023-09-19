using ParkingLot.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class ExitGate
    {
        public string exitGateId { get; private set; }

        public ExitGate(string id)
        {
            this.exitGateId = id;
        }

        public void ExitVehicle(Vehicle vehicle, IPriceComputationStrategy strategy)
        {
            int price = strategy.GetPrice();

            //Pay using required strategy 

            IParkingLotManager lotmanager = ParkingLotUtils.GetParkingLot(vehicle.Type);
            ParkingSlot slot = lotmanager.CheckandGetAvailableSlots();
            slot.RemovePark();
            vehicle.Ticket.CloseTicketSetExitTime(DateTime.Now.Hour);
        }
    }
}
