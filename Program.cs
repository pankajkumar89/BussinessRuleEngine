using System;
using System.Collections.Generic;
using static BusinessRulesEngine.Program;

namespace BusinessRulesEngine
{
   
 
public class Program
    {
        public enum ProductTypes
        {
            Video,
            Membership,
            Upgrade,
            Book,
            Other
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product type and name (if applicable) seperated by space");
            var input = Console.ReadLine().Split(' ');
            var output = OrderProcessor.ConvertInputToType(input);
            Console.WriteLine("Item Name : {0} Operations : {1}", output.ItemName, string.Join(' ', output.Operations));
            Console.ReadLine();
        }
    }
}