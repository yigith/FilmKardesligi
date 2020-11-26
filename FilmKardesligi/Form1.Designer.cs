namespace FilmKardesligi
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
            if (disposing)
            {
                db.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTurler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.clbTur = new System.Windows.Forms.CheckedListBox();
            this.cboTurFiltre = new System.Windows.Forms.ComboBox();
            this.cboPuanFiltre = new System.Windows.Forms.ComboBox();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lblFotoDegistir = new System.Windows.Forms.Label();
            this.lblFotoKaldir = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTurler
            // 
            this.tsmiTurler.Name = "tsmiTurler";
            this.tsmiTurler.Size = new System.Drawing.Size(79, 19);
            this.tsmiTurler.Text = "Film Türleri";
            this.tsmiTurler.Click += new System.EventHandler(this.tsmiTurler_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.Location = new System.Drawing.Point(12, 498);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(150, 34);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(814, 498);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(179, 34);
            this.btnDuzenle.TabIndex = 11;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(628, 498);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(179, 34);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFilmler.DisplayMember = "Kunye";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 24;
            this.lstFilmler.Location = new System.Drawing.Point(337, 79);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(656, 412);
            this.lstFilmler.TabIndex = 9;
            this.lstFilmler.SelectedIndexChanged += new System.EventHandler(this.lstFilmler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Location = new System.Drawing.Point(171, 498);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(160, 34);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(12, 79);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(319, 29);
            this.txtFilmAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü";
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.Location = new System.Drawing.Point(6, 28);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(83, 21);
            this.rbPuan1.TabIndex = 17;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.Location = new System.Drawing.Point(6, 56);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(55, 21);
            this.rbPuan2.TabIndex = 18;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Checked = true;
            this.rbPuan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.Location = new System.Drawing.Point(6, 82);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(54, 21);
            this.rbPuan3.TabIndex = 19;
            this.rbPuan3.TabStop = true;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.Location = new System.Drawing.Point(6, 136);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(67, 21);
            this.rbPuan5.TabIndex = 21;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.Location = new System.Drawing.Point(6, 110);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(39, 21);
            this.rbPuan4.TabIndex = 20;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filmler";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Location = new System.Drawing.Point(12, 284);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(150, 170);
            this.gboPuan.TabIndex = 5;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // clbTur
            // 
            this.clbTur.CheckOnClick = true;
            this.clbTur.FormattingEnabled = true;
            this.clbTur.Location = new System.Drawing.Point(12, 146);
            this.clbTur.Name = "clbTur";
            this.clbTur.Size = new System.Drawing.Size(319, 124);
            this.clbTur.TabIndex = 12;
            // 
            // cboTurFiltre
            // 
            this.cboTurFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTurFiltre.DisplayMember = "TurAd";
            this.cboTurFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurFiltre.FormattingEnabled = true;
            this.cboTurFiltre.Location = new System.Drawing.Point(849, 44);
            this.cboTurFiltre.Name = "cboTurFiltre";
            this.cboTurFiltre.Size = new System.Drawing.Size(144, 32);
            this.cboTurFiltre.TabIndex = 13;
            this.cboTurFiltre.ValueMember = "Id";
            this.cboTurFiltre.SelectedIndexChanged += new System.EventHandler(this.cboTurFiltre_SelectedIndexChanged);
            // 
            // cboPuanFiltre
            // 
            this.cboPuanFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPuanFiltre.DisplayMember = "TurAd";
            this.cboPuanFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuanFiltre.FormattingEnabled = true;
            this.cboPuanFiltre.Location = new System.Drawing.Point(699, 44);
            this.cboPuanFiltre.Name = "cboPuanFiltre";
            this.cboPuanFiltre.Size = new System.Drawing.Size(144, 32);
            this.cboPuanFiltre.TabIndex = 14;
            this.cboPuanFiltre.ValueMember = "Id";
            this.cboPuanFiltre.SelectedIndexChanged += new System.EventHandler(this.cboPuanFiltre_SelectedIndexChanged);
            // 
            // pboFoto
            // 
            this.pboFoto.Image = global::FilmKardesligi.Properties.Resources.noimage;
            this.pboFoto.Location = new System.Drawing.Point(171, 294);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(160, 160);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboFoto.TabIndex = 15;
            this.pboFoto.TabStop = false;
            // 
            // lblFotoDegistir
            // 
            this.lblFotoDegistir.AutoSize = true;
            this.lblFotoDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFotoDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFotoDegistir.Location = new System.Drawing.Point(250, 457);
            this.lblFotoDegistir.Name = "lblFotoDegistir";
            this.lblFotoDegistir.Size = new System.Drawing.Size(42, 13);
            this.lblFotoDegistir.TabIndex = 16;
            this.lblFotoDegistir.Text = "Değiştir";
            this.lblFotoDegistir.Click += new System.EventHandler(this.lblFotoDegistir_Click);
            // 
            // lblFotoKaldir
            // 
            this.lblFotoKaldir.AutoSize = true;
            this.lblFotoKaldir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFotoKaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFotoKaldir.Location = new System.Drawing.Point(298, 457);
            this.lblFotoKaldir.Name = "lblFotoKaldir";
            this.lblFotoKaldir.Size = new System.Drawing.Size(33, 13);
            this.lblFotoKaldir.TabIndex = 17;
            this.lblFotoKaldir.Text = "Kaldır";
            this.lblFotoKaldir.Click += new System.EventHandler(this.lblFotoKaldir_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            this.ofdFoto.Filter = "Resim dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.j" +
    "fif; *.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 544);
            this.Controls.Add(this.lblFotoKaldir);
            this.Controls.Add(this.lblFotoDegistir);
            this.Controls.Add(this.pboFoto);
            this.Controls.Add(this.cboPuanFiltre);
            this.Controls.Add(this.cboTurFiltre);
            this.Controls.Add(this.clbTur);
            this.Controls.Add(this.gboPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Kardeşliği";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurler;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.CheckedListBox clbTur;
        private System.Windows.Forms.ComboBox cboTurFiltre;
        private System.Windows.Forms.ComboBox cboPuanFiltre;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.Label lblFotoDegistir;
        private System.Windows.Forms.Label lblFotoKaldir;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}

