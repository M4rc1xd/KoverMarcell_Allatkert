using Microsoft.VisualBasic;

namespace Allatkert
{
    public class Allatkert
    {
        int nagysag;
        Viz v1 = new Viz("Keszeg", 1, "Piros", 2);
        Hideg h1 = new Hideg("Jegesmedve", 4, "Fehér", 3);
        Tropusi t1 = new Tropusi("Majom", 3, "Fekete", 4);
        Meleg m1 = new Meleg("Zsiráf", 2, "Sarga", 5);
        Mediterran me1 = new Mediterran("Szarvas", 5, "arna", 6);

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
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < osszAllat; i++)
            {
                Console.Write(Hely);
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < uresHely; i++)
            {
                Console.Write(Hely);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("|");

            System.Console.WriteLine("Allatkert teljes kapacitasa: " + nagysag);
            System.Console.WriteLine("Az allatkertben jelenleg " + osszAllat + " allat van.");
            System.Console.WriteLine("Az allatkert telitettsege: " + (osszAllat * 100 / nagysag) + "%");
            System.Console.WriteLine("5 Masodperc mulva elindul a verseny");
            Verseny();
        }

        public void Verseny(){
            Thread.Sleep(5000);
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
            while (elso < cel){
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("RAJT");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(cel, 0);
                System.Console.WriteLine("|");
                for (int i = 0; i<allatHely.Count; i++){
                    Console.SetCursorPosition(allatHely[i]+=allatGyorsasag[i], i+1);
                    System.Console.WriteLine(Allatok[i]);
                    if (allatHely[i] >= cel){
                        System.Console.WriteLine($"NYERTES! {Allatok[index]} MEGNYERTE A VERSENYT");
                        elso =allatHely[i];
                        break;
                    } else if (elso <allatHely[i]){
                        elso = allatHely[i];
                        index = i;
                    }
                };

            }
        }
    }
}
//oroklodes/ ösosytalz