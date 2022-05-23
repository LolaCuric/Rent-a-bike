
namespace Rent_a_bike
{
    partial class Kvar
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
            this.lbl_prijava = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_tip = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.btn_salji = new System.Windows.Forms.Button();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_prijava
            // 
            this.lbl_prijava.AutoSize = true;
            this.lbl_prijava.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prijava.Location = new System.Drawing.Point(12, 28);
            this.lbl_prijava.Name = "lbl_prijava";
            this.lbl_prijava.Size = new System.Drawing.Size(191, 33);
            this.lbl_prijava.TabIndex = 0;
            this.lbl_prijava.Text = "PRIJAVITE KVAR:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lbl_tip
            // 
            this.lbl_tip.AutoSize = true;
            this.lbl_tip.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip.Location = new System.Drawing.Point(1, 96);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(202, 28);
            this.lbl_tip.TabIndex = 2;
            this.lbl_tip.Text = "Izaberite tip proizvoda: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 190);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // lbl_opis
            // 
            this.lbl_opis.AutoSize = true;
            this.lbl_opis.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opis.Location = new System.Drawing.Point(12, 186);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(131, 33);
            this.lbl_opis.TabIndex = 5;
            this.lbl_opis.Text = "Opisite kvar";
            // 
            // btn_salji
            // 
            this.btn_salji.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salji.Location = new System.Drawing.Point(346, 263);
            this.btn_salji.Name = "btn_salji";
            this.btn_salji.Size = new System.Drawing.Size(90, 55);
            this.btn_salji.TabIndex = 6;
            this.btn_salji.Text = "Posalji";
            this.btn_salji.UseVisualStyleBackColor = true;
            this.btn_salji.Click += new System.EventHandler(this.btn_salji_Click);
            // 
            // lbl_pr
            // 
            this.lbl_pr.AutoSize = true;
            this.lbl_pr.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pr.Location = new System.Drawing.Point(228, 96);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(145, 28);
            this.lbl_pr.TabIndex = 7;
            this.lbl_pr.Text = "Naziv proizvoda:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // Kvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbl_pr);
            this.Controls.Add(this.btn_salji);
            this.Controls.Add(this.lbl_opis);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_tip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_prijava);
            this.Name = "Kvar";
            this.Text = "Kvar";
            this.Load += new System.EventHandler(this.Kvar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prijava;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_tip;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.Button btn_salji;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}