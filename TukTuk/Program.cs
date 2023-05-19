Console.WriteLine("Vítejte v aplikaci Ťukťuk");
while (true)
{
    #region Menu
    string[] PoleHry = { "Šibenice" };
    Random rng = new Random();
    string vyberSTR = "";
    int vyberINT = 0;

    while (true)
    {
        Console.WriteLine("Vybrat si hru [S], zahrát si náhodnou [R] nebo ukončit aplikaci [E]");
        vyberSTR = Console.ReadLine().ToUpper();
        if (vyberSTR == "S")
        {
            while (true)
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
        else if(vyberSTR == "E")
        {
            goto END;
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
        #region Šibenice
        case 0:
            string[] poleSlova = { "F:O:R:T:N:I:T:E", "O:H:Ř:E:V", "A:U:T:O:M:O:B:I:L", "K:O:L:O", "K:O:N:C:E:N:T:R:A:C:E", "P:Í:S:E:K", "Ú:D:E:R", "O:P:Á:L:E:N:Í", "B:A:T:E:R:I:E", "B:O:R", "S:E:D:M", "Ú:L:E:V", "I:N:S:P:I:R:A:C:E", "N:A:B:Í:D:K:A", "P:R:E:M:I:A:N:T", "P:Y:T:L:Á:K", "H:R:A", "U:Č:E:N:Í", "S:C:É:N:Á:R:I:S:T:A", "M:A:Č:E:T:A", "M:Ě:N:A", "L:O:G:I:K:A", "B:Ě:H", "H:R:D:L:O", "K:R:I:T:I:K:A", "T:O:P:O:L", "A:D:R:E:S:A", "P:E:N:Í:Z:E", "K:A:K:T:U:S", "K:L:Á:V:E:S:N:I:C:E", "T:R:P:Ě:L:I:V:O:S:T", "P:O:C:I:T", "M:I:L:I:O:N", "D:Ž:B:Á:N", "P:L:Í:S:E:Ň", "C:H:O:R:O:V:O:D", "R:E:K:L:A:M:A", "P:L:O:D", "P:L:O:T", "D:R:A:Ž:B:A", "R:E:Z:I:S:T:O:R", "R:A:S:I:S:M:U:S", "N:O:H:A", "S:Í:L:A", "V:O:J:Á:K", "Z:E:M:Ě:T:Ř:E:S:E:N:Í", "O:Š:E:T:Ř:O:V:A:T:E:L", "T:R:U:B:K:A", "P:R:O:C:E:S:O:R", "G:R:A:F:I:K:A", "M:O:Z:E:K", "P:L:Á:Č", "B:O:L:E:S:T", "C:H:L:E:B:A", "R:O:H:L:Í:K", "T:A:B:U:L:E", "M:I:K:R:O:F:O:N" };
            vyberINT = rng.Next(0, poleSlova.Length);
            string[] vybraneSlovo = poleSlova[vyberINT].Split(":");
            string[] uhadnutaPismena = new string[vybraneSlovo.Length];
            int i = 0;
            foreach (string pismeno in uhadnutaPismena)
            {
                uhadnutaPismena[i] = "_";
                i++;
            }

            while (true)
            {
            Reset:
                foreach (string pismeno in uhadnutaPismena)
                {
                    Console.Write(pismeno);
                }
                Console.WriteLine("");

                string hadanePismeno = Console.ReadLine().ToUpper();
                i = 1;
                bool veSlove = false;

                foreach (string pismeno in vybraneSlovo)
                {
                    if (hadanePismeno == pismeno)
                    {
                        uhadnutaPismena[i - 1] = hadanePismeno;
                        veSlove = true;
                    }
                    i++;
                }

                if (veSlove == false)
                {
                    Console.WriteLine("Hádané písmeno není ve slově");
                }

                Thread.Sleep(800);
                Console.Clear();

                i = 0;
                foreach (string pismeno in vybraneSlovo)
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
                Thread.Sleep(800);
                Console.Clear();
                goto Win;
            }
              Win:
            break;
        #endregion
    }
}
END:
Console.WriteLine("See you next time!");