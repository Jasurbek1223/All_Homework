namespace LeetCode
{
    internal class Program
    {
        public static int count = 0;
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            if(numBottles < numExchange)
            {
                return count;
            }
            count += numBottles/numExchange;
            int r = numBottles % numExchange;
            numBottles = numBottles / numExchange + r;
            
            return NumWaterBottles(numBottles, numExchange);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumWaterBottles(15,4));
        }
    }
}

