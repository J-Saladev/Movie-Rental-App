using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1

{


    public partial class MoviesConfig : Form

    {
        int row = 0;

        Queries query = new Queries("localhost\\SQLEXPRESS", "Exercise_5");
        public MoviesConfig()
        {
            InitializeComponent();
        }
        public void GetMovies()
        {
            string load_table = "SELECT * FROM Movies";
            dataMovies.DataSource = query.ExecuteQuery(load_table);
        }
        public int GetMovieID(string director, string title)
        {
            string movieid = $"SELECT Movie_ID FROM Movies WHERE Title = '{title}' AND Director = '{director}'";
            var movielist = query.ExecuteQuery(movieid);
            int thisid = Convert.ToInt16(movielist.Rows[0]["Movie_ID"]);
            

            return thisid;


        }

        private void MoviesConfig_Load(object sender, EventArgs e)
        {
            GetMovies();
        }

        private void grpMovieInsert_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string actors = txtActors.Text;
            string genre = txtGenre.Text;
            bool premiere = chkPremiere.Checked ? true : false;
            bool available = chkAvailable.Checked ? true : false;
            string add = "INSERT INTO Movies (Title, Director, Actors, Genre, Is_Premiere, Is_Available) " +
                $"VALUES ('{title}','{director}','{actors}','{genre}','{premiere}','{available}');";
            query.ExecuteNonQuery(add);
            GetMovies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string actors = txtActors.Text;
            string genre = txtGenre.Text;
            bool premiere = chkPremiere.Checked ? true : false;
            bool available = chkAvailable.Checked ? true : false;
            int movieid = GetMovieID(director, title);
            string update = $"UPDATE Movies SET Title = '{title}', Director = '{director}', Actors = '{actors}', Genre = '{genre}', Is_Premiere = '{premiere}', Is_Available = '{available}'" +
                $"WHERE Movie_ID = {movieid}";
            query.ExecuteNonQuery(update);
            GetMovies();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            int movieid = GetMovieID(title, director);
            string delete = $"DELETE FROM Movies WHERE Movie_ID = {movieid} ";
            query.ExecuteNonQuery(delete);
            GetMovies();

        }


        private void dataMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataMovies_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataMovies_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = Convert.ToInt16(dataMovies.Rows[e.RowIndex].Cells["Movie_ID"].Value);



            txtTitle.Text = dataMovies.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            txtActors.Text = dataMovies.Rows[e.RowIndex].Cells["Actors"].Value.ToString();
            txtDirector.Text = dataMovies.Rows[e.RowIndex].Cells["Director"].Value.ToString();
            txtGenre.Text = dataMovies.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
            chkAvailable.Checked = dataMovies.Rows[e.RowIndex].Cells["Is_Available"].Value.ToString() == "True" ? true : false;
            chkPremiere.Checked = dataMovies.Rows[e.RowIndex].Cells["Is_Premiere"].Value.ToString() == "True" ? true : false;




        }
    }
}
