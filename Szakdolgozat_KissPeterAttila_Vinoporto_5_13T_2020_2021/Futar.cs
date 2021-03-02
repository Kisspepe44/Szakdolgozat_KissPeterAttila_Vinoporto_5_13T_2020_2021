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
using MySql.Data.MySqlClient;


namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    public partial class Futar : Form

    {
        private static List<Beolvas>  lista = new List<Beolvas>();
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Futar()
        {
            

        InitializeComponent();


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



            Futar_futarvalaszto_cb.Items.Clear();
            sql.CommandText = "SELECT * FROM `futarok`;";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {

                while (dr.Read())
                {
                    Futar_futarvalaszto_cb.Items.Add(new futarok(dr.GetInt32("id"), dr.GetString("nev")));
                }

            }

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
            beolvas.ReadLine();
            beolvas.ReadLine();
            beolvas.ReadLine();
            beolvas.ReadLine();
            beolvas.ReadLine();
            beolvas.ReadLine();
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                Beolvas b = new Beolvas(sor);
                
                lista.Add(b);
                
            }
           
        }

        private void futar_exelbe_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
