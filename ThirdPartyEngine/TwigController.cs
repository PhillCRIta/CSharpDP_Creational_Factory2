using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory2.ThirdPartyEngine
{
	internal class TwigController:Controller
	{
		protected override IViewEngine CreateViewEngine()
		{
			return new TwigViewEngine();
		}
	}
}
