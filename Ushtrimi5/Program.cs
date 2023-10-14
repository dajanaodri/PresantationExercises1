class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        Dictionary<int, int> res = new Dictionary<int, int>();

        foreach (int item in array)
        {
            if (!res.ContainsKey(item))
            {
                res.Add(item, 1);
            }
            else
            {
                res[item]++;
            }
        }


        foreach (KeyValuePair<int, int> pair in res)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value + " times");
        }

        Console.ReadKey();
    }
}
