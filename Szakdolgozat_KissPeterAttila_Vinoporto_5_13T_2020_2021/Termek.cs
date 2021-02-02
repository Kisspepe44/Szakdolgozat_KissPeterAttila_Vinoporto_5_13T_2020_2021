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
    public partial class Termek : Form
    {
        public Termek()
        {
            InitializeComponent();
        }

        private void honlapok_fomenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Fomenu fomenuForm = new Fomenu();

            fomenuForm.Show();
        }

        private void termek_exit_btn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
