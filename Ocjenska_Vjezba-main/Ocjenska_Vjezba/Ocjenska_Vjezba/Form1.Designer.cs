namespace Ocjenska_Vjezba
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtBrojKotaca = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(148, 94);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(232, 39);
            this.txtModel.TabIndex = 0;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(148, 219);
            this.txtGodinaProizvodnje.Multiline = true;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(232, 39);
            this.txtGodinaProizvodnje.TabIndex = 1;
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.Location = new System.Drawing.Point(148, 157);
            this.txtBrojKotaca.Multiline = true;
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(232, 39);
            this.txtBrojKotaca.TabIndex = 2;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(401, 79);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(346, 306);
            this.txtIspis.TabIndex = 3;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(40, 289);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(88, 38);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(161, 289);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(96, 38);
            this.btnObradi.TabIndex = 5;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(286, 289);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(94, 38);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj kotača";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtBrojKotaca;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

