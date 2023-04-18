namespace Labb1Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection myBoxes = new BoxCollection();
            Box b1 = new Box(9, 9, 9);
            Box b2 = new Box(9, 9, 9);

            myBoxes.Add(new Box(2, 4, 6));
            myBoxes.Add(new Box(5, 10, 15));
            myBoxes.Add(new Box(3, 8, 13));
            myBoxes.Add(new Box(1, 2, 3));
            myBoxes.Add(new Box(3, 7, 14));
            myBoxes.Add(b1);

            Console.WriteLine();

            myBoxes.PrintBoxes();

            Console.WriteLine();

            myBoxes.Add(b2);

            Console.WriteLine();
            myBoxes.Remove(b1);

            Console.WriteLine();
            myBoxes.PrintBoxes();
            Console.WriteLine();

            myBoxes.Add(b2);

            myBoxes.PrintBoxes();
            Console.WriteLine();

            Console.WriteLine(myBoxes.Contains(b2));
            Console.WriteLine(myBoxes.Contains(b2, new BoxSameVolume()));
            Console.WriteLine();

            myBoxes.Remove(b2);
            Console.WriteLine();

            Console.WriteLine(myBoxes.Contains(b2));
            Console.WriteLine(myBoxes.Contains(b2, new BoxSameVolume()));



        }
    }
}