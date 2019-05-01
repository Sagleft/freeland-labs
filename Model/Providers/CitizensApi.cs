using System;
using System.Diagnostics;
using FreelandLabs.Model.Providers;
using Newtonsoft.Json;

namespace FreelandLabs.Model.Providers
{
	/// <summary>
	/// <param name="visitor">число обычных пользователей</param>
	/// <param name="citizen">число граждан</param>
	/// <param name="resident">число резидентов</param>
	/// </summary>
	public class CitizenStats {
		public int visitor  = 0;
		public int citizen  = 0;
		public int resident = 0;
	}
	
	public class CitizensApi : ApiProvider
	{
		public static CitizenStats GetStats() {
			string response = GET("https://profile.mfcoin.net/api/user/stats");
			CitizenStats stats = new CitizenStats();
			try {
				stats = JsonConvert.DeserializeObject<CitizenStats>(response);
			} catch(Exception e) {
				Debug.Print("Ошибка при десериализации CitizenStats: " + e.Message);
			}
			return stats;
		}
	}
}
