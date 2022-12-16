/*
Name : Fadil Fajar
Nim  : 2207111388
Kelas: Teknik Informatika - A
*/
using System;
using System.Collections.Generic;

namespace program{
    class program{
        static string kataMisteri = "yang";
        static int opportunity = 5;
        static List<string> listTebakan = new List<string>{};
        static void Main(string[] args){
            Intro();
            Start();
            ShowEnd();
        }
        static void Intro(){
            Console.WriteLine("Selamat datang, Hari ini kita akan bermain tebak kata");
            Console.WriteLine($"kamu punya {opportunity} kesempatan untuk menebak huruf misteri kali ini");
            Console.WriteLine("Petunjuk adalah kayta tersebut merupakan sebuah...");
            Console.WriteLine($"kata ini terdiri dari {kataMisteri.Length} karakter");
            Console.WriteLine("Bisakah Kamu Menebaknya");
        }

        static void Start(){
            while (opportunity>0){
                Console.WriteLine("Apa karakter tebakan kamu (a-z) : ");
                string input = Console.ReadLine();
                listTebakan.Add(input);

                if(cekjawaban(kataMisteri,listTebakan)){
                    Console.WriteLine("Selamat anda benar");
                    Console.WriteLine($"Kata mistrei hari ini adalah {kataMisteri}");
                    break; 
                }else if(kataMisteri.Contains(input)){
                    Console.WriteLine("Huruf itu ada dikata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    Console.WriteLine(cekHuruf(kataMisteri,listTebakan));
                }else{
                    Console.WriteLine("Huruf itu tidak ada dikata ini");
                    opportunity--;
                    Console.WriteLine($"Kesempatan anda sisa {opportunity}");
                }
                
                if(opportunity==0){
                    Console.WriteLine("Mohon maaf kesempatan anda habis");
                    Console.WriteLine($"Kata Misteri yang dimaksud adalah {kataMisteri}.");
                    Console.WriteLine("Terima kasih sudah bermain");
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia,List<string>List){
            bool status = false;
            for(int i=0;i<kataMisteri.Length;i++){
                string c = Convert.ToString(kataMisteri[i]);
                if(List.Contains(c)){
                    status = true;
                }else{
                    return status = false;
                }
            }
            return status;
        }
        static string cekHuruf(string kataMisteri,List<string>List){
            string x = "";
            for(int i=0;i<kataMisteri.Length;i++){
                string c = Convert.ToString(kataMisteri[i]);
                if(List.Contains(c)){
                    x = x + c;
                }else{
                    x = x + "_";
                }
            }
            return x;
        }static void ShowEnd(){
            if(opportunity==0){
                Console.WriteLine("Permainan sudah berakhir");
                Console.WriteLine($"Kata misteri yang sebenarnya adalah {kataMisteri}");
            }
        }
    }
}

