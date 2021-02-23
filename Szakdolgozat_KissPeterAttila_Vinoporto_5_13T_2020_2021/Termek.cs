using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    public partial class Termek : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
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

        private void Termek_Load(object sender, EventArgs e)
        {

            Termek_web_cb.Items.Add("Mind 3");
            Termek_web_cb.Items.Add("Italpincér");
            Termek_web_cb.Items.Add("SosNight");
            Termek_web_cb.Items.Add("Partyhordo/Berugok.hu");
            Termek_web_cb.Text = "Mind 3";
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



            Termek_termekcsoport_cb.Items.Clear();
            sql.CommandText = "SELECT * FROM `termekcsoportok`;";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {

                while (dr.Read())
                {
                    Termek_termekcsoport_cb.Items.Add(new Termekcsoportok(dr.GetInt32("id"),dr.GetString("nev")));
                }

            }

        }

        private void Termek_keres_btn_Click(object sender, EventArgs e)
        {
            string web = "`Termekcsoport`,`Megnevezes`,`italpincer`,`partyhordoberugok`,`sosnight`";
            string webar = "'italpincer' and `partyhordoberugok` and `sosnight`";
            if (Termek_web_cb.Text == "Mind 3")
            {
                web = " Termekcsoport , Megnevezes, italpincer ,partyhordoberugok ,sosnight";
                webar = "italpincer and partyhordoberugok and sosnight";
            }
            else if (Termek_web_cb.Text == "Italpincér")
            {
                web = "`Termekcsoport`,`Megnevezes`,`italpincer`";
                webar = "`italpincer`";
            }
            else if (Termek_web_cb.Text == "SosNight")
            {
                web = "`Termekcsoport`,`Megnevezes`,`sosnight`";
                webar = "`sosnight`";
            }
            else if (Termek_web_cb.Text == "Partyhordo/Berugok.hu")
            {
                web = "`Termekcsoport`,`Megnevezes`,`partyhordoberugok`";
                webar = "`partyhordoberugok`";
            }

            try
            {
                
                sql = conn.CreateCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT "+web+" FROM `arkepzes` WHERE `Termekcsoport` like '" + Termek_termekcsoport_cb.SelectedItem+ "' and  "+ webar +" BETWEEN "+Termek_min_nup.Value+" and "+Termek_max_nup.Value+";", conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "arkepzes");
                dataGridView1.DataSource = ds.Tables["arkepzes"];
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
    }

