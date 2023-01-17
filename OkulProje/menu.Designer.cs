namespace OkulProje
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okulYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(507, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Paneli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(507, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Okul Yönetim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(45, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ders Paneli";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(45, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Öğrenci Ders Paneli";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Batuhan Eren Bingöl";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.okulYönetimToolStripMenuItem,
            this.dersPaneliToolStripMenuItem,
            this.gitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciDersPaneliToolStripMenuItem,
            this.öğrenciPaneliToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciDersPaneliToolStripMenuItem
            // 
            this.öğrenciDersPaneliToolStripMenuItem.Name = "öğrenciDersPaneliToolStripMenuItem";
            this.öğrenciDersPaneliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciDersPaneliToolStripMenuItem.Text = "Öğrenci Ders Paneli";
            // 
            // öğrenciPaneliToolStripMenuItem
            // 
            this.öğrenciPaneliToolStripMenuItem.Name = "öğrenciPaneliToolStripMenuItem";
            this.öğrenciPaneliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciPaneliToolStripMenuItem.Text = "Öğrenci Paneli";
            // 
            // okulYönetimToolStripMenuItem
            // 
            this.okulYönetimToolStripMenuItem.Name = "okulYönetimToolStripMenuItem";
            this.okulYönetimToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.okulYönetimToolStripMenuItem.Text = "Okul Yönetim";
            // 
            // dersPaneliToolStripMenuItem
            // 
            this.dersPaneliToolStripMenuItem.Name = "dersPaneliToolStripMenuItem";
            this.dersPaneliToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dersPaneliToolStripMenuItem.Text = "Ders Paneli";
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.gitToolStripMenuItem.Text = "git";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.gitToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(736, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menüler";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okulYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
    }
}

