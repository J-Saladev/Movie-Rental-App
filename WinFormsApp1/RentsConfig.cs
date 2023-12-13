using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RentsConfig : Form
    {
        MoviesConfig MoviesConfig = new MoviesConfig();
        UserConfig UserConfig = new UserConfig();
        public RentsConfig()
        {
            InitializeComponent();
        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Exercise_5");
        public void GetRents()
        {
            string load_table = "SELECT r.Rental_Date, r.Return_Date, r.Price, u.Name, m.Title FROM Rentals AS r " +
                "INNER JOIN Users AS u ON r.User_ID = u.User_ID " +
                "INNER JOIN Movies AS m ON r.Movie_Id = m.Movie_ID ";
            dataRents.DataSource = query.ExecuteQuery(load_table);

        }

        public void ClearForm()
        {
            dteRentDate.Value = DateTime.Now;
            dteReturnDate.Value = DateTime.Now;
            nudPrice.Value = 0;
            slctMovieTitle.Text = "";
            slctUserName.Text = "";
            btnClear.Visible = false;
            nudRentalID.Value = 0;

        }
        public void LoadSelect()
        {
            string name = "SELECT Name, User_ID FROM Users";
            string movie = "SELECT Title, Movie_ID FROM Movies";
            var usernames = query.ExecuteQuery(name);
            var movienames = query.ExecuteQuery(movie);
            foreach (DataRow row in usernames.Rows)
            {
                slctUserName.Items.Add(row["Name"].ToString());
            }
            foreach (DataRow row in movienames.Rows)
            {
                slctMovieTitle.Items.Add(row["Title"].ToString());
            }
        }
        private void RentsConfig_Load(object sender, EventArgs e)
        {
            GetRents();
            LoadSelect();
            ClearForm();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateOnly rentdate = DateOnly.FromDateTime(dteRentDate.Value);
            DateOnly returndate = DateOnly.FromDateTime(dteReturnDate.Value);
            decimal price = nudPrice.Value;
            string movie = slctMovieTitle.Text;
            string name = slctUserName.Text;
            int userid = UserConfig.GetUserID(name);
            int movieid = MoviesConfig.GetMovieID(movie);
            MessageBox.Show(Convert.ToString(rentdate));



            string add = "INSERT INTO Rentals (Rental_Date, Return_Date, Price, User_ID, Movie_ID) " +
                $"VALUES ({rentdate}, {returndate}, {price}, {userid}, {movieid})";
            query.ExecuteNonQuery(add);



        }

        private void dataRents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dteRentDate.Value = Convert.ToDateTime(dataRents.Rows[e.RowIndex].Cells["Rental_Date"].Value);
            dteReturnDate.Value = Convert.ToDateTime(dataRents.Rows[e.RowIndex].Cells["Return_Date"].Value);
            nudPrice.Value = Convert.ToInt16(dataRents.Rows[e.RowIndex].Cells["Price"].Value);
            int movieid = Convert.ToInt16(dataRents.Rows[e.RowIndex].Cells["Movie_ID"].Value);
            int userid = Convert.ToInt16(dataRents.Rows[e.RowIndex].Cells["User_ID"].Value);
            int rentid = Convert.ToInt16(dataRents.Rows[e.RowIndex].Cells["Rental_ID"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime rentdate = dteRentDate.Value;
            DateTime returndate = dteReturnDate.Value;
            decimal price = nudPrice.Value;
            string movie = slctMovieTitle.Text;
            string name = slctUserName.Text;
            int userid = UserConfig.GetUserID(name);
            int movieid = MoviesConfig.GetMovieID(movie);
            int rentalid = Convert.ToInt16(nudRentalID);

            string update = $"UPDATE Rentals SET  Rental_Date = {rentdate}, Return_Date = {returndate}, Price = {price}, User_ID = {userid}, Movie_ID = {movieid} WHERE Rental_ID = {rentalid}";
            query.ExecuteNonQuery(update);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           int rentid = Convert.ToInt16(nudRentalID.Value);
            string delete = $"DELETE FROM Rentals WHERE Rental_ID = {rentid}";
            query.ExecuteNonQuery(delete);
        }
    }
}
