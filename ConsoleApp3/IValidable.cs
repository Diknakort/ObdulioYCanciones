using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public interface IValidable
    {
        bool isValid(IVendible elemento);
    }
}