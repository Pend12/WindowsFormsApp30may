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

namespace WindowsFormsApp30may
{
    public partial class Form30May : Form
    {
        public Form30May()
        {
            InitializeComponent();
        }
        public MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable Data = new DataTable();
        public int posisi = 0;

        private void DataPraktikum()
        {
            labelIsiTeamName.Text = Data.Rows[posisi]["team_name"].ToString();
            labelManagerIsi.Text = Data.Rows[posisi]["CONCAT (manager.manager_name, '(',manager.nationality_id,')')"].ToString();
            labelStadiumIsi.Text = Data.Rows[posisi]["CONCAT( team.home_stadium,', ', team.city, ' (' ,team.capacity, ')')"].ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team.team_name, team.team_id, CONCAT( team.home_stadium,', ', team.city, ' (' ,team.capacity, ')'), CONCAT (manager.manager_name, '(',manager.nationality_id,')'), manager.manager_id, nationality.nationality_id, team.manager_id FROM team team, manager manager, nationality nationality WHERE manager.nationality_id = nationality.nationality_id and team.manager_id = manager.manager_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Data);
            DataPraktikum();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            int firstPosition = 0;
            {
                posisi = 0;
                DataPraktikum();

                if (firstPosition == 0)
                {
                    MessageBox.Show("Data Pertama!");
                    firstPosition = 0;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            posisi--;
            if (posisi < 0)
            {
                posisi = posisi + 1;
                DataPraktikum();
                MessageBox.Show("Data Pertama!");
            }
            else
            {
                DataPraktikum();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            posisi++;
            if (posisi > 858)
            {
                posisi = posisi - 1;
                DataPraktikum();
                MessageBox.Show("Data Terakhir!");
            }
            else
            {
                DataPraktikum();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            int lastPosition = 0;

            {
                posisi = Data.Rows.Count - 1;
                DataPraktikum();
                lastPosition = lastPosition + 1;

                if (lastPosition >= 1)
                {
                    MessageBox.Show("Data Terakhir!");
                    lastPosition = 0;
                }
            }
        }
    }
}
