using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2.ThirdPartyEngine
{
	internal interface IViewEngineBAD
	{
		string Render(string fileName, Dictionary<string, object> data);
	}
}
