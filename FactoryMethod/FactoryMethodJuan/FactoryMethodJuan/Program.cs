using System;
using System.Collections;

namespace FactoryMethodJuan
{
	class FactoryPattern 
	{
		//Muestra como sera llamado el producto
		interface IdProducto
		{
			string Transportacion(  );
		}
		
		//Es una de las clases a las cuales se les podra asignar el producto
		class Importador1 : IdProducto
		{
			//Permite dar a conocer desde donde proviene el producto del primer importador
			public String Transportacion (  )
			{
				return "desde España";
			}
		}
		
		//Segunda clase a la cual se le asigna el producto
		class Importador2 : IdProducto
		{
			//Ubicacion desde donde sale el producto del segundo importador
			public String Transportacion (  )
			{
				return "desde México";
			}
		}

		//En caso de no encontrarse el producto disponible marcara un producto por defecto
		class ProductoPorDefecto : IdProducto 
		{
			//Mostrando así que no se encuentra disponible dicho producto
			public String Transportacion (  ) 
			{
				return "no disponible";
			}
		}

		//Clase importaciones en el cual se asignan las transportaciones
		class Importaciones
		{
			//Producto junto a los meses en los que estara disponible el producto 
			//Por parte de cada importador
			public IdProducto FactoryMethod (int mes)
			{
				if (mes >= 4 & mes <= 11)
					return new Importador1 ();
				else 
				if (mes == 1 || mes == 2 || mes == 12)
					return new Importador2 ();
				//En caso de que no se encuentre ninguno de esos meses, el producto
				//No estara disponible
				else
					return new ProductoPorDefecto ();
			}
		}

		public static void Main (string[] args)
		{
			//Mostrara cuales seran las nuevas importanciones
			Importador c = new Importaciones(  );
			IdProducto producto;
			for (int i=1; i<=12; i++) 
			{
				producto = c.FactoryMethod (i);
				//Indica el producto mas el lugar de importacion
				Console.WriteLine ("Chiles " + producto.Transportacion ());
			}
		}
	}
}
