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
            try
            {
                if (Array.IndexOf(cars, car) != -1)
                {
                    throw new CarAlreadyHereException("Car already here");
                }
            }
            catch (CarAlreadyHereException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (car.TotalLost)
                {
                    throw new WeDoNotFixTotalLostException("we can't fix total lost cars");
                }
            }
            catch (WeDoNotFixTotalLostException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (Array.IndexOf(carTypes, car.Brand) == -1)
                {
                    throw new WrongGarageException("Wrong garage");
                }
            }
            catch (WrongGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (car == null)
                {
                    throw new CarNullException("the car is null");
                }
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (!car.NeedsRepair)
                {
                    throw new RepairMismatchException("no need to repair");
                }
            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
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
            catch (NoMoreRangInGarage ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FixCar(Car car)
        {
            try
            {
                if (car == null)
                {
                    throw new CarNullException("the car is null");
                }
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (Array.IndexOf(cars, car) == -1)
                {
                    throw new CarNotInGarageException("the car not in the garage");
                }
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (!car.NeedsRepair)
                {
                    throw new RepairMismatchException("the car not need to fix");
                }
            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            car.NeedsRepair = false;               
        }

        public void GetOutCar(Car car)
        {
            try
            {
                if (car == null)
                {
                    throw new CarNullException("cars is null");
                }
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if(Array.IndexOf(cars, car) == -1)
                {
                    throw new CarNotInGarageException("the car not in the garage");
                }
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (car.NeedsRepair)
                {
                    throw new CarNotReadyException("the car not ready");
                }
            }
            catch (CarNotReadyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (Car c in cars)
            {
                if (c.Equals(car))
                {
                    cars[Array.IndexOf(cars, c)] = null;
                }                
            }            
        }
    }
}
