using Abstraction.Interfaces.Models;
using Abstraction.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Abstraction.Interfaces.DataAccess;
using Domain.Factories;
using Abstraction.Enum;

namespace Domain.Service
{
    /// <summary>
    /// Service for handling customer
    /// </summary>
    public class CustomerService : ICustomerService
    {
        /// <summary>
        /// Methods used for saving customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string SaveCustomer(ICustomer customer)
        { 
            // Uses the target interface for deciding which adapter to use
            ITarget db = new FactoryAdapter().TargetFactory(AdapterType.SQL);

            // Returns the string to validate success
            return db.SaveCustomer(customer);
        }
    }
}
