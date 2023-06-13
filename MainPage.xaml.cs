
using AR_LlamadaAPI.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AR_LlamadaAPI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void AR_GetWeatherClicked(object sender, EventArgs e)
    {
		string latitud = txtLatitud.Text;
		string longitud = txtLongitud.Text;	

		using (var client = new HttpClient()) 
		{
			var url = $"https://api.openweathermap.org/data/2.5/weather?lat=" + latitud + "&lon=" + longitud + "&appid=4352cdef1d188e5e96d91520d71f345c";

			var response = client.GetAsync(url).Result;
			if (response.IsSuccessStatusCode)
			{
				string content = response.Content.ReadAsStringAsync().Result;

				var weatherData = JsonConvert.DeserializeObject<AR_Clima>(content);



			}
        }
    }
}

