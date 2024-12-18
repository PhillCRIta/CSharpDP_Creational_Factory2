using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2.ThirdPartyEngine
{
	internal class ControllerBAD
	{
		public void Render(string fileName, Dictionary<string, object> data, IViewEngineBAD viewEngine)
		{
			//var viewEngine = new BladeViewEngineBAD(); >> pass from parameter
			var html = viewEngine.Render(fileName, data);
			Console.WriteLine("Write html: " + html);
		}
	}
}
