using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace StoneCollectingVisual
{
    public partial class EditStoneFormcs : EnterStoneForm
    {
        public bool StoneFound = false;
        SQLiteConnection conn;
        SQLiteCommand cmd;

        public EditStoneFormcs()
        {
            InitializeComponent();
        }

        private void EditStoneFormcs_Load(object sender, EventArgs e)
        {
            textBoxStoneName.Enabled = false;
            textBoxStoneColour.Enabled = false;
            textBoxStoneLocation.Enabled = false;
            checkBoxStoneFound.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;

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

            cmd.CommandText = "SELECT StoneID FROM TblStones";
            

            SQLiteDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["StoneID"]);
            }






        }

        //private void textBoxStoneID_TextChanged(object sender, EventArgs e)
        //{
        //    string errorMessage="";
        //    string inputIDNoWhitespace = Regex.Replace(textBoxStoneID.Text, @"\s+", "");

        //    if (Regex.IsMatch(inputIDNoWhitespace, @"^\d{4}$"))
        //    {
        //        errorMessage="";
        //    }

        //    else
        //    {
        //        if (inputIDNoWhitespace.Length < 4)
        //        {
        //            errorMessage = "ID is too short";
        //        }
        //        else if (inputIDNoWhitespace.Length > 4)
        //        {
        //            errorMessage = "ID is too long";
        //        }

        //        if (Regex.IsMatch(inputIDNoWhitespace, @"\D"))
        //        {
        //            errorMessage += $"{(errorMessage == "" ? "\n" : "")}ID must only contain digits";
        //        }

        //    }

            
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null && !comboBox1.Items.Contains(Regex.Replace(comboBox1.Text, @"\s+", "")))
            {
                MessageBox.Show("Please Select a Valid ID");
            }
            else
            {

                string inputStoneID = Regex.Replace(comboBox1.Text, @"\s+", "");



                Dictionary<string,string> StoneRecord=FindByID(inputStoneID);



                if (StoneRecord == null)
                {
                    MessageBox.Show($"No Stone found with ID {inputStoneID}");

                }

                else
                {
                    PrepareForEditing(StoneRecord);
                }

            }

            
        }

        private void PrepareForEditing(Dictionary<string, string> StoneRecord)
        {
            comboBox1.SelectedItem = StoneRecord["StoneID"];
            textBoxStoneName.Text = StoneRecord["StoneName"];
            textBoxStoneColour.Text = StoneRecord["StoneColour"];
            textBoxStoneLocation.Text = StoneRecord["StoneLocation"];
            checkBoxStoneFound.Checked = StoneRecord["StoneFound"] == "1" ? true : false;

            comboBox1.Enabled = false;
            textBoxStoneName.Enabled = true;
            textBoxStoneColour.Enabled = true;
            textBoxStoneLocation.Enabled = true;
            checkBoxStoneFound.Enabled = true;
            button3.Enabled = true;
        }

        private  Dictionary<string, string> FindByID(string StoneID)
        {
            bool IDExists = false;

            Dictionary<string, string> StoneRecord = new Dictionary<string, string>();

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

            cmd.CommandText = "SELECT * FROM TblStones WHERE StoneID=@StoneID";
            cmd.Parameters.AddWithValue("@StoneID", StoneID);

            SQLiteDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                IDExists = true;
                StoneRecord.Add("StoneID", dataReader["StoneID"].ToString());
                StoneRecord.Add("StoneName", dataReader["StoneName"].ToString());
                StoneRecord.Add("StoneColour", dataReader["StoneColour"].ToString());
                StoneRecord.Add("StoneLocation", dataReader["StoneLocation"].ToString());
                StoneRecord.Add("StoneFound", dataReader["StoneFound"].ToString());

                
            }
            if (!IDExists)
            {
                StoneRecord = null;
            }
            dataReader.Close();

            return StoneRecord;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string StoneID = Regex.Replace(comboBox1.Text, @"\s+", "");
            UpdateStoneDatabase(StoneID);
            this.Close();
        }

        private void UpdateStoneDatabase(string StoneID)
        {
            cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE TblStones SET StoneName = @StoneName, StoneColour = @StoneColour, StoneLocation = @StoneLocation, StoneFound = @StoneFound WHERE StoneID = @StoneID;";
            
            string StoneName = Regex.Replace(textBoxStoneName.Text, @"(^\s+|\s+$)", "");
            string StoneLocation = Regex.Replace(textBoxStoneLocation.Text, @"(^\s+|\s+$)", "");
            string StoneColour = Regex.Replace(textBoxStoneColour.Text, @"(^\s+|\s+$)", "");
            int StoneFound = checkBoxStoneFound.Checked ? 1 : 0;

            cmd.Parameters.AddWithValue("@StoneID", StoneID);
            cmd.Parameters.AddWithValue("@StoneName", StoneName);
            cmd.Parameters.AddWithValue("@StoneColour", StoneColour);
            cmd.Parameters.AddWithValue(@"StoneLocation", StoneLocation);
            cmd.Parameters.AddWithValue(@"StoneFound", StoneFound);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Stone Updated");
        }

        private void EditStoneFormcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StoneID = Regex.Replace(comboBox1.Text, @"\s+", "");
            UpdateStoneDatabase(StoneID);
            this.Close();
        }
    }
}
