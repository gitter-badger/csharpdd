using System;

namespace patron1bridgecsharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Abstraction ab = new RefinedAbstraction();
			// Set implementation and call
			ab.Implementor = new ConcreteImplementorA();
			ab.Operation();
			// cambiar la implementacion y llamarla
			ab.Implementor = new ConcreteImplementorB();
			ab.Operation();
			Console.ReadKey();
		}
	}
	/// <summary>
	/// clase abstraccion
	/// </summary>
	class Abstraction
	{
		protected Implementor implementor;
		// Property
		public Implementor Implementor
		{
			set { implementor = value; }
		}
		public virtual void Operation()
		{
			implementor.Operation();
		}
	}
	/// <summary>
	/// The 'Implementor' abstract class
	/// </summary>
	abstract class Implementor
	{
		public abstract void Operation();
	}
	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	class RefinedAbstraction : Abstraction
	{
		public override void Operation()
		{
			implementor.Operation();
		}
	}
	/// <summary>
	/// The 'ConcreteImplementorA' class
	/// </summary>
	class ConcreteImplementorA : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("concreto el implemento A esta funcionando");
		}
	}
	/// <summary>
	/// The 'ConcreteImplementorB' class
	/// </summary>
	class ConcreteImplementorB : Implementor

	{
		public override void Operation()

		{
			Console.WriteLine("concreto el implemento B esta funcionando");
		}

	}
}
