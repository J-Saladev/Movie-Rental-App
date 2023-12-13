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
    public partial class Display : Form
    {
        public string? thissection;
        public Display(string section)
        {
            InitializeComponent();
            thissection = section;
        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Exercise_5");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Display_Load(object sender, EventArgs e)
        {
            string displayinfo = $"Select * FROM {thissection}";
            dataDisplay.DataSource = query.ExecuteQuery(displayinfo);
            lblCurrentDisplay.Text = thissection;
        }
    }
}
