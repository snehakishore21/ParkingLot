using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Strategy
{
    public class PriceComputationStrategyCreator
    {
        public static IPriceComputationStrategy GetPriceComputationStrategy(VehicleType vehicleType)
        {
            if(vehicleType == VehicleType.Wheeler_4)
            {
                PriceComputation4WheelerStrategy strategy = new PriceComputation4WheelerStrategy();
                return strategy;
            }
            else if(vehicleType == VehicleType.Wheeler_2)
            {
                PriceComputation2WheelerStrategy strategy = new PriceComputation2WheelerStrategy();
                return strategy;
            }
            else
            {
                PriceComputationDefault strategy = new PriceComputationDefault();
                return strategy;
            }
        }
    }

    public interface IPriceComputationStrategy
    {
        public int GetPrice();
    }

    public class PriceComputationDefault : IPriceComputationStrategy
    {
        public int GetPrice()
        {
            return 20;
        }
    }

    public class PriceComputation2WheelerStrategy:IPriceComputationStrategy
    {
        public int GetPrice()
        {
            return 40;
        }
    }

    public class PriceComputation4WheelerStrategy: IPriceComputationStrategy
    {
        public int GetPrice()
        {
            return 60;
        }
    }
}
