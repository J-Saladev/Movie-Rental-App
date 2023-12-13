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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            rentsToolStripMenuItem = new ToolStripMenuItem();
            searchByToolStripMenuItem = new ToolStripMenuItem();
            titleToolStripMenuItem = new ToolStripMenuItem();
            directorToolStripMenuItem = new ToolStripMenuItem();
            genreToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            moviesToolStripMenuItem1 = new ToolStripMenuItem();
            usersToolStripMenuItem1 = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            searchByToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { titleToolStripMenuItem, directorToolStripMenuItem, genreToolStripMenuItem });
            searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            searchByToolStripMenuItem.Size = new Size(87, 24);
            searchByToolStripMenuItem.Text = "Search By";
            // 
            // titleToolStripMenuItem
            // 
            titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            titleToolStripMenuItem.Size = new Size(146, 26);
            titleToolStripMenuItem.Text = "Title";
            titleToolStripMenuItem.Click += titleToolStripMenuItem_Click;
            // 
            // directorToolStripMenuItem
            // 
            directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            directorToolStripMenuItem.Size = new Size(146, 26);
            directorToolStripMenuItem.Text = "Director";
            directorToolStripMenuItem.Click += directorToolStripMenuItem_Click;
            // 
            // genreToolStripMenuItem
            // 
            genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            genreToolStripMenuItem.Size = new Size(146, 26);
            genreToolStripMenuItem.Text = "Genre";
            genreToolStripMenuItem.Click += genreToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moviesToolStripMenuItem1, usersToolStripMenuItem1, rentalsToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // moviesToolStripMenuItem1
            // 
            moviesToolStripMenuItem1.Name = "moviesToolStripMenuItem1";
            moviesToolStripMenuItem1.Size = new Size(140, 26);
            moviesToolStripMenuItem1.Text = "Movies";
            moviesToolStripMenuItem1.Click += moviesToolStripMenuItem1_Click;
            // 
            // usersToolStripMenuItem1
            // 
            usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            usersToolStripMenuItem1.Size = new Size(140, 26);
            usersToolStripMenuItem1.Text = "Users";
            usersToolStripMenuItem1.Click += usersToolStripMenuItem1_Click;
            // 
            // rentalsToolStripMenuItem
            // 
            rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            rentalsToolStripMenuItem.Size = new Size(140, 26);
            rentalsToolStripMenuItem.Text = "Rentals";
            rentalsToolStripMenuItem.Click += rentalsToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-916, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 407);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ToolStripMenuItem titleToolStripMenuItem;
        private ToolStripMenuItem directorToolStripMenuItem;
        private ToolStripMenuItem genreToolStripMenuItem;
        private ToolStripMenuItem moviesToolStripMenuItem1;
        private ToolStripMenuItem usersToolStripMenuItem1;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}