using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    class Membership : NonPhysicalProduct
    {
        public Membership()
        {
            Operations = new List<string>();
            base.GetSlip();
            Operations.Add("Activate that membership");
            Console.WriteLine("Activate that membership");
            base.DropMail();
        }
    }
}
