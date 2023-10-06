namespace DSHUshtrimi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] array = new Animal[]
            {
            new Dog(30, "Bubi"),
            new Cat(5, "Pufi"),
            new Dog(22, "Luna"),
            new Cat(11, "Mia"),
            new Dog(100, "Balo"),
            new Cat(20, "Garfild"),

            };

            foreach (Animal a in array)
            {
                a.Move();
                a.Speak();
                Console.WriteLine(a.ToString());
            }

            Console.ReadKey();
        }
    }
}