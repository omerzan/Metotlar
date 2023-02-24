namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] {8,  9, 10 };
            sayilar1 = sayilar2;
            sayilar2[0] = 75;
            sayilar1[0] = 15;

            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayilar2[0]);

        }
    }
}