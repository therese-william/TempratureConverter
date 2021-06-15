using System;
using System.Collections.Generic;
using System.Text;

namespace TempratureConverter.BL
{
    public class Temprature
    {
        int celsius;
        double kelvin; 
        int fahrenheit;

        public int Celsius 
        { 
            get => celsius; 
            set
            {
                celsius = value;
                kelvin = value + 273.15f;
                fahrenheit = 32 + (int)((9f / 5f) * value);
            }
        }
        public double Kelvin 
        { 
            get => Math.Round(kelvin,2);
            set
            {
                kelvin = Math.Round(value,2);
                celsius = (int)Math.Round(value - 273.15);
                fahrenheit = (int) (32 + Math.Round((9f / 5f) * (value - 273.15)));
            }
        }
        public int Fahrenheit 
        { 
            get => fahrenheit;
            set
            {
                fahrenheit = value;
                celsius = ((value - 32) * 5) / 9;
                kelvin = (((value - 32d) * 5d) / 9d) + 273.15d;
            }
        }
    }
}
