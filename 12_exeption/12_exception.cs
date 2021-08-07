using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_exeption
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            if (x < 0)
                throw new FormatException("x is negative");
            try
            {
                Console.WriteLine(y / x);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (DivideByZeroException ex) when (y == 0)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("do it any way");
            }
        }
    }
    class PitaOutOfRangeException: ApplicationException
    {
        public PitaOutOfRangeException(string str): base(str)
        {

        }
    }
    class Customer
    {
        public void OrderDish()
        {
            Chef order = new Chef();
            order.MakeDish("flafel");
        }
    }
    class Chef
    {
        public void MakeDish(string str)
        {
            if (str == "flafel")
                throw new PitaOutOfRangeException("Pita Out Of Range");
        }
    }
}
