using APBD_2_s21147.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    internal class CoolingContainer(double cargoWeight, double height, double containerMass, double depth, double maxLoad, ProductType productType, double temperature) : Container('C', cargoWeight, height, containerMass, depth, maxLoad)
    {
        public override void AddCargo(double weight, ProductType productType1)
        {
            if(productType.name!=productType1.name)
            {
                throw new WrongProductTypeException("Wrong product type");
            }
            if(temperature>productType1.minTemperature)
            {
                throw new WrongTemperatureException("Container temperature is higher than minimum temperature needed for the product");
            }
            base.AddCargo(weight, productType1);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, productType: {productType.name}, minTemperature: {productType.minTemperature}, temperature: {temperature}";
        }
    }
}
