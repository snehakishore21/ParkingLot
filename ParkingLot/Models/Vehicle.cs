using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public enum VehicleType
    {
        Wheeler_4,
        Wheeler_2
    }

    public class Vehicle
    {
        private VehicleType type;
        public VehicleType Type { get => type; private set => type = value; }

        private Ticket ticket;

        public Ticket Ticket { get => ticket; private set => ticket = value; }

        private string vehicleId = string.Empty;

        public string VehicleId { get => vehicleId; private set => vehicleId = value; }

        public Vehicle(VehicleType type, string id)
        {
            this.Type = type;
            this.VehicleId = id;
        }
        public void SetTicket(Ticket ticket)
        {
            this.Ticket = ticket;
        }
    }

    public class Vehicle2Wheeler : Vehicle
    {
        public Vehicle2Wheeler(string id) : base(VehicleType.Wheeler_2, id)
        {
        }
    }

    public class Vehicle4Wheeler : Vehicle
    {
        public Vehicle4Wheeler(string id) : base(VehicleType.Wheeler_4, id)
        {
        }
    }
}
