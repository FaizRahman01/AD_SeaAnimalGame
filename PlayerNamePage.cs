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
        
        public PlayerNamePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top 
        private void panelPNamePage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelPNamePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // let user to drag the form anywhere in coordinate x and y
                this.Location = new Point(
                    (this.Location.X - FormPosition.X) + e.X,
                    (this.Location.Y - FormPosition.Y) + e.Y
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
            //select player name from database that match in the tboxPname.text
            dbcmdlogin.CommandText = "select PlayerId, PlayerName from PlayerTbl where PlayerName = '" + tboxPName.Text + "' ";

            OleDbDataReader dbreader = dbcmdlogin.ExecuteReader();

            
            if(dbreader.Read())
            {
                //if the username is registered in database it will run this statement
                MessageBox.Show("Player Name is correct");
                dbcon.Close();

                this.Hide();
                SkinOptionPage skinoptionpage = new SkinOptionPage();
                skinoptionpage.Show();
                //take the username in textbox and pass the value to Session.cs class
                Session.SessionName = tboxPName.Text;
            }
            else
            {
                //if the username not registered it will run this
                MessageBox.Show("Player Name Not Found");
            }

            dbcon.Close();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {
            dbcon.Open();
            try
            {
                //username cannot have spacing and the textbox cannot be blank to register
                if (tboxPName.Text.Contains(" ") || tboxPName.Text == "")
                {
                    MessageBox.Show("The player name cannot be empty and have spacing");
                }

                else
                {
                    //insert the new player username to database that type by the user in textbox
                    OleDbCommand dbcmdregister = new OleDbCommand("Insert into PlayerTbl (PlayerName)values('" + tboxPName.Text + "')", dbcon);
                    dbcmdregister.ExecuteNonQuery();

                    MessageBox.Show("You have registered as player");
                    //call method to clear the textbox after the user register 
                    ClearTBoxForm();
                }
                
            }
            catch
            {
                //if the username is duplicate with the one in database it will show this message
                //the username properties in microsoft access file set as cannot duplicate
                MessageBox.Show("The player's name had already been used");
            }
            dbcon.Close();
        }

        void ClearTBoxForm()
        {
            //clear textbox value 
            tboxPName.Text = "";
        }
    }
}
