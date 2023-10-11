Console.Write("Unesite datum");
var unos = Console.ReadLine();
var ok = DateTime.TryParse(unos, out DateTime datum);
if (!ok)
{

}
if (datum < DateTime.Now)
{
    Console.WriteLine("Datum je u prošlosti");
    Console.WriteLine("Od zadanog datuma do danas prošlo je {0} dana",
        (DateTime.Now - datum).TotalDays);
}
else
{
    Console.WriteLine("Datum je u budućnosti");
    Console.WriteLine("Od danas do zadanog datuma proći će {0} dana",
        (datum - DateTime.Now).TotalDays);
}