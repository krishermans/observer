using System;

namespace observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        //private Subject wheaterData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            //this.wheaterData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            string line = String.Format("Current conditions: {0:f1}F degrees and {1:f1}% humidity",
                                        temperature, humidity);
            Console.WriteLine(line);
        }
    }
}
