using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public abstract class PhysicalProduct : Product
    {
        public override void GetSlip()
        {
            Operations.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
        public virtual void AddCommission()
        {
            Operations.Add("Commission payment to the agent");
            Console.WriteLine("Commission payment to the agent");
        }
    }
}
