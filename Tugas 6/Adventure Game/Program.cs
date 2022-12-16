/*
Nama : Rafly Wirangga
NIM  : 2207112577
Kelas: Teknik Informatika-A
*/
using System;

namespace Program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adventure Game");
            Console.WriteLine("Whats Your Name?");
            Kind Gigachad = new Kind();
            Gigachad.Name=Console.ReadLine();
            Console.WriteLine($"{Gigachad.Name}, Are you ready for The Game [y/n]");
            string start=Console.ReadLine();
            if(start=="y"){
                Console.WriteLine("Okey "+Gigachad.Name+" Lets Defeat It ");
                Skizo Abnormal = new Skizo("Fenomous");
                Console.WriteLine($"{Gigachad.Name} is Encountering {Abnormal.Name}");
                Console.WriteLine($"{Abnormal.Name} is Attacking You...");
                Console.WriteLine("Pick Your Movement : ");
                Console.WriteLine("1. Normal Attack");
                Console.WriteLine("2. SKyblast");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. RunAway ");

                while(!Gigachad.Dead&&!Abnormal.Dead&&!Gigachad.RunAway)
                {
                    string p1Movement=Console.ReadLine();
                    switch(p1Movement){
                        case "1" :
                        Console.WriteLine(Gigachad.Name+" does Basic Attack");
                        Abnormal.HIt(Gigachad.Attack);
                        Gigachad.Experience+=0.5f;
                        Abnormal.AttackPower(Abnormal.Attack);
                        Gigachad.HIt(Abnormal.Attack);
                        Console.Write($"{Gigachad.Name} Health : {Gigachad.Health} | {Abnormal.Name} Health : {Abnormal.Health}\n");
                        break;
                        case "2" :
                        Gigachad.Ultimate();
                        Abnormal.HIt(Gigachad.Attack);
                        Console.Write($"{Gigachad.Name} Health : {Gigachad.Health} | {Abnormal.Name} Health : {Abnormal.Health}\n");
                        Gigachad.Experience+=0.7f;
                        break;
                        case "3" :
                        Gigachad.Energy();
                        Console.WriteLine("Energy have been Charge");
                        Abnormal.AttackPower(Abnormal.Attack);
                        Gigachad.HIt(Abnormal.Attack);
                        Console.Write($"{Gigachad.Name} Health : {Gigachad.Health} | {Abnormal.Name} Health : {Abnormal.Health}\n");
                        break;
                        case "4" :
                        Console.WriteLine(Gigachad.Name+" IM Going To Byeee....");
                        Gigachad.RunningAway();
                        break;
                    }
                }
                Console.WriteLine($"{Gigachad.Name} get {Gigachad.Experience} Experience Point");
            }else{
                Console.WriteLine("Bye-Bye");
                Console.Read();
            }
            
        }
    }
    class Kind{
        public int Health { get; set; }
        public int Attack { get; set; }
        public int SkillGiga { get; set; }
        public string Name { get; set; }
        public bool Dead { get; set; }
        public float Experience { get; set; }
        public bool RunAway { get; set; }
        Random rnd=new Random();
        public Kind(){
            Health=100;
            Attack=1;
            SkillGiga=0;
            Experience=0f;
            Name="KuroNew";
            
        }
        public void Ultimate(){
            if(SkillGiga>0){
                Console.WriteLine("Nitoryu Iai...");
                Attack=Attack+rnd.Next(8,12);
                SkillGiga--;
            }else{
                Console.WriteLine("Energy is Too Low");
            }
        }
        public void HIt(int Point){
            Console.WriteLine(Name+" get Hit by "+Point);
            Health=Health-Point;
            if(Health<=0){
                Health=0;
                Die();
            }
        }
        public void Energy(){
            SkillGiga=3;
            Attack=1;
        }
        public void Die(){
            Console.WriteLine("You Are Dead ");
            Console.WriteLine("Loser Dead, GAME OVER ");
            Console.ReadLine();
            Dead=true;
        }
        public void RunningAway(){
            RunAway = true;
        }
    }
    class Skizo{
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public bool Dead { get; set; }
        Random rnd= new Random();
        public Skizo(string name){
            Health=50;
            Name=name;
        }
        public void AttackPower(int damage){
            Attack=rnd.Next(5,10);

        }
        public void HIt(int Point){
            Console.WriteLine(Name+" get Hit by "+Point);
            Health=Health-Point;
            if(Health<=0){
                Health=0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name+" is Dead ");
            Dead=true;
        }
    }
}