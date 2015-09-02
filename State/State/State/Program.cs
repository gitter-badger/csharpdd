using System;
using Gtk;

namespace State
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Application.Init ();
			//MainWindow win = new MainWindow ();
			//win.Show ();
			//Application.Run ();

			Vehiculo v = new Vehiculo(20);

			v.Acelerar();
			v.Contacto();
			v.Acelerar();
			v.Acelerar();
			v.Acelerar();
			v.Frenar();
			v.Frenar();
			v.Frenar();
			v.Frenar();
			Console.Read ();
		}
	}
}
