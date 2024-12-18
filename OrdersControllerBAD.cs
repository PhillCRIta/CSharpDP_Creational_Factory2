using Creational_Factory2.ThirdPartyEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2
{
	internal class OrdersControllerBAD : ControllerBAD
	{
		public void ListOrders()
		{
			//example of data in database
			var orders = new Dictionary<string, object>{
				{ "Red socks", "12.98"},
				{ "T-shirt", "23.45"}
			};
			Render("order.blade.php", orders, new TwigViewEngineBAD());
		}

		public void GetOrder(int id)
		{
			//example of data in database
			var order = new Dictionary<string, object> {
				{ "Red socks", "12.98" }
			};
			Render("order.php", order, new TwigViewEngineBAD());
		}
	}
}
