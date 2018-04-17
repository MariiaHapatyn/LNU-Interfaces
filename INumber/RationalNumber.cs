using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
        class RationalNumber : IInputOutput, INumber {
            public int fnumerator, fdenominator, snumerator, sdenominator;


            public RationalNumber () : this( fnumerator: 0, fdenominator: 0, snumerator: 0, sdenominator: 0 ) { }

            public RationalNumber ( int fnumerator, int fdenominator, int snumerator, int sdenominator ) {
                this.fnumerator = fnumerator;
                this.fdenominator = fdenominator;
                this.snumerator = snumerator;
                this.sdenominator = sdenominator;
            }

            double gcd ( double m, double n ) {
                double remainder = 0;
                m = Math.Abs( m ); n = Math.Abs( n );
                if( n > m ) { remainder = m; m = n; n = remainder; }
                do {
                    remainder = m % n; m = n; n = remainder;
                } while( n != 0 );
                return ( m );
            }

            public double addition ( double a, double b, double c, double d ) {
                double numerator = ( a * d ) + ( c * b );
                double denominator = b * d;
                double k = gcd( numerator, denominator );
                numerator = numerator / k;
                denominator = denominator / k;
                Console.WriteLine( "{0}/{1}", numerator, denominator );
                return numerator / denominator;
            }

            public double subtraction ( double a, double b, double c, double d ) {
                double numerator = ( a * d ) - ( c * b );
                double denominator = b * d;
                double k = gcd( numerator, denominator );
                numerator = numerator / k;
                denominator = denominator / k;
                Console.WriteLine( "{0}/{1}", numerator, denominator );
                return numerator / denominator;
            }

            public double multiplication ( double a, double b, double c, double d ) {
                double numerator = a * c;
                double denominator = b * d;
                double k = gcd( numerator, denominator );
                numerator = numerator / k;
                denominator = denominator / k;
                Console.WriteLine( "{0}/{1}", numerator, denominator );
                return numerator / denominator;
            }

            public double division ( double a, double b, double c, double d ) {
                double numerator = a * d;
                double denominator = b * c;
                double k = gcd( numerator, denominator );
                numerator = numerator / k;
                denominator = denominator / k;
                Console.WriteLine( "{0}/{1}", numerator, denominator );
                return numerator / denominator;
            }

            public int CompareTo ( object obj ) {
                RationalNumber comparable = obj as RationalNumber;
                if( comparable != null ) {
                    if( this.fnumerator / fdenominator > comparable.snumerator / sdenominator ) {
                        return 1;
                    } else if( this.fnumerator / fdenominator < comparable.snumerator / sdenominator ) {
                        return -1;
                    } else {
                        return 0;
                    }
                } else {
                    throw new InvalidCastException();
                }

            }

            public object Clone () {
                throw new NotImplementedException();
            }

            void IInputOutput.Input () {
                throw new NotImplementedException();
            }

            void IInputOutput.Output () {
                Console.WriteLine( $" first :{fnumerator} / {fdenominator},\nsecond : {snumerator} / {sdenominator}" );
            }

        }
    }
