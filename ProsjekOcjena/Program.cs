try
{
	Console.Write("Ocjena C: ");
	var unos = Console.ReadLine();
	//var ocjenaC = double.Parse(unos); //promjena varijable u double da dijeljenje bude realno
	var ocjenaC = int.Parse(unos);
	Console.Write("Ocjena C++: ");
	unos = Console.ReadLine();
	var ocjenaCPlus = int.Parse(unos);
	Console.Write("Ocjena C#: ");
	unos = Console.ReadLine();
	var ocjenaCSharp = int.Parse(unos);

	var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0; //konstanta postaje double da dijeljenje bude realno
	Console.WriteLine("Prosjek unesenih ocjena iz predmeta C, C++ i C# je {0:N2}", prosjek);
}
catch (Exception ex)
{
	Console.WriteLine("Dogodila se pogreška. Tekst pogreške: {0}", ex.Message);
}

