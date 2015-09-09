using System;
using System.Collections.Generic;

namespace MementoV1
{
	class MainClass
	{
		public interface Memento
		{
		}
		public class MementoImpl : Memento
		{
			protected IList<OpcionVehiculo> opciones =
				new List<OpcionVehiculo>();
			public IList<OpcionVehiculo> estado
			{
				get
				{
					return opciones;
				}
				set
				{
					this.opciones.Clear();
					foreach (OpcionVehiculo opcion in value)
						this.opciones.Add(opcion);
				}
			}
		}

		public class CarritoOpciones
		{
			protected IList<OpcionVehiculo> opciones =
				new List<OpcionVehiculo>();
			public Memento agregaOpcion (OpcionVehiculo
				opcionVehiculo)
			{
				MementoImpl resultado = new MementoImpl ();
				resultado.estado = opciones;
				IList<OpcionVehiculo> opcionesIncompatibles =
					opcionVehiculo.opcionesIncompatibles;
				foreach (OpcionVehiculo opcion in
					opcionesIncompatibles)
					opciones.Remove (opcion);
				opciones.Add (opcionVehiculo);
				return resultado;
			}

			public void anula (Memento memento)
			{
				MementoImpl mementoImplInstance = memento as MementoImpl;
				if (mementoImplInstance == null)
					return;
				opciones = mementoImplInstance.estado;
			}

			public void visualiza ()
			{
				Console.WriteLine ("Contenido del carrito de opciones");
				foreach (OpcionVehiculo opcion in opciones)
					opcion.visualiza ();
				Console.WriteLine ();
			}
		}

		public class OpcionVehiculo
		{
			protected string nombre;

			public IList<OpcionVehiculo> opcionesIncompatibles
			{ get; protected set; }

			public OpcionVehiculo (string nombre)
			{
				opcionesIncompatibles = new List<OpcionVehiculo> ();
				this.nombre = nombre;
			}

			public void agregaOpcionIncompatible (OpcionVehiculo
				opcionIncompatible)
			{
				if (!opcionesIncompatibles.Contains (opcionIncompatible)) {
					opcionesIncompatibles.Add (opcionIncompatible);
					opcionIncompatible.agregaOpcionIncompatible (this);
				}
			}

			public void visualiza ()
			{
				Console.WriteLine ("opción: " + nombre);
			}
		}

		public class Usuario
		{
			static void Main (string[] args)
			{
				Memento memento;
				OpcionVehiculo opcion1 = new OpcionVehiculo (
					"Asientos en cuero");

				OpcionVehiculo opcion2 = new OpcionVehiculo (
					"Reclinables");
				OpcionVehiculo opcion3 = new OpcionVehiculo (
					"Asientos deportivos");
				opcion1.agregaOpcionIncompatible (opcion3);
				opcion2.agregaOpcionIncompatible (opcion3);
				CarritoOpciones carritoOpciones = new CarritoOpciones ();
				carritoOpciones.agregaOpcion (opcion1);
				carritoOpciones.agregaOpcion (opcion2);
				carritoOpciones.visualiza ();
				memento = carritoOpciones.agregaOpcion (opcion3);
				carritoOpciones.visualiza ();
				carritoOpciones.anula (memento);
				carritoOpciones.visualiza ();
			}
		}
	}
}