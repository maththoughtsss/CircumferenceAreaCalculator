namespace CircumferenceAreaCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variables
            string? strRadius;
            double NumRadius, circArea, pi;
            Pi = 3.14;
            //Title
            Console.WriteLine("CIRCUMFERENCE AREA CALCULATOR");
            //Input
            Console.WriteLine("Enter radius: ");            
            strRadius = Console.ReadLine();
            //Functions
            double.TryParse(strRadius, out NumRadius);
            circArea= NumRadius * NumRadius * pi;
            //Output
            Console.WriteLine($"Total Area: {circArea} u2");
        }
    }
}