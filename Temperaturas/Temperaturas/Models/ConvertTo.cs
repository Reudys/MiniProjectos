namespace Temperaturas.Models
{
    class ConvertTo
    {
        //Attributes
        double temp;

        //Constructor
        public ConvertTo(double temp)
        {
            this.temp = temp;
        }

        //Methods
        public double CelsiusToFahrenheit(double temp)
        {
            double f = (temp * 9 / 5) + 32;
            return f;
        }

        public double FahrenHeatToCelsius(double temp)
        {
            double c = (temp - 32) * 5 / 9;
            return c;
        }

        public double CelsiusToKelvin(double temp)
        {
            double k = temp + 273.15;
            return k;
        }

        public double KelvinToCelsius(double temp)
        {
            double c = temp - 273.15;
            return c;
        }

        public double FahrenheitToKelvin(double temp)
        {
            double k = ((temp - 32) * 5 / 9) + 273.15;
            return k;
        }

        public double KelvinToFahrenheit(double temp)
        {
            double f = ((temp - 273.15) * 9 / 5) + 32;
            return f;
        }
    }
}