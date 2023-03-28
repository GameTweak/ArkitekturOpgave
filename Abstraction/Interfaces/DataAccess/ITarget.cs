using Abstraction.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces.DataAccess
{
    public interface ITarget
    {
        string SaveCustomer(ICustomer customer); // Method used to save Customer

        string SaveOrder(IOrder order); // Method used to save Order
    }
}
