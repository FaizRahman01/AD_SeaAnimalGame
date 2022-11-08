using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AD_SeaAnimalGame
{
    public partial class PlayerNamePage : Form
    {
        OleDbConnection dbcon = new OleDbConnection(Properties.Resources.AccessDB_StringConnection);
        private Point windowLocation;
        public PlayerNamePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelPNamePage_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void panelPNamePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainpage = new MainPage();
            mainpage.Show();
        }

        private void btnLoginPlayer_Click(object sender, EventArgs e)
        {
            

            dbcon.Open();
            OleDbCommand dbcmdlogin = new OleDbCommand();
            dbcmdlogin.Connection = dbcon;
            dbcmdlogin.CommandText = "select * from PlayerTbl where PlayerName = '" + tboxPName + "' ";

            OleDbDataReader reader = dbcmdlogin.ExecuteReader();
            int count = 0;

            while (reader.Read()) 
            {
                count = count + 1;
            }

            if(count == 1)
            {
                MessageBox.Show("Player Name is correct");
                dbcon.Close();
                dbcon.Dispose();
                this.Hide();
                SkinOptionPage skinoptionpage = new SkinOptionPage();
                skinoptionpage.Show();
            }
            else
            {
                MessageBox.Show("Player Name Not Found");
            }

            dbcon.Close();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            dbcon.Open();
            try
            {
                if (tboxPName.Text == "")
                {
                    MessageBox.Show("The player name cannot be empty");
                }
                else
                {
                    OleDbCommand dbcmdregister = new OleDbCommand("Insert into PlayerTbl (PlayerName)values('" + tboxPName + "')", dbcon);
                    dbcmdregister.ExecuteNonQuery();

                    MessageBox.Show("You have registered as player");
                    ClearTBoxForm();
                }
                
            }
            catch
            {
                MessageBox.Show("The player's name had already been used");
            }
            dbcon.Close();
        }

        void ClearTBoxForm()
        {
            tboxPName.Text = "";
        }
    }
}
