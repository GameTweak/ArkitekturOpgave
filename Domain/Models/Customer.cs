using Abstraction.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// Model to represent Customers
    /// Uses the ICustomer interface
    /// </summary>
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
