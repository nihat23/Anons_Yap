namespace Anons_Yap
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
            this.label1timer1saat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label3 = new System.Windows.Forms.Label();
            this.button1DosyaSec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2kur = new System.Windows.Forms.Button();
            this.button3dur = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5aciklama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6timer2saat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1timer1saat
            // 
            this.label1timer1saat.AutoSize = true;
            this.label1timer1saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1timer1saat.Location = new System.Drawing.Point(307, 54);
            this.label1timer1saat.Name = "label1timer1saat";
            this.label1timer1saat.Size = new System.Drawing.Size(177, 36);
            this.label1timer1saat.TabIndex = 0;
            this.label1timer1saat.Text = "_________";
            this.label1timer1saat.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat gir :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(179, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "00:00:00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(25, 333);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(401, 46);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(112, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 4;
            // 
            // button1DosyaSec
            // 
            this.button1DosyaSec.BackColor = System.Drawing.Color.IndianRed;
            this.button1DosyaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1DosyaSec.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1DosyaSec.Location = new System.Drawing.Point(152, 115);
            this.button1DosyaSec.Name = "button1DosyaSec";
            this.button1DosyaSec.Size = new System.Drawing.Size(169, 35);
            this.button1DosyaSec.TabIndex = 5;
            this.button1DosyaSec.Text = "Dosya Seç";
            this.button1DosyaSec.UseVisualStyleBackColor = false;
            this.button1DosyaSec.Click += new System.EventHandler(this.button1DosyaSec_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2kur
            // 
            this.button2kur.BackColor = System.Drawing.Color.IndianRed;
            this.button2kur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2kur.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2kur.Location = new System.Drawing.Point(95, 218);
            this.button2kur.Name = "button2kur";
            this.button2kur.Size = new System.Drawing.Size(89, 37);
            this.button2kur.TabIndex = 6;
            this.button2kur.Text = "Kur";
            this.button2kur.UseVisualStyleBackColor = false;
            this.button2kur.Click += new System.EventHandler(this.button2kur_Click);
            // 
            // button3dur
            // 
            this.button3dur.BackColor = System.Drawing.Color.IndianRed;
            this.button3dur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3dur.Font = new System.Drawing.Font("Ravie", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3dur.Location = new System.Drawing.Point(279, 218);
            this.button3dur.Name = "button3dur";
            this.button3dur.Size = new System.Drawing.Size(89, 37);
            this.button3dur.TabIndex = 7;
            this.button3dur.Text = "Durdur";
            this.button3dur.UseVisualStyleBackColor = false;
            this.button3dur.Click += new System.EventHandler(this.button3dur_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(432, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NihatBeyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Açıklama :";
            // 
            // label5aciklama
            // 
            this.label5aciklama.AutoSize = true;
            this.label5aciklama.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5aciklama.ForeColor = System.Drawing.Color.Red;
            this.label5aciklama.Location = new System.Drawing.Point(152, 277);
            this.label5aciklama.Name = "label5aciklama";
            this.label5aciklama.Size = new System.Drawing.Size(32, 22);
            this.label5aciklama.TabIndex = 10;
            this.label5aciklama.Text = "__";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dosya Adı :";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label6timer2saat
            // 
            this.label6timer2saat.AutoSize = true;
            this.label6timer2saat.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6timer2saat.ForeColor = System.Drawing.Color.Black;
            this.label6timer2saat.Location = new System.Drawing.Point(150, 9);
            this.label6timer2saat.Name = "label6timer2saat";
            this.label6timer2saat.Size = new System.Drawing.Size(107, 40);
            this.label6timer2saat.TabIndex = 12;
            this.label6timer2saat.Text = "_________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(494, 391);
            this.Controls.Add(this.label6timer2saat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label5aciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3dur);
            this.Controls.Add(this.button2kur);
            this.Controls.Add(this.button1DosyaSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1timer1saat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Anons Kur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1timer1saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1DosyaSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2kur;
        private System.Windows.Forms.Button button3dur;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5aciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6timer2saat;
    }
}

