namespace Creational_Factory2.ThirdPartyEngine
{
	internal class TwigViewEngine : IViewEngine
	{
		public string Render(string fileName, Dictionary<string, object> data)
		{
			return "View rendered from " + fileName + " by Twig";
		}
	}
}