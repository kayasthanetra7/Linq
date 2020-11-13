using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class StandardQueryOperators
    {
        public void Operations()
        {
            List<int> myList1 = new List<int>();
            myList1.Add(367);
            myList1.Add(4);
            myList1.Add(8);
            myList1.Add(15);
            myList1.Add(20);
            myList1.Add(25);
            myList1.Add(50);
            myList1.Add(100);

            // Query 1 using where
            var filteredResult = myList1.Where(a => a > 25 && a < 100);
            foreach( var num in filteredResult)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //Query 2 using OrderBy and OrderbyDescending
            var ascendingOrder = myList1.OrderBy(b => b);
            foreach (var num2 in ascendingOrder)
            {
                Console.WriteLine(num2);
            }
            Console.WriteLine();

            var descendingOrder = myList1.OrderByDescending(c => c);
            foreach(var num3 in descendingOrder)
            {
                Console.WriteLine(num3);
            }

            // Query 3 using groupby
            var groupByResult = from d in myList1
                                group d by d % 2;
            
            foreach (var num4 in groupByResult)
            {
                Console.WriteLine(num4.Key==0 ? "\nEven Numbers:" : "\nOdd Numbers:");

                foreach (int n1 in num4)
                    Console.WriteLine(n1);
            }
            Console.WriteLine();

            //Query 4 using All
            bool allResult = myList1.All(e => e > 12 && e < 100);
            Console.WriteLine(allResult);

            // Query 5 for Any
            bool anyResult = myList1.Any(f => f > 12 && f < 100);
            Console.WriteLine(anyResult);
            Console.WriteLine();

            //Query 6 for Select
            var selectResult = myList1.Select(s => s);
            foreach(int num6 in selectResult )
            {
                Console.WriteLine(num6);
            }
            bool containsResult = myList1.Contains(10);
            Console.WriteLine(containsResult);
            Console.WriteLine();

            //Query 7 for Average
            var averageResult = myList1.Average();
            Console.WriteLine(averageResult);

        }
    }
}
