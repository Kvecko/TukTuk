using System.ComponentModel;

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
        string[] poleSlova = { "O:H:Ř:E:V", "A:U:T:O:M:O:B:I:L", "K:O:L:O" };
        vyberINT = rng.Next(0, poleSlova.Length - 1);
        string[] vybraneSlovo = poleSlova[vyberINT].Split(":");
        string[] uhadnutaPismena = new string[vybraneSlovo.Length];
        int i = 0;
        foreach(string pismeno in uhadnutaPismena)
        {
            uhadnutaPismena[i] = "_";
            i++;
        }

        while(true)
        {
            Reset:;
            foreach (string pismeno in uhadnutaPismena)
            {
                Console.Write(pismeno);
            }
            Console.WriteLine("");
                                
            string hadanePismeno = Console.ReadLine().ToUpper();
            i = 1;
            bool veSlove = false;

            foreach(string pismeno in vybraneSlovo)
            {
                if(hadanePismeno == pismeno)
                {
                    uhadnutaPismena[i - 1] = hadanePismeno;
                    veSlove = true;
                }
                i++;
            }

            if(veSlove == false)
            {
                Console.WriteLine("Hádané písmeno není ve slově");
            }

            Thread.Sleep(800);
            Console.Clear();

            i = 0;
            foreach(string pismeno in vybraneSlovo)
            {
                if (vybraneSlovo[i] == uhadnutaPismena[i])
                {
                    
                }
                else
                {
                    goto Reset;
                }
                i++;
            }
            Console.WriteLine("Well done, uhádl jsi slovo!");
            goto Win;
        }
        Win:
        break;
}