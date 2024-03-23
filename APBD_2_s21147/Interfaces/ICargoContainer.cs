using APBD_2_s21147.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Interfaces
{
    internal interface ICargoContainer
    {
        void EmptyContainer();
        void AddCargo(double weight);
        void AddCargo(double weight, ProductType productType);
    }
}
