using System.Net.Http.Headers;

double Zarada(int brojSati, double cijenaSata = 40.0, double porez = 0.2)
{
    if (brojSati < 0)
        throw new ArgumentException("Broj sati mora biti > 0");
    if (cijenaSata < 0)
        throw new ArgumentException("Cijena sata mora biti > 0");
    return brojSati * cijenaSata * (1 - porez);
}

var nastavi = true;
do
{
    Console.Write("Broj sati: ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int brojSati);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Cijena sata: ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double cijenaSata);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.Write("Porez: ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double porez);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        Console.WriteLine("Ukupna zarada za broj sati: {0}, cijenu sata {1} i porez {2} je {3}",brojSati, cijenaSata, porez, Zarada(brojSati, cijenaSata, porez));
        Console.WriteLine("Ukupna zarada za broj sati {0}, cijenu sata {1} i defautnu stopu poreza je {2}", brojSati, cijenaSata, Zarada(brojSati, cijenaSata));
        Console.WriteLine("Ukupna zarada za broj sati {0}, defaultnu cijenu sata i porez {1} je {2}", brojSati, porez, Zarada(brojSati, porez: porez));
        Console.WriteLine("Ukupna zarada za broj sati {0} i defaultnu cijenu sata i stopu poreza je {1}", brojSati, Zarada(brojSati));
    }
} while (nastavi);
