using System;

namespace patron_bridge
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Implementor
			public interface IMotor
			{
				void InyectarCombustible(double cantidad);
				void ConsumirCombustible();
			}

			// ImplementorConcretoA
			public class Diesel : IMotor
			{
				#region IMotor Members

				public void InyectarCombustible(double cantidad)
				{
					Console.WriteLine("Inyectando " + cantidad + " ml. de Gasoil");
				}

				public void ConsumirCombustible()
				{
					RealizarExplosion();
				}

				#endregion

				private void RealizarExplosion()
				{
					Console.WriteLine("Realizada la explosión del Gasoil");
				}
			}
			// ImplementorConcretoB
			public class Gasolina : IMotor
			{
				#region IMotor Members

				public void InyectarCombustible(double cantidad)
				{
					Console.WriteLine("Inyectando " + cantidad + " ml. de Gasolina");
				}

				public void ConsumirCombustible()
				{
					RealizarCombustion();
				}

				#endregion

				private void RealizarCombustion()
				{
					Console.WriteLine("Realizada la combustión de la Gasolina");
				}
			}
			// Abstracción
			public abstract class Vehiculo
			{
				private IMotor motor;

				public Vehiculo(IMotor motor)
				{
					this.motor = motor;
				}

				// Encapsulamos la funcionalidad de la interfaz IMotor
				public void Acelerar(double combustible)
				{
					motor.InyectarCombustible(combustible);
					motor.ConsumirCombustible();
				}

				public void Frenar()
				{
					Console.WriteLine("El vehículo está frenando.");
				}

				// Método abstracto
				public abstract void MostrarCaracteristicas();
			}
			// RefinamientoAbstraccionA
			public class Berlina : Vehiculo
			{
				// Atributo propio
				private int capacidadMaletero;

				// La implementacion de los vehículos se desarrolla de forma independiente
				public Berlina(IMotor motor, int capacidadMaletero) : base(motor)
				{
					this.capacidadMaletero = capacidadMaletero;
				}

				// Implementación del método abstracto
				public override void MostrarCaracteristicas()
				{
					Console.WriteLine("Vehiculo de tipo Berlina con un maletero con una capacidad de " + 
					                  capacidadMaletero + " litros.");
				}
			}
			public class Monovolumen : Vehiculo
			{
				// Atributo propio
				private bool puertaCorrediza;

				// La implementacion de los vehículos se desarrolla de forma independiente
				public Monovolumen(IMotor motor, bool puertaCorrediza)
					: base(motor)
				{
					this.puertaCorrediza = puertaCorrediza;
				}

				// Implementación del método abstracto
				public override void MostrarCaracteristicas()
				{
					Console.WriteLine("Vehiculo de tipo Berlina " + (puertaCorrediza ? "con" : "sin") + 
					                  " puerta corrediza.");
				}
			}
		}
	}
}
