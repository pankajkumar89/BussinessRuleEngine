using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    class Book : PhysicalProduct
    {
        public Book(string itemName)
        {
            ItemName = itemName;
            Operations = new List<string>();
            base.GetSlip();
            base.AddCommission();
            GetSlip();
        }
        public override void GetSlip()
        {
            Operations.Add("Create a duplicate packing slip for the royalty department.");
            Console.WriteLine("Create a duplicate packing slip for the royalty department.");
        }
    }
}
