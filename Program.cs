class Program
{
	static void Main()
	{
		// Dictionary
		Dictionary d = new Dictionary();

		d[0] = new string[2] { "Donate - ", "Bagis" };
		d[1] = new string[2] { "\nWolf - ", "canavar, qurd, yirtici heyvan" };
		d[2] = new string[2] { "\nGreen - ", "Yasil" };
		d[3] = new string[2] { "\nSpace - ", "Bosluq" };
		d[4] = new string[2] { "\nHate - ", "Nifret" };
		d[5] = new string[2] { "\nPillow - ", "Yastiq" };

		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 2; j++)
				Console.Write(d[i][j]);
		Console.WriteLine();

		Console.WriteLine();
		// Article
		Article a1 = new Article("Lenovo", Guid.NewGuid(), 2549.99);
		Article a2 = new Article("Dell", Guid.NewGuid(), 1799.9);

		Console.WriteLine(a1 < a2);
		Console.WriteLine(a1 + a2);
		Console.WriteLine(a1 == a2);

		Console.WriteLine();
		// Client
		Client c1 = new Client(Guid.NewGuid(), "Rasim", "Baku", "0551234567", 9, 259);
		Client c2 = new Client(Guid.NewGuid(), "Babek", "Baku", "0771234567", 25, 925);

		Console.WriteLine(c1++);
		Console.WriteLine(c2--);
		Console.WriteLine(c1 != c2);
	}
}