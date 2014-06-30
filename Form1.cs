using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web;

namespace TestApp
{
    public partial class Form1 : Form
    {
        int timerTic = 1;
        string Temperature;
        string Condition;
        string Humidity;
        string WindSpeed;
        string City;
        string Date;
        string TFHigh;
        string TFLow;

        public Form1()
        {
            InitializeComponent();
            temperatureTxt.ReadOnly = true;
            dateTxt.ReadOnly = true;
            cityText.ReadOnly = true;
            lowsText.ReadOnly = true;
            highsText.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetWeather()
        {
            string query = String.Format("http://weather.yahooapis.com/forecastrss?w=2407405");
            XmlDocument weatherData = new XmlDocument();
            weatherData.Load(query);
            XmlNamespaceManager manager = new XmlNamespaceManager(weatherData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            XmlNode channel = weatherData.SelectSingleNode("rss").SelectSingleNode("channel");
            XmlNodeList nodes = weatherData.SelectNodes("/rss/channel/item/yweather:forecast", manager);

            Temperature = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
            Condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
            Humidity = channel.SelectSingleNode("yweather:atmosphere", manager).Attributes["humidity"].Value;
            WindSpeed = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;
            City = channel.SelectSingleNode("yweather:location", manager).Attributes["city"].Value;
            //Date = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition").Attributes["date"].Value;
            TFHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
            TFLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetWeather();
            temperatureTxt.Text = Temperature;
            dateTxt.Text = Condition;
            cityText.Text = City;
            highsText.Text = TFHigh;
            lowsText.Text = TFLow;
        }

        private void update_Tick(object sender, EventArgs e)
        {
            timerTic = timerTic - 1;
            if (timerTic == 0)
            {
                //temperatureTxt.Clear();
                //dateTxt.Clear();
                GetWeather();
                timerTic = 1;

            }
        }

    }
}
