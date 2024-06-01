namespace HDH_WIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.nopeterson = new System.Windows.Forms.Button();
            this.PCPink = new System.Windows.Forms.Button();
            this.cahai = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.carblue = new System.Windows.Forms.PictureBox();
            this.Do1 = new System.Windows.Forms.PictureBox();
            this.Xanh1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Bum = new System.Windows.Forms.PictureBox();
            this.carpink = new System.Windows.Forms.PictureBox();
            this.Xanh = new System.Windows.Forms.PictureBox();
            this.Do = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tablepc0 = new System.Windows.Forms.Button();
            this.tablepc1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.carblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Do1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xanh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Do)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            // 
            // nopeterson
            // 
            this.nopeterson.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nopeterson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopeterson.ForeColor = System.Drawing.Color.OrangeRed;
            this.nopeterson.Location = new System.Drawing.Point(0, 22);
            this.nopeterson.Name = "nopeterson";
            this.nopeterson.Size = new System.Drawing.Size(231, 59);
            this.nopeterson.TabIndex = 9;
            this.nopeterson.Text = "CLICK";
            this.nopeterson.UseVisualStyleBackColor = false;
            this.nopeterson.Click += new System.EventHandler(this.nopeterson_Click);
            // 
            // PCPink
            // 
            this.PCPink.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PCPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCPink.ForeColor = System.Drawing.Color.Fuchsia;
            this.PCPink.Location = new System.Drawing.Point(0, 72);
            this.PCPink.Name = "PCPink";
            this.PCPink.Size = new System.Drawing.Size(231, 62);
            this.PCPink.TabIndex = 10;
            this.PCPink.Text = "Car Pink (PC0)";
            this.PCPink.UseVisualStyleBackColor = false;
            this.PCPink.Click += new System.EventHandler(this.PCPink_Click);
            // 
            // cahai
            // 
            this.cahai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cahai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cahai.ForeColor = System.Drawing.Color.OrangeRed;
            this.cahai.Location = new System.Drawing.Point(0, 133);
            this.cahai.Name = "cahai";
            this.cahai.Size = new System.Drawing.Size(231, 57);
            this.cahai.TabIndex = 15;
            this.cahai.Text = "ALL";
            this.cahai.UseVisualStyleBackColor = false;
            this.cahai.Click += new System.EventHandler(this.cahai_Click_1);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.blue.Location = new System.Drawing.Point(0, 18);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(231, 59);
            this.blue.TabIndex = 16;
            this.blue.Text = "Car Blue (PC1)";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.button2_Click);
            // 
            // carblue
            // 
            this.carblue.BackColor = System.Drawing.Color.Transparent;
            this.carblue.Image = global::HDH_WIN.Properties.Resources.car_removebg_preview;
            this.carblue.Location = new System.Drawing.Point(374, 493);
            this.carblue.Name = "carblue";
            this.carblue.Size = new System.Drawing.Size(54, 81);
            this.carblue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carblue.TabIndex = 19;
            this.carblue.TabStop = false;
            // 
            // Do1
            // 
            this.Do1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Do1.BackgroundImage = global::HDH_WIN.Properties.Resources.Untitled;
            this.Do1.Image = global::HDH_WIN.Properties.Resources.red1_removebg_preview;
            this.Do1.Location = new System.Drawing.Point(495, 350);
            this.Do1.Name = "Do1";
            this.Do1.Size = new System.Drawing.Size(36, 37);
            this.Do1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Do1.TabIndex = 14;
            this.Do1.TabStop = false;
            this.Do1.Visible = false;
            // 
            // Xanh1
            // 
            this.Xanh1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Xanh1.Image = global::HDH_WIN.Properties.Resources.Eo_circle_green_blank1;
            this.Xanh1.Location = new System.Drawing.Point(495, 306);
            this.Xanh1.Name = "Xanh1";
            this.Xanh1.Size = new System.Drawing.Size(36, 38);
            this.Xanh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Xanh1.TabIndex = 13;
            this.Xanh1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(459, 293);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 117);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // Bum
            // 
            this.Bum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bum.Image = ((System.Drawing.Image)(resources.GetObject("Bum.Image")));
            this.Bum.Location = new System.Drawing.Point(332, 175);
            this.Bum.Name = "Bum";
            this.Bum.Size = new System.Drawing.Size(118, 109);
            this.Bum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bum.TabIndex = 11;
            this.Bum.TabStop = false;
            this.Bum.Visible = false;
            // 
            // carpink
            // 
            this.carpink.BackColor = System.Drawing.Color.Transparent;
            this.carpink.Image = global::HDH_WIN.Properties.Resources.cảpink_removebg_preview;
            this.carpink.Location = new System.Drawing.Point(23, 216);
            this.carpink.Name = "carpink";
            this.carpink.Size = new System.Drawing.Size(100, 47);
            this.carpink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpink.TabIndex = 8;
            this.carpink.TabStop = false;
            // 
            // Xanh
            // 
            this.Xanh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Xanh.Image = global::HDH_WIN.Properties.Resources.Eo_circle_green_blank2;
            this.Xanh.Location = new System.Drawing.Point(251, 50);
            this.Xanh.Name = "Xanh";
            this.Xanh.Size = new System.Drawing.Size(35, 40);
            this.Xanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Xanh.TabIndex = 4;
            this.Xanh.TabStop = false;
            // 
            // Do
            // 
            this.Do.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Do.Image = global::HDH_WIN.Properties.Resources.red1_removebg_preview1;
            this.Do.Location = new System.Drawing.Point(251, 96);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(35, 35);
            this.Do.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Do.TabIndex = 3;
            this.Do.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::HDH_WIN.Properties.Resources.traffic_light2;
            this.pictureBox3.Location = new System.Drawing.Point(217, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(341, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 88);
            this.label1.TabIndex = 20;
            this.label1.Text = "Critical Region";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(327, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 65);
            this.label3.TabIndex = 22;
            this.label3.Text = "NonCritical Region";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(99, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 65);
            this.label2.TabIndex = 23;
            this.label2.Text = "NonCritical Region";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(339, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 65);
            this.label4.TabIndex = 24;
            this.label4.Text = "NonCritical Region";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(573, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 65);
            this.label5.TabIndex = 25;
            this.label5.Text = "NonCritical Region";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablepc0
            // 
            this.tablepc0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tablepc0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablepc0.ForeColor = System.Drawing.Color.Crimson;
            this.tablepc0.Location = new System.Drawing.Point(495, 50);
            this.tablepc0.Name = "tablepc0";
            this.tablepc0.Size = new System.Drawing.Size(161, 98);
            this.tablepc0.TabIndex = 26;
            this.tablepc0.Text = "PROCESS 0 (car pink)";
            this.tablepc0.UseVisualStyleBackColor = false;
            // 
            // tablepc1
            // 
            this.tablepc1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tablepc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablepc1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tablepc1.Location = new System.Drawing.Point(495, 50);
            this.tablepc1.Name = "tablepc1";
            this.tablepc1.Size = new System.Drawing.Size(161, 98);
            this.tablepc1.TabIndex = 27;
            this.tablepc1.Text = "PROCESS 1 (car blue)";
            this.tablepc1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.nopeterson);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 82);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DON\'T USE PETERSON";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.PCPink);
            this.groupBox2.Controls.Add(this.cahai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 191);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USE PETERSON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablepc1);
            this.Controls.Add(this.tablepc0);
            this.Controls.Add(this.carblue);
            this.Controls.Add(this.Do1);
            this.Controls.Add(this.Xanh1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Bum);
            this.Controls.Add(this.carpink);
            this.Controls.Add(this.Xanh);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.carblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Do1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xanh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Do)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Do;
        private System.Windows.Forms.PictureBox Xanh;
        private System.Windows.Forms.PictureBox carpink;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button nopeterson;
        private System.Windows.Forms.Button PCPink;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Xanh1;
        private System.Windows.Forms.PictureBox Do1;
        private System.Windows.Forms.Button cahai;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.PictureBox Bum;
        private System.Windows.Forms.PictureBox carblue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tablepc0;
        private System.Windows.Forms.Button tablepc1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

