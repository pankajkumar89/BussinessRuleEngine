using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public abstract class Product
    {
        public string ItemName { get; set; }
        public List<string> Operations { get; set; }
        public abstract void GetSlip();
    }
}
