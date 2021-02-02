using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    public partial class Futar : Form
    {
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

        
    }
}
