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
    }
}