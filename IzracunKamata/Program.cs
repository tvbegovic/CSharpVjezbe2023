double IzracunKamata(double glavnica, double stopa)
{
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
        if(!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        if(glavnica <=0)
        {
            Console.WriteLine("Glavnica mora biti pozitivna");
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
        if(stopa < 1 || stopa > 30)
        {
            Console.WriteLine("Stopa je izvan raspona");
            continue;
        }
        var kamata = IzracunKamata(glavnica, stopa);
        Console.WriteLine("Za glavnicu {0:N2} i stopu {1} kamata je {2:N2}",
            glavnica, stopa, kamata);

    }
} while (nastavi);