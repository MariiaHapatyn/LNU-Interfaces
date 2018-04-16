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

            Console.WriteLine( "\nEnter the numbers:" );
            for( int i = 0; i < size; i++ ) {
                int a = int.Parse( Console.ReadLine() );

                myTask.input( a );
            }

            Console.WriteLine( "sum={0}\n", myTask.int_sum() );

            Console.WriteLine( "product={0}\n", myTask.int_product() );

            Console.WriteLine( "arithmetic mean={0}\n", myTask.int_arithmetic_mean() );

            Console.ReadLine();
        }
    }
}
