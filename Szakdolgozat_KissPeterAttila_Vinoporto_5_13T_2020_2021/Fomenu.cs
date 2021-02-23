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
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();
        }

        private void fomenu_exit_btn_Click(object sender, EventArgs e)
        {
           this.Close();
            
            kezdolap kezdolapForm = new kezdolap();

            kezdolapForm.Show();
        }

        private void fomenu_honlap_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Honlapok honlapForm = new Honlapok();

            honlapForm.Show();
        }

        private void fomenu_futar_btn_Click(object sender, EventArgs e)
        {
            this.Close();

           Futar futarForm = new Futar();

           futarForm.Show();
        }

        private void fomenu_termek_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Termek termekForm = new Termek();

            termekForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Vasarlas vasarlasForm = new Vasarlas();

            vasarlasForm.Show();
        }
    }
}
