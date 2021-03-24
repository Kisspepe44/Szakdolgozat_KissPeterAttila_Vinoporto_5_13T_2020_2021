using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    class Termeklekerdezes
    {
        int id;
        string Termekcsoport;
        int Vonalkod;
        string Megnevezes;
        int italpincer;
        int partyhordoberugok;
        int sosnight;

        public Termeklekerdezes(int id, string termekcsoport, int vonalkod, string megnevezes, int italpincer, int partyhordoberugok, int sosnight)
        {
            this.id = id;
            Termekcsoport = termekcsoport;
            Vonalkod = vonalkod;
            Megnevezes = megnevezes;
            this.italpincer = italpincer;
            this.partyhordoberugok = partyhordoberugok;
            this.sosnight = sosnight;
        }

        public int Id { get => id; set => id = value; }
        public string Termekcsoport1 { get => Termekcsoport; set => Termekcsoport = value; }
        public int Vonalkod1 { get => Vonalkod; set => Vonalkod = value; }
        public string Megnevezes1 { get => Megnevezes; set => Megnevezes = value; }
        public int Italpincer { get => italpincer; set => italpincer = value; }
        public int Partyhordoberugok { get => partyhordoberugok; set => partyhordoberugok = value; }
        public int Sosnight { get => sosnight; set => sosnight = value; }

        public override string ToString()
        {
            return this.Megnevezes +"#"+ this.Italpincer + " Ft.";
        }
    }
}
