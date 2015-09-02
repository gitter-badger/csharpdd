using System;

namespace PatronSingleton
{
	public class Instancia1
	{
		DateTime _fechahora;

		public Instancia1()
		{
			GetConnection(); 
		}
		
		public void GetConnection()
		{
			try
			{
				_fechahora = System.DateTime.Now.ToLocalTime();
				{Info = String.Format(_fechahora.ToString());};
			}
			catch(Exception e)
			{
				throw e;
			}
		}
 	
		public string Info {set;get;}
	}
	
	public class Instancia2
	{
		static Instancia2 _instancia = null;
		static DateTime _fechahora;
		
		private Instancia2() {}
			
		public static Instancia2 GetInstancia()
		{
			if (_instancia == null)
			{
				_instancia = new Instancia2();
				_instancia.GetConnection();
			}
			return _instancia;
		}
		
		public void GetConnection()
		{
			try
			{
				_fechahora = System.DateTime.Now.ToLocalTime();
				{Info = String.Format(_fechahora.ToString());};
			}
			catch(Exception e)
			{
				throw e;
			}
		}

		public string Info {set;get;}	
	}
}
