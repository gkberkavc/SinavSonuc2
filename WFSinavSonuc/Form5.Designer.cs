namespace WFSinavSonuc
{
    partial class Form5
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
            this.txtVizeNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalNot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHarfNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVizeNot
            // 
            this.txtVizeNot.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtVizeNot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVizeNot.Location = new System.Drawing.Point(130, 40);
            this.txtVizeNot.Multiline = true;
            this.txtVizeNot.Name = "txtVizeNot";
            this.txtVizeNot.Size = new System.Drawing.Size(194, 37);
            this.txtVizeNot.TabIndex = 0;
            this.txtVizeNot.Leave += new System.EventHandler(this.txtVizeNot_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vize No";
            // 
            // txtFinalNot
            // 
            this.txtFinalNot.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtFinalNot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinalNot.Location = new System.Drawing.Point(130, 111);
            this.txtFinalNot.Multiline = true;
            this.txtFinalNot.Name = "txtFinalNot";
            this.txtFinalNot.Size = new System.Drawing.Size(194, 37);
            this.txtFinalNot.TabIndex = 1;
            this.txtFinalNot.Leave += new System.EventHandler(this.txtFinalNot_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Final Not";
            // 
            // txtHarfNot
            // 
            this.txtHarfNot.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtHarfNot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHarfNot.Location = new System.Drawing.Point(130, 180);
            this.txtHarfNot.Multiline = true;
            this.txtHarfNot.Name = "txtHarfNot";
            this.txtHarfNot.Size = new System.Drawing.Size(194, 37);
            this.txtHarfNot.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harf Not";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(130, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ortalama";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtOrtalama.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrtalama.Location = new System.Drawing.Point(130, 251);
            this.txtOrtalama.Multiline = true;
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(194, 37);
            this.txtOrtalama.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 413);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHarfNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinalNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVizeNot);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Güncelleme Formu";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtVizeNot;
        private Label label2;
        private TextBox txtFinalNot;
        private Label label3;
        private TextBox txtHarfNot;
        private Label label4;
        private Button button1;
        private Label label1;
        private TextBox txtOrtalama;
    }
}