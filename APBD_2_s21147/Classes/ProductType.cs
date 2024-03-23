using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    internal class ProductType(string name, double minTemperature)
    {
        public string name { get; private set; } = name;
        public double minTemperature { get; private set;}=minTemperature;
    }
}
