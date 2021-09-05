using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    class Other : PhysicalProduct
    {
        public Other(string name)
        {
            ItemName = name;
            Operations = new List<string>();
            base.GetSlip();
            base.AddCommission();
        }
    }
}

