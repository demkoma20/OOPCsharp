namespace OOP
{
	class Program
	{
		static void Main()
		{
			// ...
			
			Zak zak1 = new Zak();
			zak1.Jmeno = "Petr";
			zak1.Prijmeni = "Pan";
			zak1.RokNarozeni = 1021;

			Zak zak2 = new Zak()
			{
				Jmeno = "Kapitan",
				Prijmeni = "Hook",
				RokNarozeni = 1002
			};

			Zak zak3 = new Zak("Jirka", "Král", 1996);
			Zak zak4 = new Zak("Víla", "Amalka");
			
			zak1.Pozdrav();
		}
	}
}