using Creational_Factory2.ThirdPartyEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2
{
	internal class OrdersController : Controller
	//internal class OrdersController : TwigController // you can change the parent class to select which type controller of use
	{
		public void ListOrders()
		{
			//example of data in database
			var orders = new Dictionary<string, object>{
				{ "Red socks", "12.98"},
				{ "T-shirt", "23.45"}
			};
			//the type of template is inherited by the superclass
			Render("order.blade.php", orders);
		}

		public void GetOrder(int id)
		{
			//example of data in database
			var order = new Dictionary<string, object> {
				{ "Red socks", "12.98" }
			};
			Render("order.php", order);
		}
	}
}
