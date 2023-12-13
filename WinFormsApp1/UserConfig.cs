using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class UserConfig : Form
    {
        public UserConfig()
        {
            InitializeComponent();
        }
        Queries query = new Queries("localhost\\SQLEXPRESS", "Exercise_5");


        public void GetUsers()
        {
            string userselector = "SELECT * FROM Users ";
            var users = query.ExecuteQuery(userselector);
            dataUsers.DataSource = users;
        }
        public int GetUserID(string name, string email)
        {
            string userid = $"SELECT * FROM Users WHERE Name = '{name}' AND Email = '{email}'";
            var movielist = query.ExecuteQuery(userid);
            int thisid = Convert.ToInt16(movielist.Rows[0]["User_ID"]);
            return thisid;
        }
        public int GetUserID(string name)
        {
            string userid = $"SELECT * FROM Users WHERE Name = '{name}'";
            var movielist = query.ExecuteQuery(userid);
            int thisid = Convert.ToInt16(movielist.Rows[0]["User_ID"]);
            return thisid;
        }
        private void UserConfig_Load(object sender, EventArgs e)
        {
            GetUsers();
            ClearForm();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string zip = txtZIP.Text;
            string add = "INSERT INTO Users (Name, Phone_Num, Email, Address, Zip_Code)" +
                $"VALUES ('{name}', '{phone}', '{email}', '{address}', '{zip}');";
            query.ExecuteNonQuery(add);
            GetUsers();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string zip = txtZIP.Text;
            int userid = GetUserID(name, email);
            string update = $"UPDATE Users SET Name ='{name}', Phone_Num = '{phone}', Email = '{email}', Address = '{address}', Zip_Code = '{zip}' " +
                $"WHERE User_ID = {userid}";
            query.ExecuteNonQuery(update);
            GetUsers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            int userid = GetUserID(name, email);
            string delete = $"DELETE FROM Users WHERE User_ID = {userid}";
            query.ExecuteNonQuery(delete);
            GetUsers();
            ClearForm();
        }

        public void ClearForm()
        {
            txtAddress.Clear();
            txtZIP.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            btnClear.Visible = false;

        }

        private void dataUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnClear.Visible = true;
            txtName.Text = dataUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtAddress.Text = dataUsers.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            txtEmail.Text = dataUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            txtPhone.Text = dataUsers.Rows[e.RowIndex].Cells["Phone_Num"].Value.ToString();
            txtZIP.Text = dataUsers.Rows[e.RowIndex].Cells["Zip_Code"].Value.ToString();

        }
    }
}
