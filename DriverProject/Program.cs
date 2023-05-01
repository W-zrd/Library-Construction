
using AljabarLibraries;
internal class Program
{
    private static void Main(string[] args)
    {
        double[] pers1 = { 1, -3, -10 };
        double[] pers2 = { 2, -4 };
        PersamaanKuadrat persKuadrat = new PersamaanKuadrat();

        double[] hasilAkar = persKuadrat.akarPersamaanKuadrat(pers1);
        double[] hasilKuadrat = persKuadrat.hasilKuadrat(pers2);

        Console.WriteLine("Hasil akar persamaan kuadrat:");
        foreach (double akar in hasilAkar)
        {
            Console.Write(akar + " ");
        }

        Console.WriteLine("\nHasil kuadrat:");
        foreach (double hasil in hasilKuadrat)
        {
            Console.Write(hasil + " ");
        }

        
    }
}