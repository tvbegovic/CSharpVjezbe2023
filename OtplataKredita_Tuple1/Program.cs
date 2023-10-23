Tuple<double,double> IzracunParametara(double iznos, double stopa, int brojGodina)
{
    if (iznos < 0 || stopa < 0 || brojGodina < 0)
        throw new ArgumentException("Parametri moraju biti pozitivni brojevi");
    if (stopa < 2 || stopa > 15)
        throw new ArgumentOutOfRangeException("Stopa mora biti između 2 i 15");
    if (brojGodina < 3 || brojGodina > 30)
        throw new ArgumentOutOfRangeException("Broj godina mora biti 3-30");
    var r = Kamatnjak(stopa);
    var n = brojGodina * 12;
    var anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
    var iznosKamata = anuitet * n - iznos;
    return new Tuple<double, double>(anuitet, iznosKamata);
}

double Kamatnjak(double stopa)
{
    return 1 + stopa / 100 / 12;
}

var nastavi = true;
do
{
    Console.Write("Glavnica: ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = double.TryParse(unos, out double glavnica);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Stopa: ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Broj godina: ");
        unos = Console.ReadLine();
        ok = int.TryParse(unos, out int brojGodina);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        try
        {
            var rezultat = IzracunParametara(glavnica, stopa, brojGodina);
            Console.WriteLine("Za zadani iznos kredita {0:N2}, godišnju kamatnu stopu {1} i broj godina otplate {2} anuitet je {3:N2} a ukupno plaćena kamata {4:N2}", glavnica, stopa, brojGodina, rezultat.Item1, rezultat.Item2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
        }

    }
} while (nastavi);

