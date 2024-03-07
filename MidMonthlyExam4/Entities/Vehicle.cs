using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Entities
{
    public abstract class Vehicle
    {
        protected Vehicle(string model, int makeYear, int numberOfgeras, int engineCapacity, VehicleType type)
        {
            Model = model;
            MakeYear = makeYear;
            NumberOfgeras = numberOfgeras;
            EngineCapacity = engineCapacity;
            Type = type;
        }
        public abstract void GetDetails();
        public abstract string Model { get; set; }
        public abstract int MakeYear { get; set; }
        public abstract int NumberOfgeras { get; set; }
        public abstract int EngineCapacity { get; set; }
        public abstract VehicleType Type { get; set; }

    }
}
