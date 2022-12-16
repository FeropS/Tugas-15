/*
Nama  : Fadil Fajar
NIM   : 2207111388
Kelas : Teknik Informatika - A
Tugas :BattleTank
*/
using System;
namespace program{
    class program{
        static void Main(string[]args){
            //Inisialisasi Variabel yang di Butuhkan
            int panjangArea=5;
            char rumput='~';
            char tank='t';
            char hit='x';
            char miss='0';
            int jumlahTank=3;

            char[,] playArea=buatRuang(panjangArea,rumput,tank,jumlahTank);
            printRuangan(playArea,rumput,tank);
            int jumlahTankTersembunyi=jumlahTank;
            //Gameplay
            while (jumlahTankTersembunyi>0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea= verifikasiTebakan(tebakanKoordinat,playArea,tank,rumput,hit,miss);
                if(updateTampilanArea==hit){
                    jumlahTankTersembunyi--;
                }
                playArea=updateArea(playArea,tebakanKoordinat,updateTampilanArea);
                printRuangan(playArea,rumput,tank);
            }
            Console.WriteLine("Game Over");
            Console.Read();
        }
        //Membuat Area 
        private static char[,] buatRuang(int panjangArea,char rumput,char tank,int jumlahTank){
            char[,] ruangan=new char[panjangArea,panjangArea];
            for(int baris=0;baris<panjangArea;baris++){
                for(int kolom=0;kolom<panjangArea;kolom++){
                    ruangan[baris,kolom]=rumput;
                }
            }
            return letakTank(ruangan,jumlahTank,rumput,tank);
        }
        //Meletakkan Tank Dalam Area
        private static char[,] letakTank(char[,] ruangan,int jumlahTank,char rumput,char tank){
            int letakTank=0;
            int panjangArea=5;
            while(letakTank<jumlahTank){
                int[] lokasiTank=tentukanKoordinatTank(panjangArea);
                char posisi=ruangan[lokasiTank[0],lokasiTank[1]];
                if(posisi==rumput){
                    ruangan[lokasiTank[0],lokasiTank[1]]=tank;
                    letakTank++;
                }
            }
            return ruangan;
        }
        private static char[,] updateArea(char[,] playArea,int[] tebakKoordinat,char updateTampilanArea){
            int baris=tebakKoordinat[0];
            int kolom=tebakKoordinat[1];
            playArea[baris,kolom]=updateTampilanArea;
            return playArea;
        }
        //Menentukan koordinat tank (x,y) Secara Acak
        private static int[] tentukanKoordinatTank(int panjangArea){
            Random rnd=new Random();
            int[] koordinat=new int[2];
            for(int i=0;i<koordinat.Length;i++){
                koordinat[i]=rnd.Next(panjangArea);//x= random(0,4); y=random(0,4)
            }
            return koordinat;
        }
        //Menampilkan area permainan ke consol
        private static void printRuangan(char[,] playArea,char rumput,char tank){
            Console.Write("");
            for(int i=0;i<=5;i++){
                Console.Write(i+0+" ");//1 2 3 4 5 
            }
            Console.WriteLine();
            for(int baris=0;baris<5;baris++){
                Console.Write(baris+1+" ");
                for(int kolom=0;kolom<5;kolom++){
                    char posisi= playArea[baris,kolom];
                    if(posisi==tank){
                        Console.Write(rumput+" ");
                    }else{
                        Console.Write(posisi+" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //Tebakan koordinatb pemain
        private static int[] getKoordinatTebakan(int panjangArea){
            int baris;
            int kolom;
            do{
                Console.Write("Pilih Baris = ");
                baris=Convert.ToInt32(Console.ReadLine());
            }while(baris<0 || baris>panjangArea +1);
            do{
                Console.Write("Pilih Kolom = ");
                kolom=Convert.ToInt32(Console.ReadLine());
            }while(kolom<0 || kolom>panjangArea +1);
            return new[]{baris-1,kolom-1};
        }
        //Verifikasi tebakan pemain
        private static char verifikasiTebakan(int[]tebakan,char[,]playArea,char tank,char rumput,char hit,char miss){
            string pesan;
            int baris=tebakan[0];
            int kolom=tebakan[1];
            char target=playArea[baris,kolom];
            if(target==tank){
                pesan="HIT";
                target=hit;
            }else if(target==rumput){
                pesan="MISS";
                target=miss;
            }else{
                pesan="CLEAR";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("");
            return target;
        }
    }
}