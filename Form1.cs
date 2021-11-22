using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StoneCollectingVisual
{
    public partial class Form1 : Form
    {
        SQLiteCommand cmd;
        SQLiteConnection conn;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterStoneForm enterStoneForm = new EnterStoneForm();
            enterStoneForm.Owner = this;
            enterStoneForm.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("data source=StoneCollectingdb.db; version=3; new=true; compress=true;");
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string CreateTableStoneCollecting = "CREATE TABLE IF NOT EXISTS TblStones (StoneID VARCHAR(20), StoneName VARCHAR(20), StoneColour VARCHAR(20), StoneLocation VARCHAR(20), StoneFound INT)";
                cmd = conn.CreateCommand();
                cmd.CommandText = CreateTableStoneCollecting;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStoneFormcs editStoneForm = new EditStoneFormcs();
            editStoneForm.Owner = this;
            editStoneForm.Show();
            this.Hide();

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStonesForm displayStonesForm = new DisplayStonesForm();
            displayStonesForm.Owner = this;
            displayStonesForm.Show();
            this.Hide();
        }
    }
}
