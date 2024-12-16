namespace Set2Ex14
{
    internal class Program
    {   
        public static  bool EsteCrescatoare(int[] secventa)
        {
            int n = secventa.Length;
            for (int i = 0; i < n-1; i++)
            {
                if(secventa[i] >= secventa[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool EsteDescrescatoare(int[] secventa)
        {
            int n = secventa.Length;
            for(int i = 0;i < n-1; i++)
            {
                if (secventa[i] <= secventa[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool EsteMonotonaRotita(int[] secventa)
        {
            int n = secventa.Length;
            for(int rotatie = 0; rotatie < n; rotatie++)
            {
                int[] rotita = new int[n];
                for(int i = 0; i < n; i++)
                {
                    rotita[i] = secventa[(i+rotatie)%n];
                }
                if(EsteCrescatoare(rotita) || EsteDescrescatoare(rotita))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti secventa de numere separata prin spatiu: ");
            string input = Console.ReadLine();

            int[] secventa = Array.ConvertAll(input.Split(' '), int.Parse);
            bool rezultat = EsteMonotonaRotita(secventa);
            Console.WriteLine("Este monotona rotita: " + rezultat);
        }
    }
}
