using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
    class IntegerNumber : INumber, IInputOutput {
        public int numberA;
        public int numberB;


        public IntegerNumber () : this( numberA: 0, numberB: 0 ) { }

        public IntegerNumber ( int numberA, int numberB ) {
            this.numberA = numberA;
            this.numberB = numberB;
        }
        public double addition ( double a, double b, double c = 0, double d = 0 ) {
            double sum = a + b;
            return sum;
        }
        public double subtraction ( double a, double b, double c = 0, double d = 0 ) {
            double difference = a - b;
            return difference;
        }
        public double multiplication ( double a, double b, double c = 0, double d = 0 ) {
            double product = a * b;
            return product;
        }
        public double division ( double a, double b, double c = 0, double d = 0 ) {
            double fraction = a / b;
            return fraction;
        }
        public int CompareTo ( object obj ) {
            IntegerNumber comparable = obj as IntegerNumber;
            if( comparable != null ) {
                if( this.numberA > comparable.numberB ) {
                    return 1;
                } else if( this.numberA < comparable.numberB ) {
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
            Console.WriteLine( $" number A :{numberA},\nnumber B : {numberB}" );
        }

    }

}