using APBD_2_s21147.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    internal class GasContainer(double cargoWeight, double height, double containerMass, double depth, double maxLoad, double pressure) : Container('G', cargoWeight, height, containerMass, depth, maxLoad), IHazardNotifier
    {
        public override void EmptyContainer()
        {
            double remaining = cargoWeight * 0.05;
            base.EmptyContainer();
            cargoWeight = remaining;
        }

        public override void AddCargo(double weight)
        {
            base.AddCargo(weight);
        }
        public void DangerousSituation()
        {
            Console.WriteLine($"Dangerous operation with container: {serialNumber}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, pressure: {pressure}";
        }
    }
}
