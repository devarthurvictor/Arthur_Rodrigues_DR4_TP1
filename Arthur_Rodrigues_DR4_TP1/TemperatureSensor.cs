using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthur_Rodrigues_DR4_TP1
{
    internal class TemperatureSensor
    {
        public event EventHandler<double> TemperatureExceeded;

        public void ReadTemperature(double temperature)
        {
            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(this, temperature);
            }
            else
            {
                Console.WriteLine($"Temperatura normal: {temperature}°C");
            }
        }

        
    }
}
