namespace Assignment3_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to find value of x for y=-5 to +5
            Console.WriteLine("Values for x if y=y^2 +2y +1 for y from -5 to +5 will be: " );

            for (int y=-5; y<=5; y++)
            {
                int x= y*y + 2*y + 1;

                Console.WriteLine("When value for y={0}, then x={1}: " ,y ,x);   
            }

        }
    }
}
