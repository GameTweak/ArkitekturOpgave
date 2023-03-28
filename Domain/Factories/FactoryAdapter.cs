using Abstraction.Enum;
using Abstraction.Interfaces.Creator;
using Abstraction.Interfaces.DataAccess;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories
{
    public class FactoryAdapter : ICreator
    {
        /// <summary>
        /// Switch statement for picking which Adapter to use
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ITarget TargetFactory(AdapterType type)
        {
            switch (type)
            {
                case AdapterType.SQL:
                    // Returns SQL
                    return new SQLDB();
                case AdapterType.FILE:
                    // Returns File
                    return new FileStreamPick();
                default:
                    // If it does not exist, throw
                    throw new NotImplementedException();
            }
        }
    }
}
