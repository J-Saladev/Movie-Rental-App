namespace WinFormsApp1
{
    partial class UserConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpUsers = new GroupBox();
            grpActions = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grpMovieInsert = new GroupBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtZIP = new TextBox();
            label5 = new Label();
            grpActions.SuspendLayout();
            grpMovieInsert.SuspendLayout();
            SuspendLayout();
            // 
            // grpUsers
            // 
            grpUsers.Location = new Point(374, 2);
            grpUsers.Name = "grpUsers";
            grpUsers.Size = new Size(485, 446);
            grpUsers.TabIndex = 5;
            grpUsers.TabStop = false;
            grpUsers.Text = "All Users";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(17, 268);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(351, 180);
            grpActions.TabIndex = 4;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(65, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(233, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(65, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(233, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(65, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpMovieInsert
            // 
            grpMovieInsert.Controls.Add(label5);
            grpMovieInsert.Controls.Add(txtZIP);
            grpMovieInsert.Controls.Add(txtEmail);
            grpMovieInsert.Controls.Add(txtPhone);
            grpMovieInsert.Controls.Add(txtAddress);
            grpMovieInsert.Controls.Add(txtName);
            grpMovieInsert.Controls.Add(label4);
            grpMovieInsert.Controls.Add(label3);
            grpMovieInsert.Controls.Add(label2);
            grpMovieInsert.Controls.Add(label1);
            grpMovieInsert.Location = new Point(17, 6);
            grpMovieInsert.Name = "grpMovieInsert";
            grpMovieInsert.Size = new Size(351, 256);
            grpMovieInsert.TabIndex = 3;
            grpMovieInsert.TabStop = false;
            grpMovieInsert.Text = "Movie Summary";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(175, 116);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(175, 75);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 160);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 115);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 74);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Address: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 35);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // txtZIP
            // 
            txtZIP.Location = new Point(175, 207);
            txtZIP.Name = "txtZIP";
            txtZIP.Size = new Size(125, 27);
            txtZIP.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 208);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 9;
            label5.Text = "Zip Code:";
            // 
            // UserConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 462);
            Controls.Add(grpUsers);
            Controls.Add(grpActions);
            Controls.Add(grpMovieInsert);
            Name = "UserConfig";
            Text = "UserConfig";
            grpActions.ResumeLayout(false);
            grpMovieInsert.ResumeLayout(false);
            grpMovieInsert.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUsers;
        private GroupBox grpActions;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpMovieInsert;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtZIP;
    }
}