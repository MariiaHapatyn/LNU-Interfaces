using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
    class Task {
        public List<int> number = new List<int>();
        public IntegerNumber integer = new IntegerNumber();

        public Task () { }


        public void input ( int a ) {
            number.Add( a );
        }

        public void remove () {
            number.Clear();
        }

        public double int_sum () {
            double sum = 0;
            foreach( double i in number ) {
                sum = integer.addition( sum, i );
            }

            return sum;
        }

        public double int_product () {
            double product = 1;

            foreach( double i in number ) {
                product = integer.multiplication( product, i );
            }

            return product;
        }

        public double int_arithmetic_mean () {
            double average = 0;
            double k = 0;
            foreach( double i in number ) {
                average = integer.addition( average, i );
                k++;
            }
            average = average / k;
            return average;
        }

    }
}
