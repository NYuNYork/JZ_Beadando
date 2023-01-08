namespace ConsoleApp1
{
    internal class Program
    {
        static int[] kocka = new int[5];
        static int Osszes = 0;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            dobas();
            pontszam();
        }

        private static void pontszam()
        {
            bool Par = false;
            bool HaromUgyanolyan = false;
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
                if (kocka[i] == 6)
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
            //párok
            if (Egyesek == 2)
            {
                Par = true;
            }
            if (Kettesek == 2)
            {
                Par = true;
            }
            if (Harmasok == 2)
            {
                Par = true;
            }
            if (Negyesek == 2)
            {
                Par = true;
            }
            if (Otosok == 2)
            { 
                Par = true;
            }
            if (Hatosok == 2)
            {
                Par = true;
            }

            //három ugyanolyan
            if (Egyesek == 3 || Kettesek == 3 || Harmasok == 3 || Negyesek == 3 || Otosok == 3 || Hatosok == 3)
            {
                Console.WriteLine($"Három ugyanolyan: {Osszes}");
                HaromUgyanolyan = true;
            }

            //négy ugyanolyan
            if (Egyesek == 4 || Kettesek == 4 || Harmasok == 4 || Negyesek == 4 || Otosok == 4 || Hatosok == 4)
            {
                 Console.WriteLine($"Négy ugyanolyan: {Osszes}");
            }

            //fullhouse
            if(Par==true && HaromUgyanolyan == true)
            {
                Console.WriteLine("Full house: 25");
            }

            //small straight
            if(Egyesek>=1 && Kettesek>=1 && Harmasok >= 1 && Negyesek>=1 || Kettesek >= 1 && Harmasok >= 1 && Negyesek >= 1 && Otosok >= 1 || Harmasok >= 1 && Negyesek >= 1 && Otosok >= 1 && Hatosok >= 1)
            {
                Console.WriteLine("Small straight: 30");
            }

            //largehouse
            if (Egyesek >= 1 && Kettesek >= 1 && Harmasok >= 1 && Negyesek >= 1 && Otosok >= 1 || Kettesek >= 1 && Harmasok >= 1 && Negyesek >= 1 && Otosok >= 1 && Hatosok >= 1)
            {
                Console.WriteLine("Large house: 40");
            }

            //chance
            Console.WriteLine($"Chance: {Osszes}");

            //YAHTZEE
            if (Egyesek == 5 || Kettesek == 5 || Harmasok == 5 || Negyesek == 5 || Otosok == 5 || Hatosok == 5)
            {
                Console.WriteLine("YAHTZEE: 50");
            }


        }

        private static void dobas()
        {
            for (int i = 0; i < 5; i++)
            {
                kocka[i] = rnd.Next(1, 7);
                Osszes += kocka[i];
                Console.WriteLine(kocka[i]);
            }
        }
        
    } 
}