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
    public partial class ScorePage : Form
    {
        OleDbConnection dbcon = new OleDbConnection(Properties.Resources.AccessDB_StringConnection);
        public ScorePage()
        {
            InitializeComponent();
        }
        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top 
        private void panelScorePage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelScorePage_MouseMove(object sender, MouseEventArgs e)
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
            //hide this page and open other form
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
        }

        private void ScorePage_Load(object sender, EventArgs e)
        {
            //get passing value in Session.cs from the PlayerNamePage
            lblPlayerName.Text = Session.SessionName;

            dbcon.Open();

            //gridview
            OleDbCommand dbcmdscore = new OleDbCommand();
            dbcmdscore.Connection = dbcon;
            //show only 5 player with the highest score that they achieved in the game
            dbcmdscore.CommandText = "SELECT TOP 5  PlayerTbl.PlayerName as PlayerName, max(PlayerScoreTbl.PlayerScore) as Score " +
                                     "FROM PlayerScoreTbl INNER JOIN PlayerTbl ON PlayerScoreTbl.PlayerId=PlayerTbl.PlayerId " +
                                     "GROUP BY PlayerTbl.PlayerName ORDER BY max(PlayerScoreTbl.PlayerScore) desc;";

            OleDbDataAdapter dascore = new OleDbDataAdapter(dbcmdscore);
            DataTable dtscore = new DataTable();
            dascore.Fill(dtscore);
            dataGridViewScore.DataSource = dtscore;


            //----------user profile section------------------

            //chart
            OleDbCommand dbcmduserscore = new OleDbCommand();
            dbcmduserscore.Connection = dbcon;
            //show the top 5 highest score for the user that login
            dbcmduserscore.CommandText = "SELECT top 5 PlayerTbl.PlayerName, PlayerScoreTbl.PlayerScore FROM PlayerScoreTbl " +
                                         "LEFT JOIN PlayerTbl ON PlayerScoreTbl.PlayerId=PlayerTbl.PlayerId " +
                                         "WHERE PlayerTbl.PlayerName = @pname ORDER BY  PlayerScoreTbl.PlayerScore desc";
            dbcmduserscore.Parameters.AddWithValue("@pname", lblPlayerName.Text);

            OleDbDataReader dbuserscorereader = dbcmduserscore.ExecuteReader();


            while (dbuserscorereader.Read())
            {

                PlayerScoreChart.Series["Player Score"].Points.AddXY(dbuserscorereader["PlayerName"].ToString(), dbuserscorereader["PlayerScore"].ToString());

            }

            dbcon.Close();
        }
    }
}
