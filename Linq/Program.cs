using Linq.Models;
using Linq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========== Mid Monthly Exam 4 =============");
                Console.WriteLine();
                Console.WriteLine("=========== 1280860 Mohiuddin =============");
                DoTake();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTake()
        {
            ProductRepo pRepo = new ProductRepo();
            var products = pRepo.GetProducts();
            CategoryRepo cRepo = new CategoryRepo();
            var cates = cRepo.GetCategories();
            ProductModelRepo pmRepo = new ProductModelRepo();
            var models = pmRepo.GetModels();

            Console.ForegroundColor = ConsoleColor.White;
            

            Console.WriteLine("--------------------------------------------");
            var matchingProducts = from p1 in products
                            join c in cates on p1.ProductCategoryID equals c.ProductCategoryID
                            join m in models on p1.ProductModelID equals m.ProductModelID
                            join p2 in products on new { CategoryID = c.ProductCategoryID, ModelID = m.ProductModelID } equals new { CategoryID = p2.ProductCategoryID, ModelID = p2.ProductModelID }
                            where p1.ProductID != p2.ProductID 
                            select new
                            {
                                Product1 = p1,
                                Product2 = p2
                            };

            foreach (var match in matchingProducts)
            {
                Console.WriteLine($"Product 1: {match.Product1.Name}, Model ID: {match.Product1.ProductModelID}, Product Size: {match.Product1.Size}, Product 2: {match.Product2.Name}, Model ID: {match.Product2.ProductModelID}, Product Size: {match.Product2.Size}");
            }
        }
    }
}

