namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            rentsToolStripMenuItem = new ToolStripMenuItem();
            searchByToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { maintenanceToolStripMenuItem, searchByToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moviesToolStripMenuItem, usersToolStripMenuItem, rentsToolStripMenuItem });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(108, 24);
            maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            moviesToolStripMenuItem.Size = new Size(224, 26);
            moviesToolStripMenuItem.Text = "Movies";
            moviesToolStripMenuItem.Click += moviesToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(224, 26);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // rentsToolStripMenuItem
            // 
            rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            rentsToolStripMenuItem.Size = new Size(224, 26);
            rentsToolStripMenuItem.Text = "Rents";
            rentsToolStripMenuItem.Click += rentsToolStripMenuItem_Click;
            // 
            // searchByToolStripMenuItem
            // 
            searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            searchByToolStripMenuItem.Size = new Size(87, 24);
            searchByToolStripMenuItem.Text = "Search By";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem rentsToolStripMenuItem;
        private ToolStripMenuItem searchByToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}