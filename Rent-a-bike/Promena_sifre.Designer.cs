
namespace Rent_a_bike
{
    partial class Promena_sifre
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
            this.lbl_promeni = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_novasifra = new System.Windows.Forms.Label();
            this.lbl_novasifra2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_promeni
            // 
            this.lbl_promeni.AutoSize = true;
            this.lbl_promeni.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promeni.Location = new System.Drawing.Point(71, 35);
            this.lbl_promeni.Name = "lbl_promeni";
            this.lbl_promeni.Size = new System.Drawing.Size(264, 51);
            this.lbl_promeni.TabIndex = 0;
            this.lbl_promeni.Text = "PROMENI SIFRU";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(12, 126);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(66, 26);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "EMAIL:";
            // 
            // lbl_novasifra
            // 
            this.lbl_novasifra.AutoSize = true;
            this.lbl_novasifra.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novasifra.Location = new System.Drawing.Point(11, 165);
            this.lbl_novasifra.Name = "lbl_novasifra";
            this.lbl_novasifra.Size = new System.Drawing.Size(116, 26);
            this.lbl_novasifra.TabIndex = 2;
            this.lbl_novasifra.Text = "NOVA SIFRA:";
            // 
            // lbl_novasifra2
            // 
            this.lbl_novasifra2.AutoSize = true;
            this.lbl_novasifra2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_novasifra2.Location = new System.Drawing.Point(-1, 210);
            this.lbl_novasifra2.Name = "lbl_novasifra2";
            this.lbl_novasifra2.Size = new System.Drawing.Size(205, 26);
            this.lbl_novasifra2.TabIndex = 3;
            this.lbl_novasifra2.Text = "PONOVITE NOVU SIFRU:";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(207, 262);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 37);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(155, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 20);
            this.txt_email.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(155, 170);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(180, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(210, 210);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.Size = new System.Drawing.Size(125, 20);
            this.txt_pass2.TabIndex = 7;
            // 
            // Promena_sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_novasifra2);
            this.Controls.Add(this.lbl_novasifra);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_promeni);
            this.Name = "Promena_sifre";
            this.Text = "Promena_sifre";
            this.Load += new System.EventHandler(this.Promena_sifre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_promeni;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_novasifra;
        private System.Windows.Forms.Label lbl_novasifra2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_pass2;
    }
}