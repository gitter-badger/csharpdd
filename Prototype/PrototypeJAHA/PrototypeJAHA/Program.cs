using System;

namespace PrototypeJAHA
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Nieto AlexPaz = new Nieto ();

		}
	}

	class Padre
	{
		public void Name(string nombre)
		{
			Console.WriteLine (nombre);
		}
	}

	class Hijo: Padre
	{
		public string Nombramiento { get; set;}
	}

	class Nieto: Hijo
	{

	}
}
