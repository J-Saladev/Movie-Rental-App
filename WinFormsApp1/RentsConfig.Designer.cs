namespace WinFormsApp1
{
    partial class RentsConfig
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dteRentDate = new DateTimePicker();
            dteReturnDate = new DateTimePicker();
            nudPrice = new NumericUpDown();
            slctUserName = new ComboBox();
            slctMovieTitle = new ComboBox();
            grpActions.SuspendLayout();
            grpMovieInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // grpUsers
            // 
            grpUsers.Location = new Point(373, 2);
            grpUsers.Name = "grpUsers";
            grpUsers.Size = new Size(485, 446);
            grpUsers.TabIndex = 8;
            grpUsers.TabStop = false;
            grpUsers.Text = "All Users";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(16, 268);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(351, 180);
            grpActions.TabIndex = 7;
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
            grpMovieInsert.Controls.Add(slctMovieTitle);
            grpMovieInsert.Controls.Add(slctUserName);
            grpMovieInsert.Controls.Add(nudPrice);
            grpMovieInsert.Controls.Add(dteReturnDate);
            grpMovieInsert.Controls.Add(dteRentDate);
            grpMovieInsert.Controls.Add(label5);
            grpMovieInsert.Controls.Add(label4);
            grpMovieInsert.Controls.Add(label3);
            grpMovieInsert.Controls.Add(label2);
            grpMovieInsert.Controls.Add(label1);
            grpMovieInsert.Location = new Point(16, 6);
            grpMovieInsert.Name = "grpMovieInsert";
            grpMovieInsert.Size = new Size(351, 256);
            grpMovieInsert.TabIndex = 6;
            grpMovieInsert.TabStop = false;
            grpMovieInsert.Text = "Movie Summary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 209);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 9;
            label5.Text = "Movie Title: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 159);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "User Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 113);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Return Date: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Rent Date: ";
            // 
            // dteRentDate
            // 
            dteRentDate.Format = DateTimePickerFormat.Short;
            dteRentDate.Location = new Point(168, 35);
            dteRentDate.Name = "dteRentDate";
            dteRentDate.Size = new Size(142, 27);
            dteRentDate.TabIndex = 10;
            // 
            // dteReturnDate
            // 
            dteReturnDate.Format = DateTimePickerFormat.Short;
            dteReturnDate.Location = new Point(168, 74);
            dteReturnDate.Name = "dteReturnDate";
            dteReturnDate.Size = new Size(142, 27);
            dteReturnDate.TabIndex = 11;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(168, 115);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(142, 27);
            nudPrice.TabIndex = 12;
            // 
            // slctUserName
            // 
            slctUserName.FormattingEnabled = true;
            slctUserName.Location = new Point(168, 159);
            slctUserName.Name = "slctUserName";
            slctUserName.Size = new Size(142, 28);
            slctUserName.TabIndex = 0;
            // 
            // slctMovieTitle
            // 
            slctMovieTitle.FormattingEnabled = true;
            slctMovieTitle.Location = new Point(168, 210);
            slctMovieTitle.Name = "slctMovieTitle";
            slctMovieTitle.Size = new Size(142, 28);
            slctMovieTitle.TabIndex = 13;
            // 
            // RentsConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 458);
            Controls.Add(grpUsers);
            Controls.Add(grpActions);
            Controls.Add(grpMovieInsert);
            Name = "RentsConfig";
            Text = "RentsConfig";
            grpActions.ResumeLayout(false);
            grpMovieInsert.ResumeLayout(false);
            grpMovieInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUsers;
        private GroupBox grpActions;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpMovieInsert;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox slctMovieTitle;
        private ComboBox slctUserName;
        private NumericUpDown nudPrice;
        private DateTimePicker dteReturnDate;
        private DateTimePicker dteRentDate;
    }
}