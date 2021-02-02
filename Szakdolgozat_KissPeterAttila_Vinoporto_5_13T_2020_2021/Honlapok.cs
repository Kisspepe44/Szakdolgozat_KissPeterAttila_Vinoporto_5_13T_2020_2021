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
    public partial class Honlapok : Form
    {
        public Honlapok()
        {
            InitializeComponent();
        }

        

        private void honlapok_fomenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Fomenu fomenuForm = new Fomenu();

            fomenuForm.Show();
        }

        private void honlapok_italpincer_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://italpincer.hu/");
        }

        private void honlapok_sos_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sosnight.hu/"); 
        }

        private void honlapok_ph_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.netpincer.hu/restaurant/c8zh/partyhordo-italhazhozszallitas#");
        }

        private void honlap_berugok_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://berugok.hu/");
        }
    }
}
