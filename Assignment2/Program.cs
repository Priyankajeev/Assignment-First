namespace Assignment2_SpeedCalculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking userinput as distance 
            Console.Write("Enter the distance(in km):");
            double distance= double.Parse(Console.ReadLine());

            //Taking userinput as time
            Console.Write("Enter the time(in hour):");
            double time = double.Parse(Console.ReadLine());

            //Speed=distance/time
            double speedKmPerHr = distance/time;

            //conversion from km/hr to miles /hr
            double speedMilesPerHr = speedKmPerHr * 0.621371;
            Console.WriteLine("Speed in km/hr= "+ speedKmPerHr +"Km/hr");
            Console.WriteLine("Speed in miles/hr= " + speedMilesPerHr + "Miles/hr");


        }
    }
}
