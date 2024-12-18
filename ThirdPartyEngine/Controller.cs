using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2.ThirdPartyEngine
{
	internal class Controller
	{
		protected void Render(string fileName, Dictionary<string, object> data )
		{
			var viewEngine = CreateViewEngine();
			var html = viewEngine.Render(fileName, data);
			Console.WriteLine("Write html: " + html);
		}

		//CREATE VIEW ENGINE IS A FACTORY
		//base of which class extend the sub controllers
		//CreateViewEngine is a factory method that returns new object
		//you can also use a abstract method instead virtual, in this case you must create another BladeController class and implement the concrete method
		protected virtual IViewEngine CreateViewEngine()
		{
			return new BladeViewEngine();
		}
	}
}
