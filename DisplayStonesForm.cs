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

    public enum StonesToDisplay { AllStones, StonesFound, StonesNotFound }
    public partial class DisplayStonesForm : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;


        public DisplayStonesForm()
        {
            InitializeComponent();
        }

        private void radioButtonAllStones_CheckedChanged(object sender, EventArgs e)
        {
            fillDataGridView(StonesToDisplay.AllStones);

        }
        
        private void radioButtonStonesFound_CheckedChanged(object sender, EventArgs e)
        {
            fillDataGridView(StonesToDisplay.StonesFound);

        }
        
        
        private void radioButtonStonesNotFound_CheckedChanged(object sender, EventArgs e)
        {
            fillDataGridView(StonesToDisplay.StonesNotFound);
        }






        private void fillDataGridView(StonesToDisplay stonesToDisplayOptn)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            



            conn = new SQLiteConnection("data source=StoneCollectingdb.db; version=3; new=true; compress=true;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd = conn.CreateCommand();

            

            if (stonesToDisplayOptn == StonesToDisplay.AllStones)
            {
                
                cmd.CommandText ="SELECT * FROM TblStones"; 
            }
            else if (stonesToDisplayOptn == StonesToDisplay.StonesFound)
            {
                
                cmd.CommandText = "SELECT * FROM TblStones WHERE StoneFound = @StoneFoundValue";
                cmd.Parameters.AddWithValue("@StoneFoundValue", 1);

            }
            else if (stonesToDisplayOptn==StonesToDisplay.StonesNotFound)
            {
                cmd.CommandText = "SELECT * FROM TblStones WHERE StoneFound = @StoneFoundValue";
                cmd.Parameters.AddWithValue("@StoneFoundValue", 0);

            }


            SQLiteDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(new object[] { dataReader["StoneID"], dataReader["StoneName"], dataReader["StoneColour"], dataReader["StoneLocation"], dataReader["StoneFound"].ToString() == "1" ? "Found" : "Not Found" });


            }




            dataGridView1.AutoResizeColumns();


        }

        private void DisplayStonesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
