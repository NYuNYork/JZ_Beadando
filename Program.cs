namespace ConsoleApp1
{
    internal class Program
    {
        static int[] kocka = new int[5];
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            dobas();
            pontszam();
        }

        private static void pontszam()
        {
            int HaromUgyanolyan = 0;
            int Egyesek = 0;
            int Kettesek = 0;
            int Harmasok = 0;
            int Negyesek = 0;
            int Otosok = 0;
            int Hatosok = 0;
            for (int i = 0; i < kocka.Length; i++)
            {
                //ezek az egyesek
                if (kocka[i] == 1)
                {
                    Egyesek++;
                }
                //kettesek
                if (kocka[i] == 2)
                {
                    Kettesek++;
                }
                //hármasok
                if (kocka[i] == 3)
                {
                    Harmasok++;
                }
                //négyesek
                if (kocka[i] == 4)
                {
                    Negyesek++;
                }
                //ötösök
                if (kocka[i] == 5)
                {
                    Otosok++;
                }
                //hatosok
                if(kocka[i] == 6)
                {
                    Hatosok++;
                }   
            }
            Console.WriteLine($"egyesek: {Egyesek}");
            Console.WriteLine($"kettesek: {Kettesek * 2}");
            Console.WriteLine($"Harmasok: {Harmasok * 3}");
            Console.WriteLine($"Negyesek: {Negyesek * 4}");
            Console.WriteLine($"Otosok: {Otosok * 5}"); 
            Console.WriteLine($"Hatosok: {Hatosok * 6}");
            //három ugyanolyan
            if (Egyesek >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 3");
            }
            if (Kettesek >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 6");
            }
            if (Harmasok >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 9");
            }
            if (Negyesek >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 12");
            }
            if (Otosok >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 15");
            }
            if (Hatosok >= 3)
            {
                Console.WriteLine($"Három ugyanolyan: 18");
            }
            //négy ugyanolyan
            if (Egyesek >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 4");
            }
            if (Kettesek >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 8");
            }
            if (Harmasok >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 12");
            }
            if (Negyesek >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 16");
            }
            if (Otosok >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 20");
            }
            if (Hatosok >= 4)
            {
                Console.WriteLine($"Négy ugyanolyan: 24");
            }

        }

        private static void dobas()
        {
            
            for(int i = 0; i < 5; i++)
            {
                kocka[i] = rnd.Next(1,7);
                Console.WriteLine(kocka[i]);
            }
        }
    }
}