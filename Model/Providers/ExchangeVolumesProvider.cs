using System;
using System.Diagnostics;
using FreelandLabs.Model.Providers;
using Newtonsoft.Json;

namespace FreelandLabs.Model.Providers
{
	public class ExchangeVolumeData {
		public string name    = ""; //название биржи
		public decimal volume = 0;  //объем торгов за 24 часа в USD
	}
	
	public class ExchangeVolumeDataContainer {
		public ExchangeVolumeData[] data;
		public decimal mfc_usd = 0;
	}
	
	public class ExchangeVolumesProvider : ApiProvider
	{
		public static ExchangeVolumeData[] GetVolumes() {
			ExchangeVolumeData[] data = new ExchangeVolumeData[] {};
			ExchangeVolumeDataContainer container = new ExchangeVolumeDataContainer();
			string response = GET("https://legend.mfcoin.su/api/exchange_volume");
			try {
				container = JsonConvert.DeserializeObject<ExchangeVolumeDataContainer>(response);
				data = container.data;
			} catch(Exception e) {
				Debug.Print("Ошибка при десериализации ExchangeVolumeData: " + e.Message);
			}
			return data;
		}
	}
}
