namespace OdevTest
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
            this.btn_basla = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_TekrarOyna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SecilenTas = new System.Windows.Forms.Label();
            this.lbl_Basarılıtoplama = new System.Windows.Forms.Label();
            this.lbl_Basarısıztoplama = new System.Windows.Forms.Label();
            this.lbl_Skor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(410, 12);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(364, 40);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.Text = "Başlat";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 531);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_TekrarOyna
            // 
            this.btn_TekrarOyna.Enabled = false;
            this.btn_TekrarOyna.Location = new System.Drawing.Point(410, 67);
            this.btn_TekrarOyna.Name = "btn_TekrarOyna";
            this.btn_TekrarOyna.Size = new System.Drawing.Size(364, 40);
            this.btn_TekrarOyna.TabIndex = 1;
            this.btn_TekrarOyna.Text = "Tekrar Oyna";
            this.btn_TekrarOyna.UseVisualStyleBackColor = true;
            this.btn_TekrarOyna.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(511, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Taş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(421, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Başarılı Toplama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(404, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Başarısız  Toplama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(560, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skor:";
            // 
            // lbl_SecilenTas
            // 
            this.lbl_SecilenTas.AutoSize = true;
            this.lbl_SecilenTas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SecilenTas.Location = new System.Drawing.Point(640, 154);
            this.lbl_SecilenTas.Name = "lbl_SecilenTas";
            this.lbl_SecilenTas.Size = new System.Drawing.Size(21, 24);
            this.lbl_SecilenTas.TabIndex = 4;
            this.lbl_SecilenTas.Text = "0";
            // 
            // lbl_Basarılıtoplama
            // 
            this.lbl_Basarılıtoplama.AutoSize = true;
            this.lbl_Basarılıtoplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Basarılıtoplama.Location = new System.Drawing.Point(640, 210);
            this.lbl_Basarılıtoplama.Name = "lbl_Basarılıtoplama";
            this.lbl_Basarılıtoplama.Size = new System.Drawing.Size(21, 24);
            this.lbl_Basarılıtoplama.TabIndex = 4;
            this.lbl_Basarılıtoplama.Text = "0";
            // 
            // lbl_Basarısıztoplama
            // 
            this.lbl_Basarısıztoplama.AutoSize = true;
            this.lbl_Basarısıztoplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Basarısıztoplama.Location = new System.Drawing.Point(640, 257);
            this.lbl_Basarısıztoplama.Name = "lbl_Basarısıztoplama";
            this.lbl_Basarısıztoplama.Size = new System.Drawing.Size(21, 24);
            this.lbl_Basarısıztoplama.TabIndex = 4;
            this.lbl_Basarısıztoplama.Text = "0";
            // 
            // lbl_Skor
            // 
            this.lbl_Skor.AutoSize = true;
            this.lbl_Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Skor.Location = new System.Drawing.Point(640, 300);
            this.lbl_Skor.Name = "lbl_Skor";
            this.lbl_Skor.Size = new System.Drawing.Size(21, 24);
            this.lbl_Skor.TabIndex = 4;
            this.lbl_Skor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 550);
            this.Controls.Add(this.lbl_Skor);
            this.Controls.Add(this.lbl_Basarısıztoplama);
            this.Controls.Add(this.lbl_Basarılıtoplama);
            this.Controls.Add(this.lbl_SecilenTas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_TekrarOyna);
            this.Controls.Add(this.btn_basla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_TekrarOyna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SecilenTas;
        private System.Windows.Forms.Label lbl_Basarılıtoplama;
        private System.Windows.Forms.Label lbl_Basarısıztoplama;
        private System.Windows.Forms.Label lbl_Skor;
    }
}

