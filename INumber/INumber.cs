using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
    interface INumber : ICloneable, IComparable {
        double addition ( double a, double b, double c, double d );
        double subtraction ( double a, double b, double c, double d );
        double multiplication ( double a, double b, double c, double d );
        double division ( double a, double b, double c, double d );
    }
}
