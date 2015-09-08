using System;
using System.Collections;

namespace FactoryMethodJuan
{
	class FactoryPattern 
	{
		interface IdProducto
		{
			string Transportacion(  );
		}
	
		class Importador1 : IdProducto
		{
			public String Transportacion (  )
			{
				return "desde España";
			}
		}
		class Importador2 : IdProducto
		{
			public String Transportacion (  )
			{
				return "desde México";
			}
		}

		class ProductoPorDefecto : IdProducto 
		{
			public String Transportacion (  ) 
			{
				return "no disponible";
			}
		}

		class Importaciones {
			public IdProducto FactoryMethod (int mes)
			{
				if (mes >= 4 & mes <= 11)
					return new Importador1 ();
				else 
				if (mes == 1 || mes == 2 || mes == 12)
					return new Importador2 ();
				else
					return new ProductoPorDefecto ();
			}
		}

		public static void Main (string[] args)
		{
			Importador c = new Importaciones(  );
			IdProducto producto;
			for (int i=1; i<=12; i++) 
			{
				producto = c.FactoryMethod (i);
				Console.WriteLine ("Chiles " + producto.Transportacion ());
			}
		}
	}
}
