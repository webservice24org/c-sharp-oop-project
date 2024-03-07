using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Entities
{
    public sealed class Car<T> : FourWheeler<T>
    {
        int numberOfSeat;
        int numberOfDoor;

        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor = value; }

        public Car(string model, int makeYear, int numberOfgeras, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfDoor) : base(model, makeYear, numberOfgeras, engineCapacity, type)
        {
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoor = numberOfDoor;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Model {Model}\nMake Year {MakeYear}\nEngine Capacity {EngineCapacity}\nNumber of Gear {NumberOfgeras}\nVehicle Type {Type}\nNumber of seat {numberOfSeat}\nNumbert Of Door {numberOfDoor}");
        }
        public override void GetDesign()
        {
            Console.WriteLine("Good design...");
        }
    }
}
