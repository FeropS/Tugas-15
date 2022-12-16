using System;
namespace program
{
    class Program
    {
        static void Main(string[] args){
            int waktuPinjam;
            int denda;
            int dendaPertama;
            int dendaKedua;
            int dendaKetiga;
            int uangDenda1;
            int uangDenda2;
            Console.Write("Input jumlah hari peminjaman : ");
            waktuPinjam= Convert.ToInt32(Console.ReadLine());
            //if1
            dendaPertama=waktuPinjam-5;
            denda=10000;
            //if2
            dendaKedua=waktuPinjam-10;
            uangDenda1=20000;
            int Denda1=50000;
            int denda2=uangDenda1*dendaKedua;
            denda2=denda2+Denda1;
            //if3
            dendaKetiga=waktuPinjam-30;
            uangDenda2=30000;
            int Denda2=40000;
            int denda3=uangDenda2*dendaKetiga;
            denda3=denda3+Denda1+Denda2;
            if(waktuPinjam>5&&waktuPinjam<=10){
                Console.Write("Total Denda : Rp."+denda*dendaPertama);
            }else if(waktuPinjam>10&&waktuPinjam<=30){
                Console.Write("Total Denda : Rp."+denda2);
            }else if(waktuPinjam<=5){
                Console.Write("Total Denda : Rp.0");
            }else{
                Console.WriteLine("Keanggotaan anda dibatalkan");
                Console.Write("Total Denda : Rp."+denda3);
            }
        }
    }
}