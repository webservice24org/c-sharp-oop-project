using MidMonthlyExam4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========== Mid Monthly Exam 4 =============");
                Console.WriteLine();
                Console.WriteLine("=========== 1280860 Mohiuddin =============");
                Console.WriteLine();
                DoTask();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many operation would you like to perform?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter type of operation\nHint \nTwoWheeler -1\nFourWheeler -2 ");
                int operationType = Convert.ToInt32(Console.ReadLine());
                if (operationType == 1)
                {
                    GetMotorCycleInfo();
                }
                else if (operationType == 2)
                {
                    GetcarInfo();
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }
            }

        }

        private static void GetcarInfo()
        {
            Car<Vehicle> car = new Car<Vehicle>("BMW", 2000, 10, 900, VehicleType.Personal, 4, 4);
            car.GetDetails();
            car.GetDesign();
            string[] designs = car.GetInteriordesins<Vehicle>("TissueBox,AirFreshener, Pillow");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + " " + designs[i]);
            }
        }

        private static void GetMotorCycleInfo()
        {
            MotorCycle<Vehicle> cycle = new MotorCycle<Vehicle>("Yamaha", 2022, 5, 149, VehicleType.Personal, 14.8, 27.5, 40, "disk", "disk");
            cycle.GetDetails();
            cycle.Start();
            cycle.cooling();
            string[] designs = cycle.GetExteriorDesigns<Vehicle>("Sticker, LightHorn, FoggLight");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + " " + designs[i]);
            }
        }
    }
}
