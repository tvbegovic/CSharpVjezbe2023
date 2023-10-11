Console.Write("Ime: ");
var ime = Console.ReadLine();
Console.Write("Prezime: ");
var prezime = Console.ReadLine();
if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
    Console.WriteLine("Ne mogu ispisati inicijale jer je ime ili prezime prazno");
else
    Console.WriteLine("Vaši inicijali su: {0}.{1}.", ime.Substring(0, 1), prezime.Substring(0, 1));