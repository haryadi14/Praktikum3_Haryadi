namespace P3_4_1204026
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtTgl = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Biola = new System.Windows.Forms.CheckBox();
            this.Gitar = new System.Windows.Forms.CheckBox();
            this.Saxophone = new System.Windows.Forms.CheckBox();
            this.Piano = new System.Windows.Forms.CheckBox();
            this.Drum = new System.Windows.Forms.CheckBox();
            this.Vokal = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Komposer = new System.Windows.Forms.CheckBox();
            this.Konduktor = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA                                                  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(460, 131);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 26);
            this.txtNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "JENIS KELAMIN                                     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TANGGAL LAHIR";
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbJK.Location = new System.Drawing.Point(460, 170);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(121, 28);
            this.cbJK.TabIndex = 4;
            this.cbJK.Text = "jenis kelamin";
            // 
            // dtTgl
            // 
            this.dtTgl.Location = new System.Drawing.Point(460, 222);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.Size = new System.Drawing.Size(200, 26);
            this.dtTgl.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Konduktor);
            this.groupBox1.Controls.Add(this.Komposer);
            this.groupBox1.Controls.Add(this.Biola);
            this.groupBox1.Controls.Add(this.Gitar);
            this.groupBox1.Controls.Add(this.Saxophone);
            this.groupBox1.Controls.Add(this.Piano);
            this.groupBox1.Controls.Add(this.Drum);
            this.groupBox1.Controls.Add(this.Vokal);
            this.groupBox1.Location = new System.Drawing.Point(55, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PILIHAN KELAS";
            // 
            // Biola
            // 
            this.Biola.AutoSize = true;
            this.Biola.Location = new System.Drawing.Point(8, 44);
            this.Biola.Name = "Biola";
            this.Biola.Size = new System.Drawing.Size(83, 24);
            this.Biola.TabIndex = 7;
            this.Biola.Text = "BIOLA";
            this.Biola.UseVisualStyleBackColor = true;
            // 
            // Gitar
            // 
            this.Gitar.AutoSize = true;
            this.Gitar.Location = new System.Drawing.Point(8, 79);
            this.Gitar.Name = "Gitar";
            this.Gitar.Size = new System.Drawing.Size(85, 24);
            this.Gitar.TabIndex = 8;
            this.Gitar.Text = "GITAR";
            this.Gitar.UseVisualStyleBackColor = true;
            // 
            // Saxophone
            // 
            this.Saxophone.AutoSize = true;
            this.Saxophone.Location = new System.Drawing.Point(9, 120);
            this.Saxophone.Name = "Saxophone";
            this.Saxophone.Size = new System.Drawing.Size(136, 24);
            this.Saxophone.TabIndex = 9;
            this.Saxophone.Text = "SAXOPHONE";
            this.Saxophone.UseVisualStyleBackColor = true;
            // 
            // Piano
            // 
            this.Piano.AutoSize = true;
            this.Piano.Location = new System.Drawing.Point(151, 43);
            this.Piano.Name = "Piano";
            this.Piano.Size = new System.Drawing.Size(84, 24);
            this.Piano.TabIndex = 10;
            this.Piano.Text = "PIANO";
            this.Piano.UseVisualStyleBackColor = true;
            // 
            // Drum
            // 
            this.Drum.AutoSize = true;
            this.Drum.Location = new System.Drawing.Point(151, 79);
            this.Drum.Name = "Drum";
            this.Drum.Size = new System.Drawing.Size(84, 24);
            this.Drum.TabIndex = 11;
            this.Drum.Text = "DRUM";
            this.Drum.UseVisualStyleBackColor = true;
            // 
            // Vokal
            // 
            this.Vokal.AutoSize = true;
            this.Vokal.Location = new System.Drawing.Point(151, 120);
            this.Vokal.Name = "Vokal";
            this.Vokal.Size = new System.Drawing.Size(88, 24);
            this.Vokal.TabIndex = 12;
            this.Vokal.Text = "VOKAL";
            this.Vokal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Location = new System.Drawing.Point(551, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 223);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PILIHAN JADWAL";
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(22, 43);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(253, 24);
            this.rbJadwal1.TabIndex = 7;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "SENIN && RABU , 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(22, 90);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(272, 24);
            this.rbJadwal2.TabIndex = 8;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "SELASA && KAMIS , 14.00 - 16.00\r\n";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(22, 133);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(279, 24);
            this.rbJadwal3.TabIndex = 9;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "SABTU && MINGGU , 09.00 - 11.00\r\n";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(22, 181);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(206, 24);
            this.rbJadwal4.TabIndex = 10;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "MINGGU , 13.00 - 17.00\r\n";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "TAMPILKAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "SELESAI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Komposer
            // 
            this.Komposer.AutoSize = true;
            this.Komposer.Location = new System.Drawing.Point(151, 159);
            this.Komposer.Name = "Komposer";
            this.Komposer.Size = new System.Drawing.Size(126, 24);
            this.Komposer.TabIndex = 13;
            this.Komposer.Text = "KOMPOSER";
            this.Komposer.UseVisualStyleBackColor = true;
            // 
            // Konduktor
            // 
            this.Konduktor.AutoSize = true;
            this.Konduktor.Location = new System.Drawing.Point(9, 159);
            this.Konduktor.Name = "Konduktor";
            this.Konduktor.Size = new System.Drawing.Size(135, 24);
            this.Konduktor.TabIndex = 14;
            this.Konduktor.Text = "KONDUKTOR";
            this.Konduktor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(974, 655);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(500, 300);
            this.Name = "Form1";
            this.Text = "Adi Music School";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTgl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Biola;
        private System.Windows.Forms.CheckBox Gitar;
        private System.Windows.Forms.CheckBox Saxophone;
        private System.Windows.Forms.CheckBox Piano;
        private System.Windows.Forms.CheckBox Drum;
        private System.Windows.Forms.CheckBox Vokal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Konduktor;
        private System.Windows.Forms.CheckBox Komposer;
    }
}

