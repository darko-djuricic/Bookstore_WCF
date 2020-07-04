namespace KorisnikApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnPoruci = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPorudzbine = new System.Windows.Forms.ListBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numKolicina);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbKnjige);
            this.tabPage1.Controls.Add(this.lblOperator);
            this.tabPage1.Controls.Add(this.btnPoruci);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Knjige";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(515, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kolicina";
            // 
            // numKolicina
            // 
            this.numKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numKolicina.Location = new System.Drawing.Point(509, 410);
            this.numKolicina.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(99, 29);
            this.numKolicina.TabIndex = 21;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Knjige";
            // 
            // lbKnjige
            // 
            this.lbKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.ItemHeight = 20;
            this.lbKnjige.Location = new System.Drawing.Point(34, 104);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.ScrollAlwaysVisible = true;
            this.lbKnjige.Size = new System.Drawing.Size(730, 264);
            this.lbKnjige.Sorted = true;
            this.lbKnjige.TabIndex = 19;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperator.Location = new System.Drawing.Point(164, 1);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(264, 55);
            this.lblOperator.TabIndex = 18;
            this.lblOperator.Text = "Dobrodosli";
            // 
            // btnPoruci
            // 
            this.btnPoruci.BackColor = System.Drawing.Color.Sienna;
            this.btnPoruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoruci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoruci.Location = new System.Drawing.Point(640, 397);
            this.btnPoruci.Name = "btnPoruci";
            this.btnPoruci.Size = new System.Drawing.Size(124, 47);
            this.btnPoruci.TabIndex = 17;
            this.btnPoruci.Text = "Poruci";
            this.btnPoruci.UseVisualStyleBackColor = false;
            this.btnPoruci.Click += new System.EventHandler(this.btnPoruci_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbPorudzbine);
            this.tabPage2.Controls.Add(this.btnOtkazi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Porudzbine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Porudzbine";
            // 
            // lbPorudzbine
            // 
            this.lbPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPorudzbine.FormattingEnabled = true;
            this.lbPorudzbine.ItemHeight = 20;
            this.lbPorudzbine.Location = new System.Drawing.Point(34, 78);
            this.lbPorudzbine.Name = "lbPorudzbine";
            this.lbPorudzbine.ScrollAlwaysVisible = true;
            this.lbPorudzbine.Size = new System.Drawing.Size(730, 264);
            this.lbPorudzbine.Sorted = true;
            this.lbPorudzbine.TabIndex = 22;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Sienna;
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtkazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtkazi.Location = new System.Drawing.Point(640, 348);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(124, 47);
            this.btnOtkazi.TabIndex = 21;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnPoruci;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPorudzbine;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKolicina;
    }
}