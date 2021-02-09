using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    class Termekcsoportok
    {
        int id;
        string nev;

        public Termekcsoportok(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
