using Microservice.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("1. Manage Menu Supplier");
            Console.WriteLine("=================================");
            Console.Write("Silahkan masukkan pilihan anda : ");
            var x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("=================================");
            Console.WriteLine("Pilihan anda adalah " + x);

            switch (x)
            {
                case 1:
                    SupplierController supplier = new SupplierController();
                    supplier.menuSupplier();
                    break;

                default:
                    Console.WriteLine("Please insert again");
                    Console.Read();
                    break;
            }
        }
    }
}
