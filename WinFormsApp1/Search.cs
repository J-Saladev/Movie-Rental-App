using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Search : Form
    {
        public string? searchbysection;
        public Search(string section)
        {
            InitializeComponent();
            searchbysection = section;

        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Exercise_5");
        private void lblMovieSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtMovieSearch.Text;
            string findsearch = "SELECT * FROM Movies " +
                $"WHERE {searchbysection} LIKE '%{search}%'";
            dataSearchDisplay.DataSource = query.ExecuteQuery(findsearch);



        }

        private void Search_Load(object sender, EventArgs e)
        {
            lblMovieSearch.Text = searchbysection;
        }
    }
}
