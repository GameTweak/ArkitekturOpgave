using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces.Models
{
    public interface IOrder
    {
        int OrderNr { get; set; }
        decimal Price { get; set; }
    }
}
