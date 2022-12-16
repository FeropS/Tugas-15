using System;
namespace Program
{
    class Program
    {
        static Random option= new Random();
        static int win;
        static int lose;
        static int draw;
        static bool playGame;
        static void Main(string[] args){
            playGame=true;
            while(playGame){
                Console.Clear();
                Console.WriteLine("Batu,Gunting,Kertas");
                Console.Write("\nChoose [b]atu,[g]unting,[k]ertas,or [e]xit:");
                string yourAnswer=Console.ReadLine();
                if(yourAnswer=="e"){
                    break;
                }
                int computerAnswer=option.Next(0,3);
                if(computerAnswer==0){
                    Console.WriteLine("Komputer memilih batu.");
                    switch (yourAnswer){
                        case "b":
                        Console.WriteLine("Seri.");
                        draw++;
                        break;
                        case "g":
                        Console.WriteLine("Anda kalah.");
                        lose++;
                        break;
                        case "k":
                        Console.WriteLine("Anda menang.");
                        win++;
                        break;
                    }
                }else if(computerAnswer==1){
                    Console.WriteLine("Komputer memilih gunting.");
                    switch(yourAnswer){
                        case "b":
                        Console.WriteLine("Anda menang.");
                        win++;
                        break;
                        case "g":
                        Console.WriteLine("Seri.");
                        draw++;
                        break;
                        case "k":
                        Console.WriteLine("Anda kalah.");
                        lose++;
                        break;
                    }
                }else{
                    Console.WriteLine("Komputer memilih kertas.");
                    switch(yourAnswer){
                        case "b":
                        Console.WriteLine("Anda kalah.");
                        lose++;
                        break;
                        case "g":
                        Console.WriteLine("Anda Menang.");
                        win++;
                        break;
                        case "k":
                        Console.WriteLine("Seri.");
                        draw++;
                        break;
                    }
                }
                Console.WriteLine("Skor:"+win+" menang, "+lose+" kalah, "+draw+" seri");
                Console.WriteLine("Tekan enter untuk melanjutkan permainan...");
                while(Console.ReadKey().Key !=ConsoleKey.Enter){
                    Console.Clear();
                    playGame=true;
                }

            }
        }
    }
}