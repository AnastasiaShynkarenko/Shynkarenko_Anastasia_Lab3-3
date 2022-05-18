using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            products.Add("Молоко", 200);
            products.Add("Хлiб", 50);
            products.Add("Масло", 310);
            products.Add("Огiрки", 400);
            products.Add("Помiдори", 450);
            products.Add("Печиво", 280);
            products.Add("М'ясо", 500);
            List<string> keyList = new List<string>(products.Keys);


            var cheapProducts = (from product in products
                                 where product.Value < 300
                                 group product by product.Value).ToDictionary( k => k.ToList());
                               
                                
                                
            foreach (var p in cheapProducts)
            {
              
                Console.WriteLine($"Продукти менше 300 грн: {p.Key} вартiстю  {p.Value} грн");

            }
            var expensiveProducts = from product in products
                                    where product.Value > 300
                                    group product by product.Value;
            Console.WriteLine("-------------------------------------");
            foreach (var p in expensiveProducts)
            {
                string key = keyList.Find(key => products[key] == p.Key);
                Console.WriteLine($"Продукти бiльше 300 грн: {key} вартiстю {p.Key}  грн");
            }

        }
    }
}
