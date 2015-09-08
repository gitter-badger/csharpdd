using System;
using System.Collections.Generic;

namespace PatronSingleton
{

	public class MainClass
	{
		static List<Instancia1> _inst1 = null;
		static List<Instancia2> _inst2 = null;
		
		public static void Main (string[] args)
		{
			_inst1 = new List<Instancia1>();
			_inst2 = new List<Instancia2>();
			string op = null;
			do
			{
				VerInstancias();
				Console.WriteLine("a) Crear instancia No Singleton");
				Console.WriteLine("b) Crear instancia Singleton");
				Console.WriteLine("q) Salir");
				Console.Write("\n");
				Console.Write("Elija su opción y pulse  : ");
				op = Console.ReadLine().ToLower();
				switch(op)
				{
					case "a":
						CrearInstanciaNoSingleton();
						break;
					case "b":
						CrearInstanciaSingleton();						
						break;
				}
			}
			while(op != "q");
		}
		
		static void VerInstancias()
		{
			try
			{
				Console.Clear();
				Console.WriteLine("Lista instancias");
				Console.Write("\n");
				if ((_inst1.Count > 0) || (_inst2.Count > 0))
				{
					if (_inst1.Count > 0)
					{
						foreach(var i in _inst1)
						{
							Console.WriteLine("No Singleton: {0}",i.Info);
						}
						Console.Write("\n");
					}
					if (_inst2.Count > 0)
					{
						foreach(var i in _inst2)
						{
							Console.WriteLine("   Singleton: {0}",i.Info);
						}
						Console.Write("\n");
					}
				}
				else
				{
					Console.WriteLine("** No hay instancias **");
					Console.Write("\n");
				}
			}
			catch(Exception e)
			{
				Console.WriteLine("Excepcion " + e.Message);
			}
		}  

		static void CrearInstanciaNoSingleton()
		{
			try
			{
				Instancia1 db = new Instancia1();
				_inst1.Add(db);
			}
			catch(Exception e)
			{
				Console.WriteLine("Excepción " + e.Message);
			}
		}

		static void CrearInstanciaSingleton()
		{
			try
			{
				_inst2.Add(Instancia2.GetInstancia());
			}
			catch(Exception e)
			{
				Console.WriteLine("Excepción " + e.Message);
			}
		}

	}
}