using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Entities
{
    public class TwoWheeler<T> : Vehicle, Interfaces.IExteriorDesign<T> where T : Vehicle
    {
        public TwoWheeler(string model, int makeYear, int numberOfgeras, int engineCapacity, VehicleType type) : base(model, makeYear, numberOfgeras, engineCapacity, type)
        { }

        public override string Model { get; set; }
        public override int MakeYear { get; set; }
        public override int NumberOfgeras { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("abstract method overriden in two wheeler");
        }

        public string[] GetExteriorDesigns<T>(string data) where T : Vehicle
        {
            string[] designs = data.Split(',');
            return designs;
        }
        public virtual void Start()
        {
            Console.WriteLine("I'm in virtual method");
        }
    }
}
