using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    public partial class Vasarlas : Form
    {

        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Vasarlas()
        {
            InitializeComponent();
        }

        private void termek_fomenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Fomenu fomenuForm = new Fomenu();

            fomenuForm.Show();
        }

        private void Vasarlas_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "Localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "arkepzesdb";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



            Vasarlas_termekcsoport_cb.Items.Clear();
            sql.CommandText = "SELECT * FROM `termekcsoportok`;";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {

                while (dr.Read())
                {
                    Vasarlas_termekcsoport_cb.Items.Add(new Termekcsoportok(dr.GetInt32("id"), dr.GetString("nev")));
                }

            }
            Vasarlas_termekcsoport_cb.Text = "Absinthe";


            


        }

        private void Termek_keres_btn_Click(object sender, EventArgs e)
        {
            vasarlas_termek_cb.Items.Clear();
            sql.CommandText = "SELECT * FROM `arkepzes` where Termekcsoport like '" + Vasarlas_termekcsoport_cb.Text + "'";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {

                while (dr.Read())
                {
                    vasarlas_termek_cb.Items.Add(new Termeklekerdezes(dr.GetInt32("id"), dr.GetString("Termekcsoport"), dr.GetInt32("Vonalkod"), dr.GetString("Megnevezes"), dr.GetInt32("italpincer"), dr.GetInt32("partyhordoberugok"), dr.GetInt32("sosnight")));
                }

            }
        }
    }
}
