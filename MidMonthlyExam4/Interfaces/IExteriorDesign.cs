using MidMonthlyExam4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMonthlyExam4.Interfaces
{
    public interface IExteriorDesign<T> where T : Vehicle
    {
        string[] GetExteriorDesigns<T>(string data) where T : Vehicle;
    }
}
