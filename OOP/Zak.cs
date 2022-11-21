namespace OOP
{
	internal class Zak
	{
		internal string Jmeno;
		internal string Prijmeni;
		internal int RokNarozeni;
		
		internal Zak() { }

		internal Zak(string _jmeno, string _prijmeni, int _rokNarozeni)
		{
			Jmeno = _jmeno;
			Prijmeni = _prijmeni;
			RokNarozeni = _rokNarozeni;
		}
		
		internal Zak(string _jmeno, string _prijmeni)
		{
			Jmeno = _jmeno;
			Prijmeni = _prijmeni;
			RokNarozeni = -1;
		}

		private int VratVek()
		{
			return 2022 - RokNarozeni;
		}

		internal void Pozdrav()
		{
			Console.WriteLine($"Ahoj, já jsem: {Jmeno} a je mi {VratVek().ToString()} let.");
		}
	}
}
