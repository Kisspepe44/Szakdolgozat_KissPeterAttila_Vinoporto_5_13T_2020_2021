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
        MySqlConnection connn = null;
        MySqlCommand sqll = null;

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
            MySqlConnectionStringBuilder sbb = new MySqlConnectionStringBuilder();
            sbb.Server = "Localhost";
            sbb.UserID = "root";
            sbb.Password = "";
            sbb.Database = "arkepzesdb";
            sbb.CharacterSet = "utf8";
            connn = new MySqlConnection(sbb.ToString());
            try
            {
                connn.Open();
                sqll = connn.CreateCommand();


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
            ;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqll = connn.CreateCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Termekcsoport, Megnevezes, italpincer FROM `arkepzes` WHERE Megnevezes like '%" + textBox1.Text + "%'", connn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "arkepzes");
            dataGridView1.DataSource = ds.Tables["arkepzes"];
            connn.Close();


            vasarlas_termek_cb.Items.Clear();
            sql.CommandText = "SELECT * FROM `arkepzes` where Megnevezes like '%" + textBox1.Text + "%'";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {

                while (dr.Read())
                {
                    vasarlas_termek_cb.Items.Add(new Termeklekerdezes(dr.GetInt32("id"), dr.GetString("Termekcsoport"), dr.GetInt32("Vonalkod"), dr.GetString("Megnevezes"), dr.GetInt32("italpincer"), dr.GetInt32("partyhordoberugok"), dr.GetInt32("sosnight")));
                }

            }



        }

        private void kosarurit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                sqll = connn.CreateCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "kosar");
                dataGridView1.DataSource = ds.Tables["kosar"];
                connn.Close();

                sqll.CommandText = "TRUNCATE arkepzesdb.kosar";
                sqll.Connection = connn;
                connn.Open();
                sqll.ExecuteNonQuery();
                connn.Close();

            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                sqll = connn.CreateCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "kosar");
                dataGridView1.DataSource = ds.Tables["kosar"];
                connn.Close();

                sqll.CommandText = "DELETE FROM `kosar` WHERE `kosar`.`ID` = " + id_NUD.Value + " ;";
                sqll.Connection = connn;
                connn.Open();
                sqll.ExecuteNonQuery();
                connn.Close();

            }



        }

        private void kosartartam_Click(object sender, EventArgs e)
        {
            sqll = connn.CreateCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kosar");
            dataGridView1.DataSource = ds.Tables["kosar"];
            connn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqll = connn.CreateCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosarbezar`", connn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "kosarbezar");
            dataGridView1.DataSource = ds.Tables["kosarbezar"];
            connn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sor = vasarlas_termek_cb.Text;
            string[] bontottsor = sor.Split('#');
            string megnevezes = bontottsor[0];
            string sor2 = bontottsor[1];
            string[] bontottsor2 = sor2.Split(' ');
            int ar = Convert.ToInt32(bontottsor2[0]);


            for (int i = 0; i < 2; i++)
            {
                if (i < 1)
                {
                    sqll = connn.CreateCommand();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "kosar");
                    dataGridView1.DataSource = ds.Tables["kosar"];
                    connn.Close();

                    sqll.CommandText = "INSERT INTO `kosar` (`ID`, `Megnevezes`, `Ar`, `Darabszam`) VALUES (NULL, '" + megnevezes + "', '" + ar + "', '" + Termek_min_nup.Value + "');";
                    sqll.Connection = connn;
                    connn.Open();
                    sqll.ExecuteNonQuery();
                    connn.Close();
                }
                else
                {
                    sqll = connn.CreateCommand();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "kosar");
                    dataGridView1.DataSource = ds.Tables["kosar"];
                    connn.Close();
                }

            }



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int osszeg = 0;
            string sql = "SELECT SUM(`Ar`*`Darabszam`) FROM `kosar` WHERE 1";

            

            for (int i = 0; i < 2; i++)
            {
                if (i < 1)
                {
                    MySqlCommand cmdd = new MySqlCommand(sql, connn);
                    MySqlDataReader rdd = cmdd.ExecuteReader();
                    if (rdd.HasRows)
                    {
                        rdd.Read();
                        osszeg = rdd.GetInt32(0);
                    }
                    connn.Close();
                    

                    sqll = connn.CreateCommand();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "kosar");
                    dataGridView1.DataSource = ds.Tables["kosar"];
                    connn.Close();




                    sqll.CommandText = "INSERT INTO `kosar` (`ID`, `Megnevezes`, `Ar`, `Darabszam`) VALUES (NULL, 'Végösszeg', '" + osszeg + "', '1');";
                    sqll.Connection = connn;
                    connn.Open();
                    sqll.ExecuteNonQuery();
                    connn.Close();




                }
                else
                {
                    sqll = connn.CreateCommand();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `kosar`", connn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "kosar");
                    dataGridView1.DataSource = ds.Tables["kosar"];
                    connn.Close();
                }




            }
        }
    }
} 

