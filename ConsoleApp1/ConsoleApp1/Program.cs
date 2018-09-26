using System;
namespace vazao
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeInicial, vazao, tempo, volumeFinal;
            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());
            if (vazao * tempo > volumeInicial)
            {
                Console.WriteLine("nao eh possivel");
            }
            else
            {
                volumeFinal = volumeInicial - (vazao * tempo);
                Console.WriteLine(volumeFinal);
            }
            Console.ReadLine();
        }
    }
}