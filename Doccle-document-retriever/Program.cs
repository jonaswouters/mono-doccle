using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Formatting;

namespace Doccledocumentretriever
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			RunAsync().Wait();
		}

		static async Task RunAsync()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://secure.doccle.be/doccle-euui/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
					"Basic", 
					Convert.ToBase64String(
						System.Text.Encoding.ASCII.GetBytes(
							string.Format("{0}:{1}", "<USERNAME>", "<PASSWORD>"))));

				HttpResponseMessage response = await client.GetAsync("rest/v1/documents/new?lang=en");

				Console.WriteLine ("New Documents:");
				response.EnsureSuccessStatusCode();  
				if (response.IsSuccessStatusCode)
				{
					 
					var formatters = new List<MediaTypeFormatter>() {
						new HtmlAsJsonFormatter(),
						new JsonMediaTypeFormatter()
					};

					RootObject documents = await response.Content.ReadAsAsync<RootObject>(formatters);
					foreach (Document document in documents.documents) {
						Console.WriteLine("{0}", document.name);
					}
				}
			}
		}
	}
}
