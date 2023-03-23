class program
{
    static void Main()
    {
        string[] be = File.ReadAllLines("source/tobo words 1.txt");
        string[,] szavak = new string[2, be.Length];
        for (int i = 0; i < be.Length; i++)
        {
            string[] be2 = be[i].Split(" - ");
            for (int j = 0; j < 2; j++)
                szavak[j, i] = be2[j];
        }
        Random rnd = new Random();
        Console.Write("A teszt hossza: ");
        int hossz = Convert.ToInt32(Console.ReadLine());
        string kerdes;
        string valasz;
        int kerdeses;
        int jo = 0;
        for (int i = 0; i < (hossz / 2); i++)
        {
            kerdeses = rnd.Next(be.Length);
            kerdes = szavak[0, kerdeses];
            Console.Write("{0}: ", kerdes);
            valasz = Console.ReadLine();
            if (valasz == szavak[1, kerdeses])
            {
                jo++;
                Console.WriteLine("Jó válasz.");
            }
        }
        for (int i = 0; i < (hossz / 2); i++)
        {
            kerdeses = rnd.Next(be.Length);
            kerdes = szavak[1, kerdeses];
            Console.Write("{0}: ", kerdes);
            valasz = Console.ReadLine();
            if (valasz == szavak[0, kerdeses])
            {
                jo++;
                Console.WriteLine("Jó válasz.");
            }
        }
        Console.WriteLine("{0}/{1}", jo, hossz);
    }
}