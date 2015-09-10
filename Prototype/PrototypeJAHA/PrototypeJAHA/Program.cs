using System;

namespace PrototypeJAHA
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Hijo AlexPaz = new Hijo ();
			AlexPaz.Nombramiento = "Erick Alejandro";
			AlexPaz.Name(AlexPaz.Nombramiento);
			AlexPaz.Estudiar();
			Console.ReadLine();

		}
	}

	class Humano
	{
		public void Name(string n)
		{
			Console.WriteLine (n);
		}
	}

	class Padre: Humano
	{
		public string Nombramiento { get; set;}
	}

	class Hijo: Padre
	{
		public string Estudiar()
		{
			Console.WriteLine ("¿Qué debería estudiar?");
		}
	}
}
