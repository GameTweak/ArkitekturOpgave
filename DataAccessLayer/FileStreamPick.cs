using Abstraction.Interfaces.DataAccess;
using Abstraction.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    /// <summary>
    /// Uses the ITarget interface, which forces the class
    /// to include SaveCustomer() and SaveOrder()
    /// </summary>
    public class FileStreamPick : ITarget
    {
        /// <summary>
        /// Returns a string as a type of validation
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string SaveCustomer(ICustomer customer)
        {
            return $"{customer.Name} was saved with the id={customer.Id}";
        }

        /// <summary>
        /// Returns a string as a type of validation
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string SaveOrder(IOrder order)
        {
            return $"{order.OrderNr} was saved with price of {order.Price}";
        }
    }
}
