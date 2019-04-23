using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡¡ P I L A !!");
            // P I L A
            Stack<int> stack = new Stack<int>();
            stack.Push(63);
            stack.Push(12);
            stack.Push(36);
            stack.Push(7);
            stack.Push(23);
            stack.Push(58);
            stack.Push(98);
            stack.Push(25);
            stack.Push(98);
            stack.Push(102);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            // F I N - P I L A
            Console.WriteLine("¡¡ C O L A !! ");
            // C O L A 
            Queue<int> queueCola = new Queue<int>();
            queueCola.Enqueue(10);
            queueCola.Enqueue(11);
            queueCola.Enqueue(12);
            queueCola.Enqueue(13);
            queueCola.Enqueue(14);
            queueCola.Enqueue(15);
            queueCola.Enqueue(16);
            queueCola.Enqueue(17);
            queueCola.Enqueue(18);
            queueCola.Enqueue(19);
            foreach (var item in queueCola)
            {
                Console.WriteLine(item);
            }
            // F I N - C O L A
            Console.WriteLine("¡¡ P I L A - S T R I N G !! ");
            // P I L A - S T R I N G S
            Stack<string> stackString = new Stack<string>();
            stackString.Push("Tennis");
            stackString.Push("Golf");
            stackString.Push("Rugby");
            stackString.Push("Voley");
            stackString.Push("Hockey");
            stackString.Push("Futbol");
            stackString.Push("Bascket");
            stackString.Push("Handball");
            stackString.Push("Baisball");
            stackString.Push("Natacion");
            foreach (var item in stackString)
            {
                Console.WriteLine(item);
            }
            // F I N - P I L A - S T R I N G S
            Console.WriteLine("¡¡ C O L A - S T R I N G !! ");
            // C O L A - S T R I N G S
            Queue<string> queueColaString = new Queue<string>();
            queueColaString.Enqueue("El MAS Grande Racing Club");
            queueColaString.Enqueue("Estudiantes");
            queueColaString.Enqueue("Boca");
            queueColaString.Enqueue("Belgrano");
            queueColaString.Enqueue("San Martin De San Juan");
            queueColaString.Enqueue("Talleres");
            queueColaString.Enqueue("River");
            queueColaString.Enqueue("Indesingente");
            queueColaString.Enqueue("Newbells");
            queueColaString.Enqueue("Allboys");
            foreach (var item in queueColaString)
            {
                Console.WriteLine(item);
            }
            // F I N - C O L A - S T R I N G S

            Console.ReadKey();

        }
    }
}
