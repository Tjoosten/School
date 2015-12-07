using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oef6._1._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lees het bestand. Met de ingebouwde lezer van System.IO.
            StreamReader lezer = new StreamReader("oef6166.txt");

            int L, M, P;
            // L = aantal elementen van A 
            // M = aantal elementen van B
            // P = aantal elementen van C

            L = int.Parse(lezer.ReadLine());
            M = int.Parse(lezer.ReadLine());
            P = int.Parse(lezer.ReadLine()); 

            // Declareren van de arrays. 
            int[] A = new int[L];
            int[] B = new int[M];
            int[] C = new int[P];

            // Inlezen van de elementen van array A 
            for (int i = 0; i < L; i++)
            {
                A[i] = int.Parse(lezer.ReadLine());    
            }

            // Inlezen van de elementen van array B
            for (int i = 0; i < L; i++)
            {
                B[i] = int.Parse(lezer.ReadLine());
            }

            int I, J, K; 
            // I = lopende index van array A
            // J = lopende index van array B
            // K = lopende index van array C

            I = 0;
            J = 0;
            K = 0;

            while (I<L && J<M && K<P)
            {
                if (A[i]<B[I])
                {
                    C[K] = A[I];
                    I++;
                }
                else
                {
                    C[K] = B[J];
                    J++;
                }

                K++;
            }

            // A is niet opgebruikt
            // We hebben nog elementen nodig voor C 
            while (I<L && K<P)
            {
                C[K] = A[I];
                I++;
                K++; 
            }

            // B is niet opgebruikt 
            // En we hebben nog elementen nodig voor C.
            while (J<M && K<P)
            {
                C[K] = B[J];
                J++;
                K++;
            }

            // Fout afhandeling.
            if (K<P)
            {
                Console.WriteLine("Er zijn niet genoeg elementen om rij C op te vullen");
            }

            // array C afdrukken
            for (int i = 0; i < P; i++)
            {
                Console.Write(C[i].ToString().PadLeft(5));
            }

            // Zet de cursor vanvoor.
            // De cursor staat nu in het begin voor van een lijn
            Console.WriteLine();

            if (I<L)
            {
                Console.WriteLine("Er zijn nog elementen van rij A");

                for (int i = I; i < L; i++)
                {
                    Console.Write(A[I].ToString().PadLeft(5));
                }
            }

            // De cursor staat op het einde van de lijn? 
            Console.WriteLine(); // De cursor in het begin van de lijn plaatsen. 

            if (J<M)
            {
                Console.WriteLine("Er zijn nog elementen van rij B");

                for (int i = J; i < K; i++)
                {
                    Console.Write(B[i].ToString().PadLeft(5));
                }
            }

            // Stop hammertime, halt the system.
            Console.Read();
           
        }
    }
}
