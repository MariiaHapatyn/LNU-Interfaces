using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumber {
    class Program {
        static void Main ( string[ ] args ) {
            Task myTask = new Task();
            Console.WriteLine( "Enter size:" );
            int size = int.Parse( Console.ReadLine() );

            Console.WriteLine( "\nEnter the integer numbers:" );
            for( int i = 0; i < size; i++ ) {
                int a = int.Parse( Console.ReadLine() );

                myTask.input_int( a );
            }

            Console.WriteLine( "integer sum={0}\n", myTask.int_sum() );

            Console.WriteLine( "integer product={0}\n", myTask.int_product() );

            Console.WriteLine( "integer arithmetic mean={0}\n", myTask.int_arithmetic_mean() );

            Console.WriteLine( "\nEnter the  numerators and denominators:" );
            for( int i = 0; i < size; i++ ) {
                int a = int.Parse( Console.ReadLine() );

                int b = int.Parse( Console.ReadLine() );

                myTask.input_rational( a, b );
            }

            Console.WriteLine( "rational sum={0}\n", myTask.rational_sum( size ) );

            Console.WriteLine( "rational product={0}\n", myTask.rational_product( size ) );

            Console.WriteLine( "rational arithmetic mean={0}\n", myTask.rational_arithmetic_mean( size ) );


            Console.ReadLine();
        }
    }

}
