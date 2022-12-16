using System;
namespace program
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            Random rnd=new Random();
            int rNo=rnd.Next(0,101);
            bool guessed=false;
            int guesses=0;
            while(!guessed){
                Console.Write("Tebak angka antara 1-100 : ");
                int Inis=Convert.ToInt32(Console.ReadLine());
                guesses+=1;
                if(Inis==rNo){
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    break;
                }else if(Inis<rNo){
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }else if(Inis>rNo){
                    Console.WriteLine("Salah. Nilai terlalu tinggi.");
                }
            }
        }
    }
}