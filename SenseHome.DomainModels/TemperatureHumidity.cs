using System;
using SenseHome.DomainModels.Base;

namespace SenseHome.DomainModels
{
    public class TemperatureHumidity : BaseEntity
    {
        public string Topic { get; set; }
        public double Temperature { get; set; } // Celsius format
        public double Humidity { get; set; } // % format
        public DateTime Date { get; set; }
    }
}
