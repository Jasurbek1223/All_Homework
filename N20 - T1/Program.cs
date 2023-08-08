namespace N20___T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Masala
            var number = new int[] { 4, 2, 3, 8, 5, 12, -4, 9 };

            BubbleSort nimadur = new BubbleSort();
            nimadur.Sort(ref number);
            
            foreach (int i in number)
                Console.Write(i + " ");
           Console.WriteLine();


            // 2- Masala
            nimadur.Area(5,6,out int P,out int S);
            Console.WriteLine($"\nYuzasi: {S}");
            Console.WriteLine($"Perimetri: {P}\n");


            // 3- Masala
            nimadur.FindMaxMin(out int max, out int min, number);
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}\n");

            // 4- Masala
            Person person = new Person(name:"Jasur",age: 20);
            person.Display();


        }
    }
}