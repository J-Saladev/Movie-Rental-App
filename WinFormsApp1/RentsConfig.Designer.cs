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
            dataRents = new DataGridView();
            grpActions = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grpMovieInsert = new GroupBox();
            nudRentalID = new NumericUpDown();
            btnClear = new Button();
            slctMovieTitle = new ComboBox();
            slctUserName = new ComboBox();
            nudPrice = new NumericUpDown();
            dteReturnDate = new DateTimePicker();
            dteRentDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRents).BeginInit();
            grpActions.SuspendLayout();
            grpMovieInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRentalID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // grpUsers
            // 
            grpUsers.Controls.Add(dataRents);
            grpUsers.Location = new Point(373, 2);
            grpUsers.Name = "grpUsers";
            grpUsers.Size = new Size(485, 446);
            grpUsers.TabIndex = 8;
            grpUsers.TabStop = false;
            grpUsers.Text = "All Users";
            // 
            // dataRents
            // 
            dataRents.AllowUserToAddRows = false;
            dataRents.AllowUserToDeleteRows = false;
            dataRents.AllowUserToOrderColumns = true;
            dataRents.AllowUserToResizeColumns = false;
            dataRents.AllowUserToResizeRows = false;
            dataRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRents.Location = new Point(20, 26);
            dataRents.MultiSelect = false;
            dataRents.Name = "dataRents";
            dataRents.ReadOnly = true;
            dataRents.RowHeadersWidth = 51;
            dataRents.RowTemplate.Height = 29;
            dataRents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataRents.Size = new Size(459, 410);
            dataRents.TabIndex = 0;
            dataRents.RowEnter += dataRents_RowEnter_1;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(nudRentalID);
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
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(65, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(233, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(65, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpMovieInsert
            // 
            grpMovieInsert.Controls.Add(btnClear);
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
            // nudRentalID
            // 
            nudRentalID.Location = new Point(312, 143);
            nudRentalID.Name = "nudRentalID";
            nudRentalID.Size = new Size(39, 27);
            nudRentalID.TabIndex = 14;
            nudRentalID.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 203);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(68, 41);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // slctMovieTitle
            // 
            slctMovieTitle.FormattingEnabled = true;
            slctMovieTitle.Location = new Point(132, 210);
            slctMovieTitle.Name = "slctMovieTitle";
            slctMovieTitle.Size = new Size(142, 28);
            slctMovieTitle.TabIndex = 13;
            // 
            // slctUserName
            // 
            slctUserName.FormattingEnabled = true;
            slctUserName.Location = new Point(132, 159);
            slctUserName.Name = "slctUserName";
            slctUserName.Size = new Size(142, 28);
            slctUserName.TabIndex = 0;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(132, 115);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(142, 27);
            nudPrice.TabIndex = 12;
            // 
            // dteReturnDate
            // 
            dteReturnDate.Format = DateTimePickerFormat.Short;
            dteReturnDate.Location = new Point(132, 74);
            dteReturnDate.Name = "dteReturnDate";
            dteReturnDate.Size = new Size(142, 27);
            dteReturnDate.TabIndex = 11;
            // 
            // dteRentDate
            // 
            dteRentDate.Format = DateTimePickerFormat.Short;
            dteRentDate.Location = new Point(132, 35);
            dteRentDate.Name = "dteRentDate";
            dteRentDate.Size = new Size(142, 27);
            dteRentDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 209);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 9;
            label5.Text = "Movie Title: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 159);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "User Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 113);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Return Date: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Rent Date: ";
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
            Load += RentsConfig_Load;
            grpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataRents).EndInit();
            grpActions.ResumeLayout(false);
            grpMovieInsert.ResumeLayout(false);
            grpMovieInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRentalID).EndInit();
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
        private DataGridView dataRents;
        private Button btnClear;
        private NumericUpDown nudRentalID;
    }
}