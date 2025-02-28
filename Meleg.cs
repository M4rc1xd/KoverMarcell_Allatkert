namespace Allatkert
{
    public class Meleg
    {
        string nev;
        int gyorsasag;
        string szin;
        int eletkor;

        public Meleg(string nev, int gyorsasag, string szin, int eletkor)
        {
            this.nev = nev;
            this.gyorsasag = gyorsasag;
            this.szin = szin;
            this.eletkor = eletkor;
        }

        public string Nev{ get => nev; set => nev = value; }
        public int Gyorsasag{ get => gyorsasag; set => gyorsasag = value; }
        public string Szin{ get => szin; set => szin = value; }
        public int Eletkor{ get => eletkor; set => eletkor = value; }
    }
}