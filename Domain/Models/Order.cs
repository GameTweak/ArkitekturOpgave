using Abstraction.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// Model to represent Orders
    /// Uses the IOrder interface
    /// </summary>
    public class Order : IOrder
    {
        public int OrderNr { get; set; }
        public decimal Price { get; set; }
    }
}
