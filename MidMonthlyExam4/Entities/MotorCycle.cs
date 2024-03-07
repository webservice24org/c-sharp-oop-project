using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Entities
{
    public sealed class MotorCycle<T> : TwoWheeler<T> where T : Vehicle
    {
        double maxPowerinBPH;
        double maxTorqueinNM;
        int milageInKMPL;
        string frontBreak;
        string rearBreak;

        public double MaxPowerinBPH { get => maxPowerinBPH; set => maxPowerinBPH = value; }
        public double MaxTorqueinNM { get => maxTorqueinNM; set => maxTorqueinNM = value; }
        public int MilageInKMPL { get => milageInKMPL; set => milageInKMPL = value; }
        public string FrontBreak { get => frontBreak; set => frontBreak = value; }
        public string RearBreak { get => rearBreak; set => rearBreak = value; }

        public MotorCycle(string model, int makeYear, int numberOfgeras, int engineCapacity, VehicleType type, double maxPowerinBPH, double maxTorqueinNM, int milageInKMPL, string frontBreak, string rearBreak) : base(model, makeYear, numberOfgeras, engineCapacity, type)
        {
            this.MaxPowerinBPH = maxPowerinBPH;
            this.MaxTorqueinNM = maxTorqueinNM;
            this.MilageInKMPL = milageInKMPL;
            this.FrontBreak = frontBreak;
            this.RearBreak = rearBreak;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Model {Model}\nMake Year {MakeYear}\nMaximum Power {maxPowerinBPH}\nMaximum Power Torque{maxTorqueinNM}\nMilage {milageInKMPL}\nEngine Capacity {EngineCapacity}\nNumber of Gear {NumberOfgeras}\nForn Break {frontBreak}\nRear Break {rearBreak}\nVehicle Type {Type}");
        }
        public override void Start()
        {
            Console.WriteLine("Brahm....");
        }
        public void cooling()
        {
            Console.WriteLine("Cooling.....");
        }
    }
}
