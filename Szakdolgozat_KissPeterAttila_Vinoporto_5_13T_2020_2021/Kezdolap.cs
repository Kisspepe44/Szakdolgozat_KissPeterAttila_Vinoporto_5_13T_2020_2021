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
    public partial class kezdolap : Form
    {
        public kezdolap()
        {
            InitializeComponent();
        }

        private void Kezdolap_Load(object sender, EventArgs e)
        {

        }

        private void kl_tovabb_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fomenu fomenuForm = new Fomenu();

            fomenuForm.Show();
        }

        private void kl_kikep_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
