namespace WinFormsApp1
{
    using Microsoft.Data.SqlClient;
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesConfig moviesconfig = new MoviesConfig();
            moviesconfig.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserConfig userConfig = new UserConfig();
            userConfig.ShowDialog();
        }

        private void rentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentsConfig rentsConfig = new RentsConfig();
            rentsConfig.ShowDialog();
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search("Title");
            search.ShowDialog();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search("Director");
            search.ShowDialog();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search("Genre");
            search.ShowDialog();
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Display display = new Display("Movies");
            display.ShowDialog();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Display display = new Display("Users");
            display.ShowDialog();
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Display display = new Display("Rentals");
            display.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}