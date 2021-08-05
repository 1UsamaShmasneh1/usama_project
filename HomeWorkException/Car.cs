using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class Car
    {
        private string brand;
        public string Brand { get; set; }
        private bool totalLost;
        public bool TotalLost { get; set; }
        private bool needsRepair;
        public bool NeedsRepair { get; set; }
        public Car(string brand, bool totalLost, bool needsRepair)
        {
            this.brand = brand;
            this.totalLost = totalLost;
            this.needsRepair = needsRepair;
            try
            {
                if (this.totalLost && !this.needsRepair)
                {
                    throw new RepairMismatchException("yyyy");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
