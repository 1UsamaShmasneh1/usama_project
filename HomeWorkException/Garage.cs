using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class Garage : IGarage
    {
        private static Car[] cars = new Car[5];
        public static Car[] Cars { get; set; }
        private static string[] carTypes;
        public string CarType { get; set; }
        public Garage()
        {
            
        }
        public Garage(string[] _carTypes)
        {
            carTypes = _carTypes;
        }
        public void AddCar(Car car)
        {
            if (Array.IndexOf(cars, car) != -1)
            {
                throw new CarAlreadyHereException("Car already here");
            }
            else if (car.TotalLost)
            {
                throw new WeDoNotFixTotalLostException("we can't fix total lost cars");
            }
            else if (Array.IndexOf(carTypes, car.Brand) == -1)
            {
                throw new WrongGarageException("Wrong garage");
            }
            else if (car == null)
            {
                throw new CarNullException("the car is null");
            }
            else if (!car.NeedsRepair)
            {
                throw new RepairMismatchException("no need to repair");
            }
            else
            {
                foreach (Car c in cars)
                {
                    if(c == null)
                    {
                        cars[Array.IndexOf(cars, c)] = car;
                    }
                    else
                    {
                        throw new NoMoreRangInGarage("no more range in the garage");
                    }
                }
            }
        }

        public void FixCar(Car car)
        {
            if(car == null)
            {
                throw new CarNullException("the car is null");
            }
            else if (Array.IndexOf(cars, car) == -1)
            {
                throw new CarNotInGarageException("the car not in the garage");
            }
            else if (!car.NeedsRepair)
            {
                throw new RepairMismatchException("the car not need to fix");
            }
            else
            {
                car.NeedsRepair = false;
            }
        }

        public void GetOutCar(Car car)
        {
            if(car == null)
            {
                throw new CarNullException("cars is null");
            }
            else if(Array.IndexOf(cars, car) == -1)
            {
                throw new CarNotInGarageException("the car not in the garage");
            }
            else if (car.NeedsRepair)
            {
                throw new CarNotReadyException("the car not ready");
            }
            foreach (Car c in cars)
            {
                if (c == car)
                {
                    cars[Array.IndexOf(cars, c)] = null;
                }                
            }
        }
    }
}
