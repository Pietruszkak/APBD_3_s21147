using APBD_2_s21147.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    enum LiquidType
    {
        Dangerous,
        Normal
    }
    internal class LiquidContainer(double cargoWeight, double height, double containerMass, double depth, double maxLoad, LiquidType liquidType) : Container('L', cargoWeight, height, containerMass, depth, maxLoad), IHazardNotifier
    {
        public override void AddCargo(double weight)
        {

            switch (liquidType)
            {
                case LiquidType.Dangerous:
                    if ((cargoWeight + weight) > (maxLoad * 0.5))
                    {
                        DangerousSituation();
                    }
                    else
                    {
                        base.AddCargo(weight);
                    }
                    break;
                case LiquidType.Normal:
                    if ((cargoWeight + weight) > (maxLoad * 0.8))
                    {
                        DangerousSituation();
                    }
                    else
                    {
                        base.AddCargo(weight);
                    }
                    break;
                default:
                    Console.WriteLine("Unknown type");
                    break;
            }
        }

        public void DangerousSituation()
        {
            Console.WriteLine($"Dangerous operation with container: {serialNumber}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, liquidType: {liquidType}";
        }
    }
}
