using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    class Beolvas
    {
        private string oldal;
        private string felulet;
        private string futarnev;
        private int rendelesszam;
        private int kerulet;
        private string cim;
        private string megjegyzes;
        private int npkp;
        private int sajatkp;
        private int kiadas;
        private int npbk;
        private int webbk;
        private int pos;

        public Beolvas(string oldal, string felulet, string futarnev, int rendelesszam, int kerulet, string cim, string megjegyzes, int npkp, int sajatkp, int kiadas, int npbk, int webbk, int pos)
        {
            this.Oldal = oldal;
            this.Felulet = felulet;
            this.Futarnev = futarnev;
            this.Rendelesszam = rendelesszam;
            this.Kerulet = kerulet;
            this.Cim = cim;
            this.Megjegyzes = megjegyzes;
            this.Npkp = npkp;
            this.Sajatkp = sajatkp;
            this.Kiadas = kiadas;
            this.Npbk = npbk;
            this.Webbk = webbk;
            this.Pos = pos;
        }

        public string Oldal { get => oldal; set => oldal = value; }
        public string Felulet { get => felulet; set => felulet = value; }
        public string Futarnev { get => futarnev; set => futarnev = value; }
        public int Rendelesszam { get => rendelesszam; set => rendelesszam = value; }
        public int Kerulet { get => kerulet; set => kerulet = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
        public int Npkp { get => npkp; set => npkp = value; }
        public int Sajatkp { get => sajatkp; set => sajatkp = value; }
        public int Kiadas { get => kiadas; set => kiadas = value; }
        public int Npbk { get => npbk; set => npbk = value; }
        public int Webbk { get => webbk; set => webbk = value; }
        public int Pos { get => pos; set => pos = value; }
    }
}
