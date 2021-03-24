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
            StreamReader beolvas = new StreamReader("teszttt.csv");
            beolvas.ReadLine();
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
            



            int oraber = (Convert.ToInt32(munkaido_nud.Value) * 300);
            int uzemanyag = ((Convert.ToInt32(kp_nud.Value)/100) * Convert.ToInt32(uzemanyag_nud.Value) * 7);
            uzemanyag_lb.Text = "Üzemanyag: " + uzemanyag;
            oraber_lb.Text = "Órabér: " + oraber;
            int bk = 0;
            int kp = 0;
            int cimpenz = 0;
            int bevetel = 0;

            for (int i = 0; i < lista.Count; i++)
            {
               
                if (lista[i].Futarnev == Futar_futarvalaszto_cb.Text)
                {
                    if (lista[i].Npkp > 0)
                    {
                        kp = kp + 1;
                        cimpenz = cimpenz + 250;
                        bevetel = bevetel + lista[i].Npkp;
                        bevetel = bevetel - lista[i].Kiadas;

                    }
                    else if (lista[i].Sajatkp  > 0)
                    {
                     kp = kp + 1;
                     cimpenz = cimpenz + 250;
                     bevetel = bevetel + lista[i].Sajatkp;
                     bevetel = bevetel - lista[i].Kiadas;
                     }
                    else
                     {
                        bk = bk + 1;
                        cimpenz = cimpenz + 350;

                        bevetel = bevetel - lista[i].Kiadas;
                     }
                    leado_lb.Text = "Leadó: " + (bevetel - cimpenz - uzemanyag - oraber) ;
                    kereset_lb.Text = "Kereset: " + (cimpenz + uzemanyag + oraber);



        }
            }
            

            bk_lb.Text = "BK: " + bk;
            kp_lb.Text = "KP: " + kp;
            cimpenz_lb.Text = "Címpénz: " + cimpenz;
            bevetel_lb.Text = "Napi Bevétel: " + bevetel;


            





        }

        private void futar_exelbe_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

    }
}
