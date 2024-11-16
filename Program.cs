namespace çam_agacı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satirSayisi = 6;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < satirSayisi - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
