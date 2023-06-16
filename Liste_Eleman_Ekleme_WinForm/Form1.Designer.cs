namespace Liste_Eleman_Ekleme_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAd = new TextBox();
            btnEkle = new Button();
            btnSecme = new Button();
            lsbAd = new ListBox();
            cmbAd = new ComboBox();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(50, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(177, 23);
            txtAd.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(250, 37);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSecme
            // 
            btnSecme.Location = new Point(50, 330);
            btnSecme.Name = "btnSecme";
            btnSecme.Size = new Size(275, 23);
            btnSecme.TabIndex = 2;
            btnSecme.Text = "HIC BIRSEY SECME";
            btnSecme.UseVisualStyleBackColor = true;
            btnSecme.Click += btnSecme_Click;
            // 
            // lsbAd
            // 
            lsbAd.FormattingEnabled = true;
            lsbAd.ItemHeight = 15;
            lsbAd.Location = new Point(50, 136);
            lsbAd.Name = "lsbAd";
            lsbAd.Size = new Size(275, 169);
            lsbAd.TabIndex = 3;
            lsbAd.SelectedIndexChanged += lsbAd_SelectedIndexChanged;
            // 
            // cmbAd
            // 
            cmbAd.FormattingEnabled = true;
            cmbAd.Location = new Point(52, 90);
            cmbAd.Name = "cmbAd";
            cmbAd.Size = new Size(273, 23);
            cmbAd.TabIndex = 4;
            cmbAd.SelectedIndexChanged += cmbAd_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 403);
            Controls.Add(cmbAd);
            Controls.Add(lsbAd);
            Controls.Add(btnSecme);
            Controls.Add(btnEkle);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "LISTE EKLEME";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Button btnEkle;
        private Button btnSecme;
        private ListBox lsbAd;
        private ComboBox cmbAd;
    }
}