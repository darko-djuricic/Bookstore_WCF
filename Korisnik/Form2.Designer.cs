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
            this.label1 = new System.Windows.Forms.Label();
            this.lbKnjige = new System.Windows.Forms.ListBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnPoruci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Knjige";
            // 
            // lbKnjige
            // 
            this.lbKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKnjige.FormattingEnabled = true;
            this.lbKnjige.ItemHeight = 20;
            this.lbKnjige.Location = new System.Drawing.Point(29, 112);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.ScrollAlwaysVisible = true;
            this.lbKnjige.Size = new System.Drawing.Size(727, 264);
            this.lbKnjige.Sorted = true;
            this.lbKnjige.TabIndex = 8;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperator.Location = new System.Drawing.Point(159, 9);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(264, 55);
            this.lblOperator.TabIndex = 7;
            this.lblOperator.Text = "Dobrodosli";
            // 
            // btnPoruci
            // 
            this.btnPoruci.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPoruci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoruci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoruci.Location = new System.Drawing.Point(617, 398);
            this.btnPoruci.Name = "btnPoruci";
            this.btnPoruci.Size = new System.Drawing.Size(139, 50);
            this.btnPoruci.TabIndex = 13;
            this.btnPoruci.Text = "Poruci";
            this.btnPoruci.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnPoruci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lblOperator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKnjige;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnPoruci;
    }
}