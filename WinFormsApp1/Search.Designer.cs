namespace WinFormsApp1
{
    partial class Search
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
            lblMovieSearch = new Label();
            txtMovieSearch = new TextBox();
            btnSearch = new Button();
            dataSearchDisplay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataSearchDisplay).BeginInit();
            SuspendLayout();
            // 
            // lblMovieSearch
            // 
            lblMovieSearch.AutoSize = true;
            lblMovieSearch.Location = new Point(162, 74);
            lblMovieSearch.Name = "lblMovieSearch";
            lblMovieSearch.Size = new Size(50, 20);
            lblMovieSearch.TabIndex = 0;
            lblMovieSearch.Text = "label1";
            lblMovieSearch.Click += lblMovieSearch_Click;
            // 
            // txtMovieSearch
            // 
            txtMovieSearch.Location = new Point(240, 71);
            txtMovieSearch.Name = "txtMovieSearch";
            txtMovieSearch.Size = new Size(290, 27);
            txtMovieSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(568, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataSearchDisplay
            // 
            dataSearchDisplay.AllowUserToAddRows = false;
            dataSearchDisplay.AllowUserToDeleteRows = false;
            dataSearchDisplay.AllowUserToResizeRows = false;
            dataSearchDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSearchDisplay.Location = new Point(50, 134);
            dataSearchDisplay.Name = "dataSearchDisplay";
            dataSearchDisplay.ReadOnly = true;
            dataSearchDisplay.RowHeadersWidth = 51;
            dataSearchDisplay.RowTemplate.Height = 29;
            dataSearchDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataSearchDisplay.Size = new Size(715, 289);
            dataSearchDisplay.TabIndex = 3;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataSearchDisplay);
            Controls.Add(btnSearch);
            Controls.Add(txtMovieSearch);
            Controls.Add(lblMovieSearch);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataSearchDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieSearch;
        private TextBox txtMovieSearch;
        private Button btnSearch;
        private DataGridView dataSearchDisplay;
    }
}