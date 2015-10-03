using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestObserver.mocks;
using observer;

namespace UnitTestObserver
{
    [TestClass]
    public class CurrentConditionsDisplayTest
    {
        private ConsoleMock console;
        private WeatherData weatherData;
        private Observer display;

        [TestInitialize]
        public void SetUp()
        {
            console = new ConsoleMock();
            weatherData = new WeatherData();
            display = new CurrentConditionsDisplay(weatherData);
        }

        [TestMethod]
        public void TestCurrentConditionsDisplay()
        {
            weatherData.SetMeasurements(80f, 65f, 30.4f);
            string expected = String.Format("Current conditions: {0:f1}F degrees and {1:f1}% humidity",
                                        80f, 65f);
            Assert.AreEqual(expected, console.Output());
        }
    }
}
