using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAccessModifiers1
{
    class main
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            #region 3
            BankAccount userBank1 = new BankAccount(10000, "leaumi", "050538");
            //userBank1.balance = 10000;
            //userBank1.bankName = "leaumi";
            //userBank1.AccountNumber = "050538";
            #endregion

            #region 4
            ClientsManagment c1 = new ClientsManagment(new string[10], new int[10], new bool[10], 0);

            #endregion
            #endregion

            #region static
            #region 4
            Person p1 = new Person("u1", "015648");
            Person p2 = new Person("u2", "013648");
            Person p3 = new Person("u3", "016648");
            Person p4 = new Person("u4", "017648");
            Person p5 = new Person("u5", "015038");
            Console.WriteLine(Person.GetNumberOfPersons());
            #endregion
            #endregion
        }
    }
}
