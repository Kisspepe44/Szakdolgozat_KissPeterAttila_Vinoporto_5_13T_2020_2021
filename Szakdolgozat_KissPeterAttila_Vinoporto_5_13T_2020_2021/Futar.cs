using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    public partial class Futar : Form
    {
        private static List<Beolvas>  lista = new List<Beolvas>();
        public Futar()
        {
            

        InitializeComponent();
            Futar_futarvalaszto_cb.Items.Add("Kiss Péter");
            Futar_futarvalaszto_cb.Items.Add("Kiss Attila");
            Futar_futarvalaszto_cb.Items.Add("Éliás Dorottya");
            Futar_futarvalaszto_cb.Items.Add("Gyulai Zoltán");
            Futar_futarvalaszto_cb.Items.Add("Herczegffy Zoltán");
            Futar_futarvalaszto_cb.Items.Add("Habó Zoltán");
            Futar_futarvalaszto_cb.Items.Add("Tutyi Miklós");
            Futar_futarvalaszto_cb.Items.Add("Dániel György");
            Futar_futarvalaszto_cb.Items.Add("Tarnai Tamás");
            Futar_futarvalaszto_cb.Items.Add("Fodor Patrik");
            Futar_futarvalaszto_cb.Items.Add("Bernát");
            Futar_futarvalaszto_cb.Items.Add("Kárnyáczki Péter");
            Futar_futarvalaszto_cb.Items.Add("Szónok Szabolcs");
            Futar_futarvalaszto_cb.Items.Add("Mátyus Miklós");
            Futar_futarvalaszto_cb.Items.Add("Éliás Fruzsina");
            Futar_futarvalaszto_cb.Items.Add("Solymoskövi Tamás");
            Futar_futarvalaszto_cb.Items.Add("Mátyus Miklós");

        }

        

        private void futar_fomenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Fomenu fomenuForm = new Fomenu();

            fomenuForm.Show();
        }

        private void Futar_szamol_btn_Click(object sender, EventArgs e)
        {
            StreamReader beolvas = new StreamReader("tesztt.csv");

            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                string[] bontottsor = sor.Split(';');
                MessageBox.Show(sor);
                Beolvas b = new Beolvas(bontottsor[0], bontottsor[1], bontottsor[2],Convert.ToInt32(bontottsor[3]), Convert.ToInt32(bontottsor[4]),bontottsor[5], bontottsor[6], Convert.ToInt32(bontottsor[7]), Convert.ToInt32(bontottsor[8]), Convert.ToInt32(bontottsor[9]), Convert.ToInt32(bontottsor[10]), Convert.ToInt32(bontottsor[11]), Convert.ToInt32(bontottsor[12]));
                
                lista.Add(b);
                
            }
            MessageBox.Show(lista[0].Oldal);
        }
    }
}
