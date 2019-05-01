using System;
using System.Linq;
using System.Collections.Generic;
using FreelandLabs.Model.Providers;

namespace FreelandLabs.Controller
{
	/// <summary>
	/// Description of Loader.
	/// </summary>
	public class Loader
	{
		CitizenStats stats;
		CourseLocal local_course;
		CourseCrypto crypto_course;
		
		public Loader() {
			stats = CitizensApi.GetStats();
			local_course  = CourseProvider.GetLocalCourse();
			crypto_course = CourseProvider.GetCryptoCourse();
		}
		
		public int getVisitorCount() {
			return stats.visitor;
		}
		
		public int getResidentCount() {
			return stats.resident;
		}
		
		public int getCitizenCount() {
			return stats.citizen;
		}
		
		public List<string> LocalCourseList() {
			//TODO: придумать другой метод
			//но мне охота спать и пока сойдет так
			List<string> list = new List<string>();
			list.Add("1 MFC = " + local_course.USD.ToString() + " USD");
			list.Add("1 MFC = " + local_course.RUB.ToString() + " RUB");
			list.Add("1 MFC = " + local_course.EUR.ToString() + " EUR");
			list.Add("1 MFC = " + local_course.KZT.ToString() + " KZT");
			list.Add("1 MFC = " + local_course.UAH.ToString() + " UAH");
			list.Add("1 MFC = " + local_course.CNY.ToString() + " CNY");
			list.Add("1 MFC = " + local_course.JPY.ToString() + " JPY");
			return list;
		}
		
		public List<string> LocalCryptoList() {
			List<string> list = new List<string>();
			list.Add("1 MFC = " + crypto_course.BTC.ToString()  + " BTC");
			list.Add("1 MFC = " + crypto_course.LTC.ToString()  + " LTC");
			list.Add("1 MFC = " + crypto_course.DOGE.ToString() + " DOGE");
			list.Add("1 MFC = " + crypto_course.ETH.ToString()  + " ETH");
			list.Add("1 MFC = " + crypto_course.DASH.ToString() + " DASH");
			list.Add("1 MFC = " + crypto_course.DGB.ToString()  + " DGB");
			list.Add("1 MFC = " + crypto_course.USDT.ToString() + " USDT");
			return list;
		}
	}
}
