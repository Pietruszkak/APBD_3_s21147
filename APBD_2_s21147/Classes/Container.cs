using APBD_2_s21147.Exceptions;
using APBD_2_s21147.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    internal abstract class Container(char containerType, double cargoWeight, double height, double containerMass, double depth, double maxLoad) : ICargoContainer
    {
        private static int _next_Id = 0;

        public string serialNumber { get; } = "KON-" + containerType + "-" + _next_Id++;
        public double cargoWeight { get; protected set; } = cargoWeight;
        public double height { get; private set; } = height;
        public double containerMass { get; private set; } = containerMass;
        public double depth { get; private set; } = depth;
        public double maxLoad { get; private set; } = maxLoad;

        public virtual void EmptyContainer()
        {
            cargoWeight = 0;
        }
        public virtual void AddCargo(double weight)
        {
            if ((cargoWeight + weight)>maxLoad)
            {
                throw new OverfillException("Container overfilled");
            }
            cargoWeight += weight;

        }
        public virtual void AddCargo(double weight, ProductType productType)
        {
            if ((cargoWeight + weight) > maxLoad)
            {
                throw new OverfillException("Container overfilled");
            }
            cargoWeight += weight;

        }
        public override string ToString()
        {
            return $"[{GetType().Name}] -- serialNumber: {serialNumber}, cargoWeight: {cargoWeight}, height: {height}, containerMass: {containerMass}, depth: {depth}, maxLoad: {maxLoad}";
        }
    }
}
