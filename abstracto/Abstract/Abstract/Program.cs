using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary>
	/// Abstract Factory. En este caso, la hemos implementado usando
	/// una interfase, aunque también puede ser una clase abstracta
	/// </summary>
	public interface IWidgetFactory
	{
		Window CreateWindow();
		Scrollbar CreateScrollbar();
	}

	/// <summary>
	/// Concrete Factory (Fabrica Concreta)
	/// </summary>
	public class WindowsWidgetFactory : IWidgetFactory
	{
		public Window CreateWindow()
		{
			return new WindowsWindow();
		}

		public Scrollbar CreateScrollbar()
		{
			return new WindowsScrollbar();
		}
	}

	/// <summary>
	/// Concrete Factory (Fabrica Concreta)
	/// </summary>
	public class MacWidgetFactory : IWidgetFactory
	{
		public Window CreateWindow()
		{
			return new MacWindow();
		}

		public Scrollbar CreateScrollbar()
		{
			return new MacScrollbar();
		}
	}

	/// <summary>
	/// Producto
	/// </summary>
	public abstract class Window
	{
		public abstract void Render();
	}

	/// <summary>
	/// Producto
	/// </summary>
	public abstract class Scrollbar
	{
		public abstract void Render();
	}

	/// <summary>
	/// Producto Concreto (Scrollbar para Windows)
	/// </summary>
	public class WindowsScrollbar : Scrollbar
	{
		public override void Render()
		{
			Console.WriteLine("Pintando Scrollbar de Windows...");
		}
	}

	/// <summary>
	/// Producto Concreto (Ventana para Windows)
	/// </summary>
	public class WindowsWindow : Window
	{
		public override void Render()
		{
			Console.WriteLine("Pintando Ventana de Windows...");
		}
	}

	/// <summary>
	/// Producto Concreto (Scrollbar para Mac)
	/// </summary>
	public class MacScrollbar : Scrollbar
	{
		public override void Render()
		{
			Console.WriteLine("Pintando Scrollbar de Mac...");
		}
	}

	/// <summary>
	/// Producto Concreto (Ventana para Mac)
	/// </summary>
	public class MacWindow : Window
	{
		public override void Render()
		{
			Console.WriteLine("Pintando Ventana de Mac...");
		}
	}

	class TestClient
	{
		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			/// Creo los objetos para windows
			IWidgetFactory factory = new WindowsWidgetFactory();
			Scrollbar scrollbar = factory.CreateScrollbar();
			Window window = factory.CreateWindow();
			window.Render();
			scrollbar.Render();

			/// Ahora, lo mismo pero para Mac. 
			/// Al cambiar el tipo del factory, todos los objetos que 
			/// se crean mediante ella son de la misma familia
			factory = new MacWidgetFactory();
			scrollbar = factory.CreateScrollbar();
			window = factory.CreateWindow();
			window.Render();
			scrollbar.Render();
		}
	}
}

