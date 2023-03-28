using Abstraction.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Enum;

namespace Abstraction.Interfaces.Creator
{
    /// <summary>
    /// Interface for Facotry
    /// </summary>
    public interface ICreator
    {
        public ITarget TargetFactory(AdapterType type);
    }
}
