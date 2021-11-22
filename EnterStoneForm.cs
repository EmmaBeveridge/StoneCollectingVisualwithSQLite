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
    public partial class EnterStoneForm : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        public EnterStoneForm()
        {
            InitializeComponent();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxStoneName.Text, @"\S+")||!Regex.IsMatch(textBoxStoneColour.Text, @"\S+")||!Regex.IsMatch(textBoxStoneLocation.Text, @"\S+"))
            
            {
                MessageBox.Show("Please correct invalid fields");
                CheckStoneName();
                CheckStoneColour();
                CheckStoneLocation();
                
            }
            else
            {
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
                try
                {   
                    string StoneID = GenerateUniqueID(conn, cmd);
                    string StoneName = Regex.Replace(textBoxStoneName.Text, @"(^\s+|\s+$)",  "");
                    string StoneLocation = Regex.Replace(textBoxStoneLocation.Text, @"(^\s+|\s+$)", "");
                    string StoneColour = Regex.Replace(textBoxStoneColour.Text, @"(^\s+|\s+$)", "");
                    int StoneFound = checkBoxStoneFound.Checked ? 1 : 0;

                    cmd.CommandText = "INSERT INTO TblStones (StoneID, StoneName, StoneColour, StoneLocation, StoneFound) VALUES (@StoneID, @StoneName, @StoneColour, @StoneLocation, @StoneFound)";

                    
                    cmd.Parameters.AddWithValue("@StoneID", StoneID);
                    cmd.Parameters.AddWithValue("@StoneName", StoneName);
                    cmd.Parameters.AddWithValue("@StoneColour", StoneColour);
                    cmd.Parameters.AddWithValue(@"StoneLocation", StoneLocation);
                    cmd.Parameters.AddWithValue(@"StoneFound", StoneFound);
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Stone ID {StoneID} Added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Close();
            }
        }


        protected string GenerateUniqueID(SQLiteConnection conn, SQLiteCommand cmd)
        {
            bool isUnique = true;
            int intNewID;
            string strNewID;
            Random rand = new Random();
            SQLiteDataReader dataReader;

            do
            {
                intNewID = rand.Next(10000);
                strNewID = intNewID.ToString().PadLeft(4, '0');
                cmd.CommandText = "SELECT * FROM TblStones WHERE StoneID=@NewStoneID";
                cmd.Parameters.AddWithValue("@NewStoneID", strNewID);

                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    isUnique = false;
                }
                dataReader.Close();

            } while (!isUnique);

            return (strNewID);


        }
        





        protected void textBoxStoneName_TextChanged(object sender, EventArgs e)
        {
            CheckStoneName();

        }

        protected void CheckStoneName()
        {
            bool nameValid = Regex.IsMatch(textBoxStoneName.Text, @"\S+");
            if (nameValid)
            {
                label5.Text = "";
            }
            else
            {
                label5.Text = "Name entered is invalid";
            }
        }

        private void EnterStoneForm_Load(object sender, EventArgs e)
        {
            
        }

        protected void textBoxStoneColour_TextChanged(object sender, EventArgs e)
        {
            CheckStoneColour();
        }

        protected void CheckStoneColour()
        {
            bool colourValid = Regex.IsMatch(textBoxStoneColour.Text, @"\S+");
            if (colourValid)
            {
                label6.Text = "";
            }
            else
            {
                label6.Text = "Colour entered is invalid";
            }
        }

        protected void textBoxStoneLocation_TextChanged(object sender, EventArgs e)
        {
            CheckStoneLocation();
        }

        protected void CheckStoneLocation()
        {
            bool locationValid = Regex.IsMatch(textBoxStoneLocation.Text, @"\S+");
            if (locationValid)
            {
                label7.Text = "";
            }
            else
            {
                label7.Text = "Location entered is invalid";
            }
        }

        private void EnterStoneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
