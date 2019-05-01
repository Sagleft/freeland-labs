using System;
using System.Diagnostics;
using FreelandLabs.Model.Providers;
using Newtonsoft.Json;

namespace FreelandLabs.Model.Providers
{
	public class CourseLocal {
		public decimal USD = 0;
		public decimal EUR = 0;
		public decimal KZT = 0;
		public decimal UAH = 0;
		public decimal RUB = 0;
		public decimal CNY = 0;
		public decimal JPY = 0;
	}
	
	public class CourseCrypto {
		public decimal BTC  = 0;
		public decimal LTC  = 0;
		public decimal DOGE = 0;
		public decimal ETH  = 0;
		public decimal DASH = 0;
		public decimal DGB  = 0;
		public decimal USDT = 0;
	}
	
	public class CourseProvider : ApiProvider
	{
		public static CourseLocal GetLocalCourse() {
			string response = GET("http://api.mfc-market.ru/ticker_local");
			CourseLocal data = new CourseLocal();
			try {
				data = JsonConvert.DeserializeObject<CourseLocal>(response);
			} catch(Exception e) {
				Debug.Print("Ошибка при десериализации CourseLocal: " + e.Message);
			}
			return data;
		}
		
		public static CourseCrypto GetCryptoCourse() {
			string response = GET("http://api.mfc-market.ru/ticker_crypto");
			CourseCrypto data = new CourseCrypto();
			try {
				data = JsonConvert.DeserializeObject<CourseCrypto>(response);
			} catch(Exception e) {
				Debug.Print("Ошибка при десериализации CourseCrypto: " + e.Message);
			}
			return data;
		}
	}
}
