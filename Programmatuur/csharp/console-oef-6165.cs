using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace console_oef6._1._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezer = new StreamReader("oef6165.txt");
            
            // Variable declaratie.
            int L, M;

            L = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());

            int[] A = new int[L]; // Array A heeft de L elementen. 
            int[] B = new int[M]; // Array B heeft de M elementen.

            // Elementen van A inlezen.
            for (int i = 0; i < L; i++)
            {
                A[i] = int.Parse(lezer.ReadLine());
            }

            // Elementen van B inlezen. 
            for (int i = 0; i < M; i++)
            {
                B[i] = int.Parse(lezer.ReadLine());
            }

            int I, J, K;
            I = 0; // Lopende index voor rij A
            J = 0; // Lopende index voor rij B
            K = 0; // Lopende index voor rij C

            while (I < L && J < M)
            {
                if (A[I] < B[J])
                {
                    C[K] = A[I];
                    I++;
                } else {
                    C[K] = B[J];
                    I++;
                }
            }

            // A is niet opgebruikt
            while (I < L)
            {
                C[K] = A[I];
                I++;
                K++;

            }

            // B is nog niet opgebruikt. 
            while (J < N)
            {
                C[K] = B[J];
                J++;
                K++;
            }

            Console.Read();

        }
    }
}
Enter file contents here
