using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
    class Task {
        public IntegerNumber integer = new IntegerNumber();
        public RationalNumber rational = new RationalNumber();

        public List<int> number = new List<int>();
        public List<int> numerator = new List<int>();
        public List<int> denominator = new List<int>();

        public Task () { }


        public void input_int ( int a ) {
            number.Add( a );
        }

        public void input_rational ( int a, int b ) {
            numerator.Add( a );
            denominator.Add( b );
        }

        public void remove () {
            number.Clear();
            numerator.Clear();
            denominator.Clear();
        }

        public double int_sum () {
            double sum = 0;
            foreach( int i in number ) {
                sum = integer.addition( sum, i );
            }

            return sum;
        }

        public double rational_sum ( int size ) {
            double sum = 0;
            for( int i = 0; i < size; i++ ) {
                sum = rational.addition( sum, 1, numerator[i], denominator[i] );
            }

            return sum;
        }

        public double int_product () {
            double product = 1;

            foreach( int i in number ) {
                product = integer.multiplication( product, i );
            }

            return product;
        }

        public double rational_product ( int size ) {
            double product = 1;

            for( int i = 0; i < size; i++ ) {
                product = rational.multiplication( product, 1, numerator[i], denominator[i] );
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
        public double rational_arithmetic_mean ( int size ) {
            double average = 0;
            double k = 0;
            for( int i = 0; i < size; i++ ) {
                average = rational.addition( average, 1, numerator[i], denominator[i] );
                k++;
            }
            average = average / k;
            return average;
        }
    }
}

    
