namespace myParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many numbers would you like?");
            int val = int.Parse(Console.ReadLine());
            int[] numbers = new int[val]; 
            for (int i = 0; i < val; i++)
            {
                numbers[i]=r.Next(1, 10);
            }
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            var numberSubset = numbers[1..4];
            Console.WriteLine($"Total of the numbers array={Add(numbers)}");
            Console.WriteLine($"Product of the numbers array={Multiply(numbers)}");

        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
    }
}
