using Abstraction.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces.Service
{
    public interface ICustomerService
    {
        string SaveCustomer(ICustomer customer);
    }
}
