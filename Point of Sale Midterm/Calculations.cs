﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale_Midterm
{
    class Calculations
    {
        PaymentType obj = new PaymentType();
        double money = obj.Cash();
        double subtotal;
        double salesTax;
        double grandTotal;
        public List<orderedItemInfo> orderedItems = new List<orderedItemInfo>();
        public Calculations(List<orderedItemInfo> orderedItems)
        {
            this.orderedItems = orderedItems;
        }
        
        public void Totals() //change to public static int Totals (pass in list) return 
        {
            List<double> costs = new List<double>();
            subtotal = 0;
            salesTax = 0.06; //Michigan sales tax is 6%.
            grandTotal = 0;

            foreach (orderedItemInfo item in orderedItems)
            {
                subtotal = item.Price * item.Quantity;
                costs.Add(subtotal);
            }
            double sum = costs.Sum();
            Console.WriteLine("Subtotal = " + sum);//transfer to receipt view
            salesTax = costs.Sum() * salesTax;
            grandTotal = Math.Round(salesTax + sum, 2);
            Console.WriteLine("Sales Tax = " + salesTax);//transfer to receipt view
            Console.WriteLine("Total = " + grandTotal);//transfer to receipt view


        }
    }
}
