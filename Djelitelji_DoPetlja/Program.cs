var nastavi = true;
do
{
    Console.Write("Unesite broj od 1-100.000: ");
    var unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int broj);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        if (broj < 1 || broj > 100000)
        {
            Console.WriteLine("Broj je izvan raspona");
            continue;
        }
        //ver1 - double
        //var zbroj = 0.0;
        long zbroj = 0;
        for (int i = 1; i <= broj; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                zbroj += i;
            }
        }
        Console.WriteLine("Zbroj brojeva od 1 - {0} djeljivih sa 3 ili 5 je {1:N0}", broj, zbroj);
    }
} while (nastavi);

