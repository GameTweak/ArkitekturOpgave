using Abstraction.Enum;
using Abstraction.Interfaces.DataAccess;
using Abstraction.Interfaces.Models;
using Abstraction.Interfaces.Service;
using Domain.Factories;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// Saves the order using ITarget 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public string SaveOrder(IOrder order)
        {
            // Uses the target interface for deciding which adapter to use
            ITarget db = new FactoryAdapter().TargetFactory(AdapterType.SQL);

            // Returns a string as a type of validation
            return db.SaveOrder(order);
        }
    }
}
