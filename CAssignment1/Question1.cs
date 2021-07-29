using System;
using System.Collections.Generic;
using System.Text;

namespace CAssignment1
{
    class Question1
    {
        static void Main()
        {
            Console.WriteLine("Enter units: ");
            int units = Convert.ToInt32(Console.ReadLine());
            float price;

            if (units <= 100)
            {
                price = 1.2f;
                Console.WriteLine("Electricity bill is: {0}", units * price);
            }
            else if (units <= 300)
            {
                price = 2.0f;
                Console.WriteLine("Electricity bill is: {0}", ((100 * 1.2) + ((units - 100) * price)));

            }
            else if (units > 300)
            {
                price = 3.0f;
                Console.WriteLine("Electricity bill is: {0}", (120+400+((units-300)*price)));

            }
        }
    }
}
