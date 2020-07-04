namespace Operater
{
    partial class Form2
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
            this.tabKnjige = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPopust = new System.Windows.Forms.NumericUpDown();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.tboxAutor = new System.Windows.Forms.TextBox();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIzmeniKorisnika = new System.Windows.Forms.Button();
            this.btnSnimiKorisnika = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPorudzbine = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabKnjige.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKnjige
            // 
            this.tabKnjige.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKnjige.Controls.Add(this.tabPage1);
            this.tabKnjige.Controls.Add(this.tabPage2);
            this.tabKnjige.Controls.Add(this.tabPage3);
            this.tabKnjige.Location = new System.Drawing.Point(0, 3);
            this.tabKnjige.Name = "tabKnjige";
            this.tabKnjige.SelectedIndex = 0;
            this.tabKnjige.Size = new System.Drawing.Size(807, 577);
            this.tabKnjige.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tboxUkupnaCena);
            this.tabPage1.Controls.Add(this.btnIzmeni);
            this.tabPage1.Controls.Add(this.btnSnimi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numPopust);
            this.tabPage1.Controls.Add(this.numCena);
            this.tabPage1.Controls.Add(this.tboxAutor);
            this.tabPage1.Controls.Add(this.tboxNaziv);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbKnjige);
            this.tabPage1.Controls.Add(this.lblOperator);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(582, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ukupna cena";
            // 
            // tboxUkupnaCena
            // 
            this.tboxUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxUkupnaCena.Location = new System.Drawing.Point(564, 455);
            this.tboxUkupnaCena.Name = "tboxUkupnaCena";
            this.tboxUkupnaCena.ReadOnly = true;
            this.tboxUkupnaCena.Size = new System.Drawing.Size(176, 29);
            this.tboxUkupnaCena.TabIndex = 17;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeni.Location = new System.Drawing.Point(38, 428);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(131, 56);
            this.btnIzmeni.TabIndex = 16;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimi.Location = new System.Drawing.Point(177, 428);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(131, 56);
            this.btnSnimi.TabIndex = 15;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(666, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Popust";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(560, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(305, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv";
            // 
            // numPopust
            // 
            this.numPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numPopust.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPopust.Location = new System.Drawing.Point(670, 372);
            this.numPopust.Name = "numPopust";
            this.numPopust.Size = new System.Drawing.Size(70, 29);
            this.numPopust.TabIndex = 10;
            // 
            // numCena
            // 
            this.numCena.DecimalPlaces = 2;
            this.numCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCena.Location = new System.Drawing.Point(564, 372);
            this.numCena.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numCena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(100, 29);
            this.numCena.TabIndex = 9;
            this.numCena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tboxAutor
            // 
            this.tboxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxAutor.Location = new System.Drawing.Point(309, 371);
            this.tboxAutor.Name = "tboxAutor";
            this.tboxAutor.Size = new System.Drawing.Size(249, 29);
            this.tboxAutor.TabIndex = 8;
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxNaziv.Location = new System.Drawing.Point(37, 372);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(266, 29);
            this.tboxNaziv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Knjige";
            // 
            // lbKnjige
            // 
            this.lbKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.ItemHeight = 20;
            this.lbKnjige.Location = new System.Drawing.Point(37, 119);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.ScrollAlwaysVisible = true;
            this.lbKnjige.Size = new System.Drawing.Size(703, 184);
            this.lbKnjige.Sorted = true;
            this.lbKnjige.TabIndex = 5;
            this.lbKnjige.Click += new System.EventHandler(this.lbKnjige_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperator.Location = new System.Drawing.Point(167, 16);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(264, 55);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "Dobrodosli";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.cmbStatus);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.tbUsername);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnIzmeniKorisnika);
            this.tabPage2.Controls.Add(this.btnSnimiKorisnika);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lbKorisnici);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Korisnici";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(589, 369);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 33);
            this.cmbStatus.TabIndex = 24;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(316, 371);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(255, 31);
            this.tbPassword.TabIndex = 23;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUsername.Location = new System.Drawing.Point(46, 371);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(243, 31);
            this.tbUsername.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(585, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(312, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Lozinka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(42, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Korisnicko ime";
            // 
            // btnIzmeniKorisnika
            // 
            this.btnIzmeniKorisnika.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnIzmeniKorisnika.Enabled = false;
            this.btnIzmeniKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniKorisnika.Location = new System.Drawing.Point(481, 427);
            this.btnIzmeniKorisnika.Name = "btnIzmeniKorisnika";
            this.btnIzmeniKorisnika.Size = new System.Drawing.Size(131, 56);
            this.btnIzmeniKorisnika.TabIndex = 18;
            this.btnIzmeniKorisnika.Text = "Izmeni";
            this.btnIzmeniKorisnika.UseVisualStyleBackColor = false;
            this.btnIzmeniKorisnika.Click += new System.EventHandler(this.btnIzmeniKorisnika_Click);
            // 
            // btnSnimiKorisnika
            // 
            this.btnSnimiKorisnika.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSnimiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimiKorisnika.Location = new System.Drawing.Point(618, 427);
            this.btnSnimiKorisnika.Name = "btnSnimiKorisnika";
            this.btnSnimiKorisnika.Size = new System.Drawing.Size(131, 56);
            this.btnSnimiKorisnika.TabIndex = 17;
            this.btnSnimiKorisnika.Text = "Snimi";
            this.btnSnimiKorisnika.UseVisualStyleBackColor = false;
            this.btnSnimiKorisnika.Click += new System.EventHandler(this.btnSnimiKorisnika_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(41, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Knjige";
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.ItemHeight = 20;
            this.lbKorisnici.Location = new System.Drawing.Point(46, 75);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.ScrollAlwaysVisible = true;
            this.lbKorisnici.Size = new System.Drawing.Size(703, 184);
            this.lbKorisnici.Sorted = true;
            this.lbKorisnici.TabIndex = 6;
            this.lbKorisnici.Click += new System.EventHandler(this.lbKorisnici_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.lbPorudzbine);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Porudzbine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(45, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Knjige";
            // 
            // lbPorudzbine
            // 
            this.lbPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPorudzbine.FormattingEnabled = true;
            this.lbPorudzbine.ItemHeight = 20;
            this.lbPorudzbine.Location = new System.Drawing.Point(50, 83);
            this.lbPorudzbine.Name = "lbPorudzbine";
            this.lbPorudzbine.ScrollAlwaysVisible = true;
            this.lbPorudzbine.Size = new System.Drawing.Size(703, 384);
            this.lbPorudzbine.Sorted = true;
            this.lbPorudzbine.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(808, 571);
            this.Controls.Add(this.tabKnjige);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabKnjige.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKnjige;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPopust;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.TextBox tboxAutor;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxUkupnaCena;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.Button btnIzmeniKorisnika;
        private System.Windows.Forms.Button btnSnimiKorisnika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbPorudzbine;
    }
}