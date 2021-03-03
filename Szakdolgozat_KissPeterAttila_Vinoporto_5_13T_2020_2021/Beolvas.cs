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

        public Beolvas(string adatok)
        {
            string[] bontottsor = adatok.Split(';');




            try
            {

                this.Oldal = bontottsor[0];
                this.Felulet = bontottsor[1];
                this.Futarnev = bontottsor[2];
                if (bontottsor[3] != "")
                {
                    this.Rendelesszam = Convert.ToInt32(bontottsor[3]);
                }
                else
                {
                    this.Rendelesszam = 0;
                }
                if (bontottsor[4] != "")
                {
                    this.Kerulet = Convert.ToInt32(bontottsor[4]);
                }
                else
                {
                    this.Kerulet = 0;
                }
                
                this.Cim = bontottsor[5]; 
                this.Megjegyzes = bontottsor[6]; 
                if (bontottsor[7] != "")
                {
                    this.Npkp = Convert.ToInt32(bontottsor[7]);
                }
                else
                {
                    this.Npkp = 0;
                }

                if (bontottsor[8] != "")
                {
                    this.Sajatkp = Convert.ToInt32(bontottsor[8]);
                }
                else
                {
                    this.Sajatkp = 0;
                }

                if (bontottsor[9] != "")
                {
                    this.Kiadas = Convert.ToInt32(bontottsor[9]);
                }
                else
                {
                    this.Kiadas = 0;
                }

                if (bontottsor[10] != "")
                {
                    this.Npbk = Convert.ToInt32(bontottsor[10]);
                }
                else
                {
                    this.Npbk = 0;
                }

                if (bontottsor[11] != "")
                {
                    this.Webbk = Convert.ToInt32(bontottsor[11]);
                }
                else
                {
                    this.Webbk = 0;
                }

                if (bontottsor[12] != "")
                {
                    this.Pos = Convert.ToInt32(bontottsor[12]);
                }
                else
                {
                    this.Pos = 0;
                }
                
                
                
               
                
               

            }
            catch (Exception e)
            {

            }
            
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
