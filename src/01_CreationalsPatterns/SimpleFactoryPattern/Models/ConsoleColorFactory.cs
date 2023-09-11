using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Models
{
    public abstract class ConsoleColorFactory
    {
        public abstract ConsoleColor Create(decimal totalAmount);
    }
}
