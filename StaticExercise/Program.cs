namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celsius = TempConverter.FahrenheitToCelsius(63);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(93);

            Console.WriteLine($" Conversions =\n Far to Cels: {Celsius} \n Cels to Far: {fahrenheit}");
        }
    }

    
}
