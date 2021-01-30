using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameArchitect.Abstract
{
    interface ISale
    {
        public int Id { get; set; }
        public string SaleMethodName { get; set; }
        public double SaleAmount { get; set; }
    }
}
