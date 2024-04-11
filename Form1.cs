using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using RestSharp;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string Weather;
        string Temperature;
        string Wind;
        string Humidity;
        string MoonPhase;
        string UVIndex;
        string Pressure;
        string TempFeelsLike;
        string LocalTime;
        string Location;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=j1");
            var client2 = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%t+%w+%h+%u+%P+%f+%Z+%l");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.ExecuteGet(request);
            var response2 = client2.ExecuteGet(request);

            string regExp = "[^\\w\\d]";

            if (response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response2.Content, " ");

                dynamic data = JsonConvert.DeserializeObject(response.Content);
                Weather = data.current_condition[0].weatherDesc[0].value;

                Temperature = weatherParameters[0];
                Wind = Regex.Replace(weatherParameters[1], regExp, "");
                Humidity = weatherParameters[2];
                UVIndex = weatherParameters[3];
                Pressure = weatherParameters[4];
                TempFeelsLike = weatherParameters[5];
                LocalTime = weatherParameters[6];
                Location = weatherParameters[7].Replace("+", " ");

                foreach (string line in weatherParameters)
                {
                    // Print the current item using Console.WriteLine
                    Console.WriteLine(line);
                }

                if (Weather.ToLower().Contains("sun"))
                {
                    imageBox.Image = Properties.Resources.sunny_dayG;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Weather.ToLower().Contains("wind"))
                {
                    imageBox.Image = Properties.Resources.windG;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Weather.ToLower().Contains("snow"))
                {
                    imageBox.Image = Properties.Resources.snowflakeG;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Weather.ToLower().Contains("rain") || Weather.ToLower().Contains("mist"))
                {
                    imageBox.Image = Properties.Resources.rainyG;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Weather.ToLower().Contains("cloud"))
                {
                    imageBox.Image = Properties.Resources.cloudyG;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                DisplayData();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }

        private void DisplayData()
        {

            locationLabel.Text = "Location: " + Location;
            weatherLabel.Text = "Weather: " + Weather;
            tempLabel.Text = "Temperature: " + Temperature;
            windLabel.Text = "Wind: " + Wind;
            humidityLabel.Text = "Humidity: " + Humidity;
            uvLabel.Text = "UV Index: " + UVIndex;
            pressureLabel.Text = "Pressure: " + Pressure;
            tempFeelsLikeLabel.Text = "Temp (feels like): " + TempFeelsLike;
            localTimeLabel.Text = "Local Time Zone: " + LocalTime;

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(locationTextBox.Text != "")
            {
                try
                {
                    GetWeatherData(locationTextBox.Text);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error!");
                }
            }
        }

        private void locationTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && locationTextBox.Text != "")
            {
                try
                {
                    GetWeatherData(locationTextBox.Text);
                    e.SuppressKeyPress = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
