using System;
using SenseHome.DataTransferObjects.Base;

namespace SenseHome.DataTransferObjects.TemperatureHumidity
{
    public class TemperatureHumidityDto : BaseDto
    {
        public string Topic { get; set; }
        public double Temperature { get; set; } // Celsius format
        public double Humidity { get; set; } // % format
        public DateTime Date { get; set; }
    }
}
