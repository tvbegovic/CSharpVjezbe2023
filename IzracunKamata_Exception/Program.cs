double IzracunKamata(double glavnica, double stopa)
{
    if (glavnica < 0)
        throw new ArgumentOutOfRangeException("Glavnica mora biti pozitivna");
    if (stopa < 1 || stopa > 30)
        throw new ArgumentOutOfRangeException("Stopa nije u rasponu 1-30");
    var rezultat = glavnica * stopa / 100;
    return rezultat;
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
        Console.Write("Stopa (1-30%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }

        try
        {
            var kamata = IzracunKamata(glavnica, stopa);
            Console.WriteLine("Za glavnicu {0:N2} i stopu {1} kamata je {2:N2}",
            glavnica, stopa, kamata);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
        }
        

    }
} while (nastavi);