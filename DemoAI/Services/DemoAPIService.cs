using System.IO;
namespace DemoAI.Services
{
	public class DemoGeneric
	{
		public void DemoApiService(string entity)
		{

			File.AppendAllText($@"C:\Codebase\Demo\SampleFile.txt",  entity);
			

		}
	}
}
