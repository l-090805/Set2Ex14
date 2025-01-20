using System;

namespace Set2Ex14
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de elemente din secventa: "); 
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Secventa este monotona rotita."); 
                return;
            }

            Console.WriteLine("Introduceti elementele secventei: "); 
            int primulElement = int.Parse(Console.ReadLine());
            int elementAnterior = primulElement;
            int elementCurent;
            int rupturiCresc = 0; 
            int rupturiDesc = 0;  

            for (int i = 1; i < n; i++)
            {
                elementCurent = int.Parse(Console.ReadLine());

                if (elementCurent < elementAnterior)
                {
                    rupturiCresc++;
                }
                else if (elementCurent > elementAnterior)
                {
                    rupturiDesc++;
                }

                elementAnterior = elementCurent;
            }

            if (primulElement < elementAnterior)
            {
                rupturiCresc++;
            }
            else if (primulElement > elementAnterior)
            {
                rupturiDesc++;
            }

            if (rupturiCresc <= 1 || rupturiDesc <= 1)
            {
                Console.WriteLine("Secventa este monotona rotita."); 
            }
            else
            {
                Console.WriteLine("Secventa NU este monotona rotita."); 
            }
        }
    }
}
