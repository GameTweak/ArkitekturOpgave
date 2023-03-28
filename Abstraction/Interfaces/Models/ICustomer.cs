using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces.Models
{
    public interface ICustomer
    {
        int Id { get; set; }
        string? Name { get; set; }
    }
}
