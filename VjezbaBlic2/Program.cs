void Izracun(int broj, out int sumaParnih, out int sumaSvih)
{
    if (broj < 1 || broj > 1000)
        throw new ArgumentException("Broj je izvan raspona");
    sumaParnih = 0;
    sumaSvih = 0;
    for (int i = 1; i <= broj; i++)
    {
        if (i % 2 == 0)
            sumaParnih += i;
        sumaSvih += i;
    }
}

var nastavi = true;
do
{
    Console.Write("Unesite broj: ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int broj);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        try
        {
            Izracun(broj, out int sumaParnih, out int sumaSve);
            Console.WriteLine("Za uneseni broj {0} suma parnih brojeva manjih od njega je {1} a suma svih je {2}", broj, sumaParnih, sumaSve);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
        }
    }
} while (nastavi);