using Microservice.BussinessLogic.Services;
using Microservice.BussinessLogic.Services.Master;
using Microservice.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Controller
{
    public class SupplierController
    {
        public void menuSupplier() {
            ISupplierService _supplierService = new SupplierService();
            SupplierParam supplierParam = new SupplierParam();

            Console.WriteLine("=========== Supplier Data ============");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("======================================");

            switch (chance)
            {
                case 1:
                    // ini untuk memasukkan nilai Name, JoinDate, dan CreateDate di Supplier
                    Console.Write("Insert Name of Supplier : ");
                    supplierParam.Name = Console.ReadLine();
                    _supplierService.Insert(supplierParam);
                    break;

                case 2:
                    // input id untuk dicari
                    Console.Write("Insert Id to Update Data : ");
                    supplierParam.Id = Convert.ToInt16(Console.ReadLine());
        
                    Console.Write("Insert Name of Supplier : ");
                    supplierParam.Name = Console.ReadLine();
                    _supplierService.Update(supplierParam.Id, supplierParam);
                    break;

                case 3:
                    // input id untuk dicari
                    Console.Write("Insert Id Supplier : ");
                    supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                    _supplierService.Delete(supplierParam.Id);
                    break;

                case 4:
                    _supplierService.Get();
                    foreach (var tampilin in _supplierService.Get())
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Name         : " + tampilin.Name);
                        Console.WriteLine("Name         : " + tampilin.JoinDate);
                        Console.WriteLine("=========================================");
                    }
                    Console.WriteLine("Total Supplier" + _supplierService.Get().Count());
                    Console.Read();
                    break;

                default:
                    Console.Write("Something Wrong, Please try again next time.");
                    break;
            }
        }
    }
} 
