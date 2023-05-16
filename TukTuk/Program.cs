using System.Security.Cryptography;

Console.WriteLine("Vítejte v aplikaci Ťukťuk");
#region Menu
Console.WriteLine("Vybrat hru [S] nebo zahrát si náhodnou [R]");

string[] PoleHry = { "Šibenice" };
Random rng = new Random();
string vyberSTR = "";
int vyberINT = 0;

while(true)
{
    vyberSTR = Console.ReadLine().ToUpper();
    if (vyberSTR == "S")
    {
        while(true)
        {
            int i = 1;
            Console.WriteLine("Napište číslo hry");
            foreach (string hra in PoleHry)
            {
                Console.WriteLine($"{i} - {hra}");
                i++;
            }
            vyberINT = Convert.ToInt32(Console.ReadLine()) - 1;
            if (vyberINT < 0 || vyberINT > PoleHry.Length - 1)
            {
                Console.WriteLine("Neplatný výběr");
                Thread.Sleep(600);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Zvolená hra - {PoleHry[vyberINT]}");
                Thread.Sleep(800);
                Console.Clear();
                break;
            }
        }
        break;
    }
    else if (vyberSTR == "R")
    {
        vyberINT = rng.Next(0, PoleHry.Length);
        Console.WriteLine($"Zvolená hra - {PoleHry[vyberINT]}");
        Thread.Sleep(800);
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Neplatný výběr");
        Thread.Sleep(600);
        Console.Clear();
    }
}
#endregion

switch (vyberINT)
{
    case 0:
        string txtSoubourSlova = File.ReadAllText("txt/slovicka.txt");
        string[] slova = txtSoubourSlova.Split(";");
        vyberINT = rng.Next(0, slova.Length - 1);
        string[] vybraneSlovo = slova[vyberINT].Split(":");

        while(true)
        {
            string hadani = Console.ReadLine().ToUpper();
            int i = 1;
            foreach(string pismeno in vybraneSlovo)
            {
                if(hadani == pismeno)
                {
                    Console.WriteLine($"{hadani} je na {i}. pozici");
                }
                i++;
            }
            //kontrolovani a "odemykani" individualnich pismen (pis1, pis2...)
            //kdyz jsou vsechny "odemceny" tak ukoncit
            if()
            { }
        }
        break;
}