class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");

        string enteredValue = Console.ReadLine();

        try
        {
            int parsed = Int32.Parse(enteredValue);
            if (parsed < 0)
            {
                throw new ArgumentException();
            }

            Console.WriteLine("Square root = " + Math.Sqrt(parsed));
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

        Console.ReadKey();
    }
}
