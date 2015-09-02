using System;

namespace State
{
	public class Contacto
	{
		
		public Contacto ()
		{
		}
		switch (estado)
		{
		case APAGADO:
			{
				// El vehiculo arranca
				estado = PARADO;
				velocidadActual = 0;
				Console.WriteLine("El vehiculo se encuentra ahora PARADO");
				break;
			}
		case PARADO:
			{
				// El vehiculo se apaga
				estado = APAGADO;
				Console.WriteLine("El vehiculo se encuentra ahora APAGADO");
				break;
			}
		case EN_MARCHA:
			{
				// No se puede detener el vehiculo en marcha!
				Console.WriteLine("ERROR: No se puede cortar el contacto en marcha!");
				break;
			}
		default:
			break;
		}
	}
}

