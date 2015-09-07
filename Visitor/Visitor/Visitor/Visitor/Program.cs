using System;
using Gtk;

namespace Visitor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			AUsuario c = new Cliente();
			// Supongamos que nuestro programa recibe un Usuario x.
			if (c.getTipo().equals("cliente")) {
				System.out.println("Soy un cliente");
				System.out.println("descuento: 10%");
			} else if (c.getTipo().equals("operador")) {
				System.out.println("Soy un operador");
				System.out.println("descuento: 30%");
			}

			public interface UsuarioVisitor {

				void visit(Cliente cliente);
				void visit(Operador operador);
			}

			public class UsuarioPrintVisitor implements UsuarioVisitor {

				@Override
				public void visit(Cliente cliente) {
					System.out.println("Soy un cliente");
				}

				@Override
				public void visit(Operador operador) {
					System.out.println("Soy un operador");
				}

			}

			public class UsuarioDescuentoVisitor implements UsuarioVisitor {

				private float descuento;

				@Override
				public void visit(Cliente cliente) {
					descuento = 10;
				}

				@Override
				public void visit(Operador operador) {
					descuento = 30;
				}

				public float getDescuento() {
					return descuento;
				}
			}

			public interface Usuario {

				void accept(UsuarioVisitor visitor);
			}

			public class Cliente implements Usuario {

				@Override
				public void accept(UsuarioVisitor visitor) {
					visitor.visit(this);
				}

			}

			public class Operador implements Usuario {

				@Override
				public void accept(UsuarioVisitor visitor) {
					visitor.visit(this);
				}

			}
		}
	}
}