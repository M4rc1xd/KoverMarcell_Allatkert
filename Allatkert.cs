using System.Globalization;
using Microsoft.VisualBasic;

namespace Allatkert
{
    public class Allatkert
    {
        static Random r = new Random();
        int nagysag;
        Viz v1 = new Viz("Keszeg", 1, "Piros", 2);
        Hideg h1 = new Hideg("Jegesmedve", 4, "Fehér", 3);
        Tropusi t1 = new Tropusi("Majom", 3, "Fekete", 4);
        Meleg m1 = new Meleg("Zsiráf", 2, "Sarga", 5);
        Mediterran me1 = new Mediterran("Szarvas", 5, "Barna", 6);

        List<string> Allatok;
        List<int> allatGyorsasag;

        public Allatkert(int nagysag)
        {
            this.nagysag = nagysag;
            Allatok = new List<string> {
                v1.Nev,
                h1.Nev,
                t1.Nev,
                m1.Nev,
                me1.Nev
            };
            allatGyorsasag = new List<int> {
                v1.Gyorsasag,
                h1.Gyorsasag,
                t1.Gyorsasag,
                m1.Gyorsasag,
                me1.Gyorsasag
            };
        }


        public void telitettseg()
        {
            string Hely = "  ";
            int osszAllat = Allatok.Count;
            int uresHely = nagysag - osszAllat;
            for (int i = 5; i>0; i--){
                Console.Clear();
                Console.Write("|");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                for (int j = 0; j < osszAllat; j++)
                {
                    Console.Write(Hely);
                }
                Console.BackgroundColor = ConsoleColor.DarkGray;
                for (int j = 0; j < uresHely; j++)
                {
                Console.Write(Hely);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("|");

                System.Console.WriteLine("Allatkert teljes kapacitasa: " + nagysag);
                System.Console.WriteLine("Az allatkertben jelenleg " + osszAllat + " allat van.");
                System.Console.WriteLine("Az allatkert telitettsege: " + (osszAllat * 100 / nagysag) + "%");
                System.Console.WriteLine($"{i} masodperc mulva elindul a verseny");
                Thread.Sleep(1000);
            }
            Verseny();
        }

        public void Verseny(){
            int rajtIdo = 3;
            for (int i = rajtIdo; i>0; i--){
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"{Allatok[0]}\n{Allatok[1]}\n{Allatok[2]}\n{Allatok[3]}\n{Allatok[4]}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("RAJT");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine($"{Allatok[0]}\n{Allatok[1]}\n{Allatok[2]}\n{Allatok[3]}\n{Allatok[4]}");

            List<int> allatHely = new List<int> {0, 0, 0, 0, 0};
            int cel = 50;
            int index = 0;
            int elso = 0;
            int minusz = -2;
            int plusz = 3;
            while (elso < cel){
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("RAJT");
                Console.SetCursorPosition(cel, 0);
                System.Console.WriteLine("CÉL");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i<allatHely.Count; i++){
                    Console.SetCursorPosition(cel, i+1);
                    System.Console.WriteLine("|");
                    Console.SetCursorPosition(allatHely[i]+=allatGyorsasag[i]+r.Next(minusz,plusz), i+1);
                    System.Console.WriteLine(Allatok[i]);
                    if (allatHely[i]+Allatok[i].Length >= cel){
                        elso = allatHely[i]+Allatok[i].Length;
                        index = i;
                    } else if (elso <allatHely[i]){
                        elso = allatHely[i]+Allatok[i].Length;
                        index = i;
                    }
                };
            }
            System.Console.WriteLine($"NYERTES! A {Allatok[index].ToUpper()} MEGNYERTE A VERSENYT");
        }
    }
}