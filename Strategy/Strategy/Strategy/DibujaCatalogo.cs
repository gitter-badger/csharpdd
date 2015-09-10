using System;
using System.Collections.Generic;

namespace Strategy
{
	public interface DibujaCatalogo
	{
		void dibuja(IList<VistaVehiculo> contenido);
	}
}