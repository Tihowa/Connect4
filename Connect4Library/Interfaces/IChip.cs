using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Library.Interfaces
{
    public interface IChip<T>
    {
        T Value { get; set; }
    }
}
