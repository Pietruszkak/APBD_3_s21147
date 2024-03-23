using APBD_2_s21147.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Classes
{
    internal class ContainerShip(double maxSpeed,int maxContainerCount, double maxWeightInTon)
    {
        public double maxSpeed { get; private set; } = maxSpeed;
        public int maxContainerCount { get; private set;}=maxContainerCount;
        public double maxWeightInTon { get; private set; }=maxWeightInTon;
        public List<Container> containers { get; private set; }= new List<Container>();

        public void addContainer(Container container)
        {
            double currentWeightinKg = containers.Sum(obj => obj.cargoWeight) + containers.Sum(obj => obj.containerMass);

            if((currentWeightinKg+container.containerMass+container.cargoWeight)/1000>maxWeightInTon)
            {
                throw new OverfillException("ContainerShip overfilled");
            }
            if(containers.Count==maxContainerCount)
            {
                throw new OverfillException("ContainerShip overfilled");
            }
            if (!containers.Contains(container))
            {
                containers.Add(container);
            }
        }
        public void addContainerList(List<Container> containersToAdd)
        {
            double currentWeightinKg = containers.Sum(obj => obj.cargoWeight + obj.containerMass);

            double weightToAddinKg = containersToAdd.Sum(obj => obj.cargoWeight + obj.containerMass);

            if ((currentWeightinKg + weightToAddinKg) / 1000 > maxWeightInTon)
            {
                throw new OverfillException("ContainerShip overfilled");
            }
            if (containers.Count+containersToAdd.Count > maxContainerCount)
            {
                throw new OverfillException("ContainerShip overfilled");
            }
            if (!containers.Intersect(containersToAdd).Any())
            {
                containers.AddRange(containersToAdd);
            }
        }
        public void removeContainer(Container container)
        {
            if(containers.Contains(container))
            {
                containers.Remove(container);
            }
        }
        public void replaceContainer(string serialNumber, Container container)
        {
            try
            {
                Container tmp = containers.Find(obj => obj.serialNumber == serialNumber);
                if (tmp != null)
                {
                    containers.Remove(tmp);
                    containers.Add(container);
                }
            } catch (ArgumentNullException ex) {};
        }
        public void moveToAnotherShip(Container container, ContainerShip ship)
        {
            if(ship!=null)
            {
                containers.Remove(container);
                ship.containers.Add(container);
            }
        }
        public override string ToString()
        {
            string tmpContainers = string.Join("\n", containers);
            return $"[{GetType().Name}] -- maxSpeed: {maxSpeed}, maxContainerCount: {maxContainerCount}, maxWeightInTon: {maxWeightInTon}, Containers: \n--\n{tmpContainers}\n--"; 
        }
    }
}
