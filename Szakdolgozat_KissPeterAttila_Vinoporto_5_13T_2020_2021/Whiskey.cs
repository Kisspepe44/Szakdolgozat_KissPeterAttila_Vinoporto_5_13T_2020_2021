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
    public partial class Whiskey : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public Whiskey()
        {
            InitializeComponent();
        }

        private void Whiskey_Load(object sender, EventArgs e)
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `arkepzes` WHERE `Termekcsoport` like 'whiskey'", conn);
               
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

        private void futar_fomenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            Termek termekForm = new Termek();

            termekForm.Show();
        }
    }
}
