using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestObserver.mocks;
using observer;

namespace UnitTestObserver
{
	[TestClass]
	public class ForecastDisplayTest
	{
        private ConsoleMock console;
        private WeatherData weatherData;
        private Observer display;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
            weatherData = new WeatherData();
            display = new ForecastDisplay(weatherData);
        }

        [TestMethod]
		public void Improving()
		{
            string expected = "Forecast: Improving weather on the way!";
            weatherData.SetMeasurements(82, 70, 30.4f);
            Assert.AreEqual(expected, console.Output());
        }

        [TestMethod]
        public void MoreOfTheSame()
        {
            string expected = "Forecast: More of the same";
            weatherData.SetMeasurements(80, 65, 29.92f);
            Assert.AreEqual(expected, console.Output());

        }

        [TestMethod]
        public void CoolerRainy()
        {
            string expected = "Forecast: Watch out for cooler, rainy weather";
            weatherData.SetMeasurements(80, 65, 25.6f);
            Assert.AreEqual(expected, console.Output());
        }
	}
}
