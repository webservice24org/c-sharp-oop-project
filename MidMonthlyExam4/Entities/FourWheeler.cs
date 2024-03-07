using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Entities
{
    public class FourWheeler<T> : Vehicle, Interfaces.IInteriorDesign<T>
    {
        public FourWheeler(string model, int makeYear, int numberOfgeras, int engineCapacity, VehicleType type) : base(model, makeYear, numberOfgeras, engineCapacity, type)
        {
        }
        public override string Model { get; set; }
        public override int MakeYear { get; set; }
        public override int NumberOfgeras { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("abstract method overriden in four wheeler");
        }


        public virtual void GetDesign()
        {
            Console.WriteLine("I'm in virtual method");
        }

        public string[] GetInteriordesins<T>(string data)
        {
            string[] designs = data.Split(',');
            return designs;
        }

    }
}
