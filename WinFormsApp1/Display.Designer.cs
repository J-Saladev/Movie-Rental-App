namespace WinFormsApp1
{
    partial class Display
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
            lblCurrentDisplay = new Label();
            dataDisplay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataDisplay).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentDisplay
            // 
            lblCurrentDisplay.AutoSize = true;
            lblCurrentDisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentDisplay.Location = new Point(366, 30);
            lblCurrentDisplay.Name = "lblCurrentDisplay";
            lblCurrentDisplay.Size = new Size(76, 31);
            lblCurrentDisplay.TabIndex = 0;
            lblCurrentDisplay.Text = "label1";
            lblCurrentDisplay.Click += label1_Click;
            // 
            // dataDisplay
            // 
            dataDisplay.AllowUserToAddRows = false;
            dataDisplay.AllowUserToDeleteRows = false;
            dataDisplay.AllowUserToOrderColumns = true;
            dataDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDisplay.Location = new Point(45, 76);
            dataDisplay.Name = "dataDisplay";
            dataDisplay.ReadOnly = true;
            dataDisplay.RowHeadersWidth = 51;
            dataDisplay.RowTemplate.Height = 29;
            dataDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataDisplay.Size = new Size(716, 347);
            dataDisplay.TabIndex = 1;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataDisplay);
            Controls.Add(lblCurrentDisplay);
            Name = "Display";
            Text = "Display";
            Load += Display_Load;
            ((System.ComponentModel.ISupportInitialize)dataDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentDisplay;
        private DataGridView dataDisplay;
    }
}