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

        private Point FormPosition;
        private void panelScorePage_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPosition = e.Location;
        }

        private void panelScorePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
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
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
        }

        private void ScorePage_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = Session.SessionName;

            dbcon.Open();

            //gridview
            OleDbCommand dbcmdscore = new OleDbCommand();
            dbcmdscore.Connection = dbcon;
            dbcmdscore.CommandText = "select top 5 PlayerId, max(PlayerScore) as PScore from PlayerScoreTbl group by PlayerId";

            OleDbDataAdapter dascore = new OleDbDataAdapter(dbcmdscore);
            DataTable dtscore = new DataTable();
            dascore.Fill(dtscore);
            dataGridViewScore.DataSource = dtscore;


            //----------user profile section------------------
            //show player login session id
            OleDbCommand dbcmdpid = new OleDbCommand();
            dbcmdpid.Connection = dbcon;
            dbcmdpid.CommandText = "select PlayerId, PlayerName from PlayerTbl where PlayerName = '" + lblPlayerName.Text + "' ";

            OleDbDataReader dbreader = dbcmdpid.ExecuteReader();


            if (dbreader.Read())
            {

                lblPlayerId.Text = dbreader["PlayerId"].ToString();

            }
            else
            {
                MessageBox.Show("Player name not found");
            }

            //chart
            OleDbCommand dbcmduserscore = new OleDbCommand();
            dbcmduserscore.Connection = dbcon;
            dbcmduserscore.CommandText = "select top 5 PlayerId, PlayerScore from PlayerScoreTbl where PlayerId = @pid";
            dbcmduserscore.Parameters.AddWithValue("@pid", lblPlayerId.Text);

            OleDbDataReader dbuserscorereader = dbcmduserscore.ExecuteReader();


            while (dbuserscorereader.Read())
            {

                PlayerScoreChart.Series["High Score"].Points.AddXY("FL" + dbuserscorereader["PlayerId"].ToString(), dbuserscorereader["PlayerScore"].ToString());

            }

            dbcon.Close();
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            dbcon.Open();
            OleDbCommand dbcmdsearch = new OleDbCommand();
            dbcmdsearch.Connection = dbcon;
            dbcmdsearch.CommandText = "select PlayerId, PlayerName from PlayerTbl where PlayerId = @pid";
            dbcmdsearch.Parameters.AddWithValue("@pid", tboxSearchPName.Text);

            OleDbDataReader dbreader = dbcmdsearch.ExecuteReader();


            if (dbreader.Read())
            {

                lblShowPName.Text = dbreader["PlayerName"].ToString();
                dbcon.Close();
            }
            else
            {
                MessageBox.Show("Player name not found");
            }
            
        }
    }
}
