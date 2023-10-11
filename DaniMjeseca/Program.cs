Console.Write("Unesite redni broj mjeseca (1-12): ");
var unos = Console.ReadLine();
var ok = int.TryParse(unos, out int redniBroj);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
if(redniBroj < 1 || redniBroj> 12)  //if(!(redniBroj >= 1 && redniBroj <=12))
{
    Console.WriteLine("Broj je izvan raspona 1-12");
    return;
}
var brojDanaUMjesecu = 0;
switch (redniBroj)
{
    case 2:
        if (DateTime.IsLeapYear(DateTime.Now.Year))
            brojDanaUMjesecu = 29;
        else
            brojDanaUMjesecu = 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        brojDanaUMjesecu = 30;
        break;
    default:
        brojDanaUMjesecu = 31;
        break;
}
Console.WriteLine("{0}. mjesec ima {1} dan{2}", redniBroj, brojDanaUMjesecu, brojDanaUMjesecu == 31 ? "" : "a");