namespace WinFormsApp1
{
    partial class MoviesConfig
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
            grpMovieInsert = new GroupBox();
            chkAvailable = new CheckBox();
            chkPremiere = new CheckBox();
            txtActors = new TextBox();
            txtGenre = new TextBox();
            txtDirector = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            grpActions = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grpMovies = new GroupBox();
            dataMovies = new DataGridView();
            grpMovieInsert.SuspendLayout();
            grpActions.SuspendLayout();
            grpMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMovies).BeginInit();
            SuspendLayout();
            // 
            // grpMovieInsert
            // 
            grpMovieInsert.Controls.Add(btnClear);
            grpMovieInsert.Controls.Add(chkAvailable);
            grpMovieInsert.Controls.Add(chkPremiere);
            grpMovieInsert.Controls.Add(txtActors);
            grpMovieInsert.Controls.Add(txtGenre);
            grpMovieInsert.Controls.Add(txtDirector);
            grpMovieInsert.Controls.Add(txtTitle);
            grpMovieInsert.Controls.Add(label4);
            grpMovieInsert.Controls.Add(label3);
            grpMovieInsert.Controls.Add(label2);
            grpMovieInsert.Controls.Add(label1);
            grpMovieInsert.Location = new Point(15, 12);
            grpMovieInsert.Name = "grpMovieInsert";
            grpMovieInsert.Size = new Size(351, 260);
            grpMovieInsert.TabIndex = 0;
            grpMovieInsert.TabStop = false;
            grpMovieInsert.Text = "Movie Summary";
            grpMovieInsert.Enter += grpMovieInsert_Enter;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(240, 139);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(93, 24);
            chkAvailable.TabIndex = 9;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // chkPremiere
            // 
            chkPremiere.AutoSize = true;
            chkPremiere.Location = new Point(240, 95);
            chkPremiere.Name = "chkPremiere";
            chkPremiere.Size = new Size(90, 24);
            chkPremiere.TabIndex = 8;
            chkPremiere.Text = "Premiere";
            chkPremiere.UseVisualStyleBackColor = true;
            // 
            // txtActors
            // 
            txtActors.Location = new Point(97, 160);
            txtActors.Multiline = true;
            txtActors.Name = "txtActors";
            txtActors.Size = new Size(125, 80);
            txtActors.TabIndex = 7;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(97, 116);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 6;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(97, 75);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(97, 36);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 159);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 3;
            label4.Text = "Actors: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Genre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Director: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Title: ";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(252, 205);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(15, 278);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(351, 180);
            grpActions.TabIndex = 1;
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
            // grpMovies
            // 
            grpMovies.Controls.Add(dataMovies);
            grpMovies.Location = new Point(372, 12);
            grpMovies.Name = "grpMovies";
            grpMovies.Size = new Size(485, 442);
            grpMovies.TabIndex = 2;
            grpMovies.TabStop = false;
            grpMovies.Text = "All Movies";
            // 
            // dataMovies
            // 
            dataMovies.AllowUserToAddRows = false;
            dataMovies.AllowUserToDeleteRows = false;
            dataMovies.AllowUserToOrderColumns = true;
            dataMovies.AllowUserToResizeColumns = false;
            dataMovies.AllowUserToResizeRows = false;
            dataMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMovies.Location = new Point(20, 26);
            dataMovies.MultiSelect = false;
            dataMovies.Name = "dataMovies";
            dataMovies.ReadOnly = true;
            dataMovies.RowHeadersWidth = 51;
            dataMovies.RowTemplate.Height = 29;
            dataMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMovies.Size = new Size(459, 410);
            dataMovies.TabIndex = 0;
            dataMovies.CellContentClick += dataMovies_CellContentClick;
            dataMovies.RowEnter += dataMovies_RowEnter;
            dataMovies.MouseDown += dataMovies_MouseDown;
            // 
            // MoviesConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 483);
            Controls.Add(grpMovies);
            Controls.Add(grpActions);
            Controls.Add(grpMovieInsert);
            Name = "MoviesConfig";
            Text = "MoviesConfig";
            Load += MoviesConfig_Load;
            grpMovieInsert.ResumeLayout(false);
            grpMovieInsert.PerformLayout();
            grpActions.ResumeLayout(false);
            grpMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMovieInsert;
        private GroupBox grpActions;
        private GroupBox grpMovies;
        private TextBox txtTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkPremiere;
        private TextBox txtActors;
        private TextBox txtGenre;
        private TextBox txtDirector;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private CheckBox chkAvailable;
        private DataGridView dataMovies;
        private Button btnClear;
    }
}