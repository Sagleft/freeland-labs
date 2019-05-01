using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using FreelandLabs.Model.Providers;

namespace FreelandLabs.Model.Providers
{
	public abstract class ApiProvider
	{
		protected static string GET(string url) {
			string Out = "";
			try {
				WebRequest req = System.Net.WebRequest.Create(url);
				WebResponse resp = req.GetResponse();
				Stream stream = resp.GetResponseStream();
				StreamReader sr = new StreamReader(stream);
				Out = sr.ReadToEnd();
				sr.Close();
			} catch(WebException exc) {
				Debug.Print("Отловлена ошибка при GET запросе: " + exc.Message + ", при запросе: " + url);
			}
			
			return Out;
		}
	}
}
