using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public abstract class NonPhysicalProduct : Product
    {
        public override void GetSlip()
        {
            Operations.Add("Generated a packing slip.");
            Console.WriteLine("Generated a packing slip.");
        }
        public virtual void DropMail()
        {
            Operations.Add("Mail Sent");
            Console.WriteLine("Mail Sent");
        }

    }
}
