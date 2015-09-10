using System;
using System.Web.Mvc;
using MvcApplication1.Models;
//PATRON MVC
namespace MvcApplication1.Models
{
	public class Client
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }

	}
}

namespace MvcApplication1.Controllers
{
	public class BasicController:Controller
	{
		public ActionResult ClientDetail()
		{
			var clientModel = new Client()
			{
				Id = Guid.NewGuid(),
				FirstName = "Pedro",
				SurName = "Herrarte"
			};
			return View(clientModel);
		}
	}
}
