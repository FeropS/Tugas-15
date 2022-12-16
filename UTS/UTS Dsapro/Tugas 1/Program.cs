using System;
namespace program
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Nama :");
            string Name=Console.ReadLine();
            Console.WriteLine("Nim  :");
            string Nim=Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            string Konsentrasi=Console.ReadLine();
            Console.WriteLine("|**********************|");
            Console.WriteLine("|Nama:{0,17}|",Name);
            Console.WriteLine("|{0,22}|",Nim);
            Console.WriteLine("|----------------------|");
            Console.WriteLine("|{0,22}|",Konsentrasi);
            Console.WriteLine("|**********************|");
        }
    }
}