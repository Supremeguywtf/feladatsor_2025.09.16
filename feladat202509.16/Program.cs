using System;

class Program
{
    static void F1()
    {
        Console.WriteLine("Hello world!");
    }

    static void F2()
    {
        try
        {
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine()!;
            Console.WriteLine("Szia, " + nev + "!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba történt: " + ex.Message);
        }
    }

    static void F3()
    {
        try
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine()!);
            Console.WriteLine("A kétszerese: " + (szam * 2));
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F4()
    {
        try
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Összeg: " + (a + b));
            Console.WriteLine("Különbség: " + (a - b));
            Console.WriteLine("Szorzat: " + (a * b));
            if (b != 0)
                Console.WriteLine("Hányados: " + ((double)a / b));
            else
                Console.WriteLine("Nullával nem lehet osztani!");
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F5()
    {
        try
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine()!);

            if (a > b) Console.WriteLine("A nagyobb: " + a);
            else if (b > a) Console.WriteLine("A nagyobb: " + b);
            else Console.WriteLine("A két szám egyenlő.");
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F6()
    {
        try
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Harmadik szám: ");
            int c = int.Parse(Console.ReadLine()!);

            int legkisebb = Math.Min(a, Math.Min(b, c));
            Console.WriteLine("A legkisebb: " + legkisebb);
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F7()
    {
        try
        {
            Console.Write("Első oldal: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Második oldal: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Harmadik oldal: ");
            int c = int.Parse(Console.ReadLine()!);

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Szerkeszthető háromszög.");
            else
                Console.WriteLine("Nem szerkeszthető háromszög.");
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F8()
    {
        try
        {
            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine()!);

            double szamtani = (a + b) / 2.0;
            double mertani = Math.Sqrt(a * b);

            Console.WriteLine("Számtani közép: " + szamtani);
            Console.WriteLine("Mértani közép: " + mertani);
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F9()
    {
        try
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine()!);

            double D = b * b - 4 * a * c;

            if (D < 0) Console.WriteLine("Nincs valós megoldás.");
            else Console.WriteLine("Van valós megoldás.");
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F10()
    {
        try
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine()!);

            double D = b * b - 4 * a * c;

            if (D < 0)
                Console.WriteLine("Nincs valós megoldás.");
            else if (D == 0)
                Console.WriteLine("Egy gyök: x = " + (-b / (2 * a)));
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Két gyök: x1 = " + x1 + ", x2 = " + x2);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F11()
    {
        try
        {
            Console.Write("Első befogó: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Második befogó: ");
            double b = double.Parse(Console.ReadLine()!);

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Átfogó: " + Math.Round(c, 2));
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F12()
    {
        try
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine()!);

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;

            Console.WriteLine("Felszín: " + felszin);
            Console.WriteLine("Térfogat: " + terfogat);
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F13()
    {
        try
        {
            Console.Write("Átmérő: ");
            double d = double.Parse(Console.ReadLine()!);

            double r = d / 2.0;
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;

            Console.WriteLine("Kerület: " + kerulet);
            Console.WriteLine("Terület: " + terulet);
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F14()
    {
        try
        {
            Console.Write("Sugár: ");
            double r = double.Parse(Console.ReadLine()!);
            Console.Write("Középponti szög (fok): ");
            double szog = double.Parse(Console.ReadLine()!);

            double rad = szog * Math.PI / 180.0;
            double ivhossz = r * rad;
            double terulet = (r * r * rad) / 2;

            Console.WriteLine("Ívhossz: " + ivhossz);
            Console.WriteLine("Szakasz terület: " + terulet);
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F15()
    {
        try
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int szam = int.Parse(Console.ReadLine()!);
            if (szam < 0)
            {
                Console.WriteLine("A szám nem pozitív.");
                return;
            }
            for (int i = 1; i <= szam; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott érték nem alakítható át számmá");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F16()
    {
        int szam = 0;
        bool sikeres = false;
        while (!sikeres)
        {
            try
            {
                Console.Write("Adj meg egy pozitív egész számot: ");
                szam = int.Parse(Console.ReadLine()!);
                if (szam < 0)
                {
                    Console.WriteLine("A szám nem pozitív.");
                }
                else
                {
                    sikeres = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("A megadott érték sajnos nem alakítható át számmá :(");
            }
            catch (OverflowException)
            {
                Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
            }
        }
    }

    static void F17()
    {
        try
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int szam = int.Parse(Console.ReadLine()!);
            if (szam < 0)
            {
                Console.WriteLine("A szám nem pozitív.");
                return;
            }
            for (int i = 1; i <= szam; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("A megadott számnak nem írhatóak ki az osztói");
        }
        catch (OverflowException)
        {
            Console.WriteLine("A megadott szám túl nagy vagy túl kicsi.");
        }
    }

    static void F18()
    {
        int szam = 0;
        bool sikeres = false;
        while (!sikeres)
        {
            try
            {
                Console.Write("Adj meg egy pozitív egész számot: ");
                szam = int.Parse(Console.ReadLine()!);
                if (szam < 0)
                {
                    Console.WriteLine("A szám nem pozitív.");
                }
                else
                {
                    sikeres = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: Nem számot adtál meg! ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hiba történt: ");
            }
        }
        int osszeg = 0;
        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0)
            {
                osszeg += i;
            }
        }
        Console.WriteLine("Az osztóinak összege: " + osszeg);
    }

    static void F19()
    {
        int szam = 0;
        bool sikeres = false;
        while (!sikeres)
        {
            try
            {
                Console.Write("Adj meg egy pozitív egész számot: ");
                szam = int.Parse(Console.ReadLine()!);
                if (szam < 0)
                {
                    Console.WriteLine("A szám nem pozitív.");
                }
                else
                {
                    sikeres = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: Nem számot adtál meg! ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hiba történt: ");
            }
        }
        int osszeg = 0;
        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0)
            {
                osszeg += i;
            }
        }
        if (osszeg == 2 * szam)
        {
            Console.WriteLine($"A {szam} szám tökéletes.");
        }
        else
        {
            Console.WriteLine($"A {szam} szám nem tökéletes.");
        }
    }

    static void F20()
    {
        int alap = 0;
        int kitevo = 0;
        bool sikeres = false;

        while (!sikeres)
        {
            try
            {
                Console.Write("Add meg a hatvány alapját: ");
                alap = int.Parse(Console.ReadLine()!);

                Console.Write("Add meg a kitevőt: ");
                kitevo = int.Parse(Console.ReadLine()!);

                sikeres = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: csak számot adhatsz meg!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hiba történt");
            }
        }
        double eredmeny = Math.Pow(alap, kitevo);

        Console.WriteLine($"Hatványalap: {alap}");
        Console.WriteLine($"Kitevő: {kitevo}");
        Console.WriteLine($"Eredmény: {eredmeny}");
    }

    static void F21()
    {
        int szam = 0;
        bool sikeres = false;

        while (!sikeres)
        {
            try
            {
                Console.Write("Adj meg egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine()!);

                if (szam > 0)
                {
                    sikeres = true;
                    Console.WriteLine($"A megadott szám: {szam}");
                }
                else
                {
                    Console.WriteLine("A szám nem pozitív. Próbáld újra!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: Nem számot adtál meg! Próbáld újra!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hiba: A megadott szám túl nagy vagy túl kicsi. Próbáld újra!");
            }
        }
    }

    static void F22()
    {
        int osszeg = 0;
        while (true)
        {
            try
            {
                Console.Write("Adj meg egy számot (ha tíz vagy nagyobb, a program leáll): ");
                int szam = int.Parse(Console.ReadLine()!);

                if (szam >= 10)
                {
                    break;
                }

                osszeg += szam;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: Nem számot adtál meg! Próbáld újra!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Hiba: A megadott szám túl nagy vagy túl kicsi. Próbáld újra!");
            }
        }

        Console.WriteLine($"A beolvasott számok összege: {osszeg}");
    }

    static void F23()
    {
        try
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine()!);
            int eredeti = szam;

            Console.Write(eredeti + " = ");
            bool voltOsztas = false;

            while (szam % 2 == 0)
            {
                Console.Write("2*");
                szam /= 2;
                voltOsztas = true;
            }

            Console.WriteLine(szam);
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba:lehetséges hogy nem számot adtál volna meg !");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hiba: ez most nem jott be te kis csibész :( !");
        }
    }

    static void F24()
    {
        Console.Write("Adj meg egy szót: ");
        string szo = Console.ReadLine();

        if (szo == "alma")
        {
            Console.WriteLine("Az alma gyümölcs!");
        }
        else
        {
            Console.WriteLine("Nem jó, csak az 'alma'-t fogadom el!");
        }
    }

    static void F25()
    {
        try
        {
            Console.Write("Adj meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine()!);
            int eredeti = szam;

            int hanyas = szam / 3;
            int maradek = szam % 3;

            Console.WriteLine($"{eredeti} = {hanyas}*3+{maradek}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba:Lehetséges volna hogy nem számot adtál meg?");
        }
    }

    static void F26()
    {
        try
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            bool prim = true;

            if (n < 2) prim = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
            }
            Console.WriteLine(prim ? "Prím szám." : "Nem prím szám.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: ezt sajnos nem lehet értelmezni");
        }
    }

    static void F27()
    {
        try
        {
            Console.Write("Írj be egy számot: ");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < num; i++)
            {
                int n = 0;
                for (int x = 1; x < i + 1; x++)
                {
                    if (i % x == 0)
                    {
                        n++;
                    }
                }
                if (n == 2)
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: ez nem egy szám!");
        }
    }

    static void F28()
    {
        try
        {
            Console.Write("Pls adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine()!);
            int eredeti = n;

            Console.Write($"A(z) {eredeti} prímosztói: ");

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bool prim = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0) { prim = false; break; }
                    }
                    if (prim)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: Ennek a számnak sajnos nem tudom a prím osztóit kiírni!");
        }
    }

    static void F29()
    {
        try
        {
            Console.Write("Írj be egy számot: ");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < num; i++)
            {
                int n = 0;
                for (int g = 1; g < i + 1; g++)
                {
                    if (i % g == 0)
                    {
                        n++;
                    }
                }
                if (n == 2)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} | {i} ");
                        num = num / i;
                    }
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: ez nem egy szám!");
        }
    }

    static void F30()
    {
        try
        {
            Console.Write("Üss be egy számot: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Dobj be még egy számot: ");
            int y = int.Parse(Console.ReadLine()!);

            while (y > 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            Console.WriteLine($"LNKO: {x}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: Valószínüleg nem egy számot adtál meg!");
        }
    }

    static void F31()
    {
        try
        {
            Console.Write("Adj meg az első számot: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Adj meg a második számot: ");
            int b = int.Parse(Console.ReadLine()!);

            int x = a, y = b;
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            int lnko = x;

            int lkkt = Math.Abs(a * b) / lnko;
            Console.WriteLine($"A két szám legkisebb közös többszöröse: {lkkt}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba: Nem számot adtál meg!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hiba: A megadott szám túl nagy vagy túl kicsi.");
        }
    }


    static void Main()
    {
        F31();
    }
}
