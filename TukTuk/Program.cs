using Spectre.Console;

Console.WriteLine("Vítejte v aplikaci Ťukťuk");
Thread.Sleep(1000);
Console.Clear();

while (true)
{
    Console.ResetColor();

    #region Menu
    string[] PoleHry = { "Šibenice", "Kámen, nůžky, papír", "Pexeso" };
    Random rng = new Random();
    string vyberSTR = "";
    int vyberINT = 0;

    while (true)
    {
        vyberSTR = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .AddChoices(new[] {
            "Vybrat si hru", "Vybrat náhodnou hru", "Ukončit aplikaci"
        }));

        if (vyberSTR == "Vybrat si hru")
        {
            while (true)
            {
                vyberSTR = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .AddChoices(new[] {
                "Šibenice", "Kámen, nůžky, papír", "Pexeso"
                }));
                //Jsem psát všechny hry

                for (vyberINT = 0; vyberINT < PoleHry.Length; vyberINT++)
                {
                    if (vyberSTR == PoleHry[vyberINT])
                    {
                        break;
                    }
                }
                break;
            }
            break;
        }
        else if (vyberSTR == "Vybrat náhodnou hru")
        {
            vyberINT = rng.Next(0, PoleHry.Length);
            Console.WriteLine($"Zvolená hra - {PoleHry[vyberINT]}");
            Thread.Sleep(800);
            Console.Clear();
            break;
        }
        else if(vyberSTR == "Ukončit aplikaci")
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
                i = 0;
                bool veSlove = false;

                foreach (string pismeno in vybraneSlovo)
                {
                    if (hadanePismeno == pismeno)
                    {
                        uhadnutaPismena[i] = hadanePismeno;
                        veSlove = true;
                    }
                    i++;
                }

                i = 0;
                switch (hadanePismeno)
                {
                    case "A":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Á" == pismeno)
                            {
                                uhadnutaPismena[i] = "Á";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "C":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Č" == pismeno)
                            {
                                uhadnutaPismena[i] = "Č";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "D":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ď" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ď";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "E":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("É" == pismeno)
                            {
                                uhadnutaPismena[i] = "É";
                                veSlove = true;
                            }
                            i++;
                        }
                        i = 0;
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ě" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ě";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "I":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Í" == pismeno)
                            {
                                uhadnutaPismena[i] = "Í";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "N":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ň" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ň";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "O":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ó" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ó";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "R":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ř" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ř";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;
                        
                    case "S":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Š" == pismeno)
                            {
                                uhadnutaPismena[i] = "Š";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                     case "T":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ť" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ť";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "U":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ú" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ú";
                                veSlove = true;
                            }
                            i++;
                        }
                        i = 0;
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ů" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ů";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "Y":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ý" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ý";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;

                    case "Z":
                        foreach (string pismeno in vybraneSlovo)
                        {
                            if ("Ž" == pismeno)
                            {
                                uhadnutaPismena[i] = "Ž";
                                veSlove = true;
                            }
                            i++;
                        }
                        break;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well done, uhádl jsi slovo!");
                Thread.Sleep(800);
                Console.Clear();
                goto Win;
            }
            Win:
            break;
        #endregion

        #region KNP
        case 1:
            int koloWinsHrac = 0;
            int koloWinsBot = 0;
            while (true)
            {
                int vyberKNPHrac = 0;
                int vyberKNPBot = 0;
                Console.ResetColor();

                while (true)
                {
                    vyberSTR = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Vyber si")
                        .AddChoices(new[] {
                            "Kámen", "Nůžky", "Papír"
                        }));

                    if (vyberSTR == "Kámen")
                    {
                        vyberKNPHrac = 0;
                        Console.WriteLine("Vybral sis kámen");
                        break;
                    }
                    else if (vyberSTR == "Nůžky")
                    {
                        vyberKNPHrac = 1;
                        Console.WriteLine("Vybral sis nůžky");
                        break;
                    }
                    else if (vyberSTR == "Papír")
                    {
                        vyberKNPHrac = 2;
                        Console.WriteLine("Vybral sis papír");
                        break;
                    }
                }

                vyberKNPBot = rng.Next(0, 3);
                if (vyberKNPBot == 0)
                {
                    Console.WriteLine("Bot si vybral kámen");
                }
                else if (vyberKNPBot == 1)
                {
                    Console.WriteLine("Bot si vybral nůžky");
                }
                else if (vyberKNPBot == 2)
                {
                    Console.WriteLine("Bot si vybral papír");
                }

                if (vyberKNPHrac == 0 && vyberKNPBot == 1 || vyberKNPHrac == 1 && vyberKNPBot == 2 || vyberKNPHrac == 2 && vyberKNPBot == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kolo vyhrál hráč");
                    koloWinsHrac++;
                }
                else if (vyberKNPHrac == vyberKNPBot)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Remíza");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kolo vyhrál bot");
                    koloWinsBot++;
                }

                Thread.Sleep(1000);
                Console.Clear();

                if (koloWinsHrac == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gratuluji, vyhrál jsi hru!");
                    goto KNPEnd;
                }
                else if (koloWinsBot == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Je to tragédie, prohrál jsi hru!");
                    goto KNPEnd;
                }
            }
            KNPEnd:
            Thread.Sleep(1250);
            Console.Clear();
            break;
        #endregion

        #region Pexeso
        case 2:
            string[] pexesoSlova = { "jablko", "jablko", "hruška", "hruška", "meloun", "meloun", "granátové jablko", "granátové jablko", "avokádo", "avokádo", "banán", "banán", "durian", "durian", "fík", "fík", "citrón", "citrón", "datle", "datle" };
            string[] pexesoRandom = new string[pexesoSlova.Length];

            for (i = 0; i < pexesoRandom.Length; i++)
            {
                pexesoRandom[i] = ".";
            }

            for (i = 0; i < pexesoSlova.Length; i++)
            {
                while (true)
                {
                    int cislo = rng.Next(0, pexesoSlova.Length);
                    string slovo = pexesoSlova[cislo];
                    if (pexesoSlova[cislo] != ".")
                    {
                        if (slovo != ".")
                        {
                            pexesoRandom[i] = slovo;
                            pexesoSlova[cislo] = ".";
                            break;
                        }
                    }
                }
            }

            while (true)
            {
                PexesoStart:

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Neuhodnuté karty: ");
                for (i = 0; i < pexesoRandom.Length; i++)
                {
                    if (pexesoRandom[i] != ".")
                    {
                        Console.Write($"{i + 1} ");
                    }
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uhodnuté karty: ");
                for (i = 0; i < pexesoRandom.Length; i++)
                {
                    if (pexesoRandom[i] == ".")
                    {
                        Console.Write($"{i + 1} ");
                    }
                }

                Console.ResetColor();
                Console.WriteLine("");

                VyberKarta1:
                Console.WriteLine("Zadej číslo první karty");
                int odpoved1 = Convert.ToInt32(Console.ReadLine());
                if (odpoved1 <= 0 || odpoved1 > pexesoRandom.Length)
                {
                    Console.WriteLine("Neplatný výběr");
                    goto VyberKarta1;
                }
                else if (pexesoRandom[odpoved1 - 1] == ".")
                {
                    Console.WriteLine("Karta byla již uhodnota");
                    goto VyberKarta1;
                }

                VyberKarta2:
                Console.WriteLine("Zadej číslo druhé karty");
                int odpoved2 = Convert.ToInt32(Console.ReadLine());
                if (odpoved2 <= 0 || odpoved2 > pexesoRandom.Length)
                {
                    Console.WriteLine("Neplatný výběr");
                    goto VyberKarta2;
                }
                else if (pexesoRandom[odpoved2 - 1] == ".")
                {
                    Console.WriteLine("Karta byla již uhodnota");
                    goto VyberKarta2;
                }
                else if (odpoved2 == odpoved1)
                {
                    Console.WriteLine("NT, ale spíš ne");
                    goto VyberKarta2;
                }

                Console.WriteLine($"První karta - {pexesoRandom[odpoved1 - 1]} \nDruhá karta - {pexesoRandom[odpoved2 - 1]}");
                if (pexesoRandom[odpoved1 - 1] == pexesoRandom[odpoved2 - 1])
                {
                    Console.WriteLine("Dvojice nalezena");
                    pexesoRandom[odpoved1 - 1] = ".";
                    pexesoRandom[odpoved2 - 1] = ".";
                }
                else
                {
                    Console.WriteLine("Neshodná dvojice");
                }

                Thread.Sleep(1000);
                Console.Clear();

                foreach (string slovo in pexesoRandom)
                {
                    if (slovo != ".")
                    {
                        goto PexesoStart;
                    }
                }
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vyhrál jsi!");
            Thread.Sleep(600);
            Console.Clear();
            break;
            #endregion
    }
}
END:
Console.WriteLine("See you next time!");