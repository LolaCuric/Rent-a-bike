
namespace Rent_a_bike
{
    partial class Ulogovanje
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_mejl = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.linklbl_nalog = new System.Windows.Forms.LinkLabel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.linklbl_sifra = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(125, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(263, 57);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "ULOGUJTE SE";
            // 
            // lbl_mejl
            // 
            this.lbl_mejl.AutoSize = true;
            this.lbl_mejl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mejl.Location = new System.Drawing.Point(49, 115);
            this.lbl_mejl.Name = "lbl_mejl";
            this.lbl_mejl.Size = new System.Drawing.Size(70, 33);
            this.lbl_mejl.TabIndex = 1;
            this.lbl_mejl.Text = "Email";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(13, 161);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(106, 33);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(205, 233);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 43);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // linklbl_nalog
            // 
            this.linklbl_nalog.AutoSize = true;
            this.linklbl_nalog.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_nalog.Location = new System.Drawing.Point(186, 305);
            this.linklbl_nalog.Name = "linklbl_nalog";
            this.linklbl_nalog.Size = new System.Drawing.Size(109, 23);
            this.linklbl_nalog.TabIndex = 4;
            this.linklbl_nalog.TabStop = true;
            this.linklbl_nalog.Text = "Nemate nalog?";
            this.linklbl_nalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_nalog_LinkClicked);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(148, 120);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(180, 26);
            this.txt_email.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(148, 166);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(180, 26);
            this.txt_pass.TabIndex = 6;
            // 
            // linklbl_sifra
            // 
            this.linklbl_sifra.AutoSize = true;
            this.linklbl_sifra.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_sifra.Location = new System.Drawing.Point(170, 341);
            this.linklbl_sifra.Name = "linklbl_sifra";
            this.linklbl_sifra.Size = new System.Drawing.Size(143, 23);
            this.linklbl_sifra.TabIndex = 7;
            this.linklbl_sifra.TabStop = true;
            this.linklbl_sifra.Text = "Zaboravili ste sifru?";
            this.linklbl_sifra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_sifra_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Ulogovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linklbl_sifra);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.linklbl_nalog);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_mejl);
            this.Controls.Add(this.lbl1);
            this.Name = "Ulogovanje";
            this.Text = "Ulogovanje";
            this.Load += new System.EventHandler(this.Ulogovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_mejl;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.LinkLabel linklbl_nalog;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.LinkLabel linklbl_sifra;
        private System.Windows.Forms.TextBox textBox1;
    }
}