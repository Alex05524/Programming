internal class Program
{
    private static void Main(string[] args)
    {
        void mass()
        {
            string[] a;
            Console.WriteLine("Введите строки через пробел:");
            string line = Console.ReadLine();
            a = line.Split(' ');
            var result = new string[a.Length];
            var size = 0;
            foreach (var value in a)
            {
                if (value.Length <= 3)
                {
                    result[size] = value;
                    size++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, size));
            Console.ReadKey(true);
        }
        mass();
    }
}
