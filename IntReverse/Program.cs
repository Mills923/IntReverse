using System;

namespace IntReverse
{
    class Program
    {
        public static void Number(int input)
        {
            string holder = input.ToString();
            string result = "";
            int counter = 0;
            for (int i = holder.Length - 1; i >= 0; i--)
            {
                if (holder[i] == '-')
                {
                    goto Skip;
                }
                result += holder[i];
            }
            Skip:

            Console.WriteLine($"The number you passed in was: {input} \n Reversed is: {result}");
        }

        static void Main(string[] args)
        {
            Number(-100);
            Number(1254634534);
        }
    }
}
