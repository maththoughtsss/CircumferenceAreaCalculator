namespace CircumferenceAreaCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? strRadius;

            double NumRadius, circArea, Pi;
            Pi = 3.14;

            Console.WriteLine("CIRCUMFERENCE AREA CALCULATOR");
            Console.WriteLine("Enter radius: ");

            strRadius = Console.ReadLine();
            double.TryParse(strRadius, out NumRadius);

            circArea= NumRadius * NumRadius * Pi;

            Console.WriteLine($"Total Area: {circArea} u2");
        }
    }
}