namespace RockPaperScissors1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureboxrock = new System.Windows.Forms.PictureBox();
            this.pictureboxpaper = new System.Windows.Forms.PictureBox();
            this.pictureboxscissors = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureboxplayer = new System.Windows.Forms.PictureBox();
            this.pictureboxcomputer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxscissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcomputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxrock
            // 
            this.pictureboxrock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxrock.BackgroundImage")));
            this.pictureboxrock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxrock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxrock.Location = new System.Drawing.Point(92, 46);
            this.pictureboxrock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureboxrock.Name = "pictureboxrock";
            this.pictureboxrock.Size = new System.Drawing.Size(128, 89);
            this.pictureboxrock.TabIndex = 0;
            this.pictureboxrock.TabStop = false;
            this.pictureboxrock.Click += new System.EventHandler(this.pictureboxrock_Click);
            // 
            // pictureboxpaper
            // 
            this.pictureboxpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxpaper.BackgroundImage")));
            this.pictureboxpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxpaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxpaper.Location = new System.Drawing.Point(92, 178);
            this.pictureboxpaper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureboxpaper.Name = "pictureboxpaper";
            this.pictureboxpaper.Size = new System.Drawing.Size(128, 89);
            this.pictureboxpaper.TabIndex = 1;
            this.pictureboxpaper.TabStop = false;
            this.pictureboxpaper.Click += new System.EventHandler(this.pictureboxpaper_Click);
            // 
            // pictureboxscissors
            // 
            this.pictureboxscissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxscissors.BackgroundImage")));
            this.pictureboxscissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxscissors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxscissors.Location = new System.Drawing.Point(93, 307);
            this.pictureboxscissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureboxscissors.Name = "pictureboxscissors";
            this.pictureboxscissors.Size = new System.Drawing.Size(128, 89);
            this.pictureboxscissors.TabIndex = 2;
            this.pictureboxscissors.TabStop = false;
            this.pictureboxscissors.Click += new System.EventHandler(this.pictureboxscissors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "سنگ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "کاغذ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیچی";
            // 
            // pictureboxplayer
            // 
            this.pictureboxplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxplayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxplayer.Location = new System.Drawing.Point(417, 103);
            this.pictureboxplayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureboxplayer.Name = "pictureboxplayer";
            this.pictureboxplayer.Size = new System.Drawing.Size(150, 90);
            this.pictureboxplayer.TabIndex = 6;
            this.pictureboxplayer.TabStop = false;
            // 
            // pictureboxcomputer
            // 
            this.pictureboxcomputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxcomputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxcomputer.Location = new System.Drawing.Point(417, 242);
            this.pictureboxcomputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureboxcomputer.Name = "pictureboxcomputer";
            this.pictureboxcomputer.Size = new System.Drawing.Size(150, 90);
            this.pictureboxcomputer.TabIndex = 7;
            this.pictureboxcomputer.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "بازیکن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "کامپیوتر";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(627, 90);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(211, 276);
            this.listBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "نتیجه";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 434);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureboxcomputer);
            this.Controls.Add(this.pictureboxplayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureboxscissors);
            this.Controls.Add(this.pictureboxpaper);
            this.Controls.Add(this.pictureboxrock);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxscissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcomputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxrock;
        private System.Windows.Forms.PictureBox pictureboxpaper;
        private System.Windows.Forms.PictureBox pictureboxscissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureboxplayer;
        private System.Windows.Forms.PictureBox pictureboxcomputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
    }
}

