
namespace indirilenlerKlasörü
{
    partial class uygulamaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uygulamaForm));
            this.dosyalar = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDosyaYol = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dosyalar
            // 
            this.dosyalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1});
            this.dosyalar.HideSelection = false;
            this.dosyalar.Location = new System.Drawing.Point(21, 131);
            this.dosyalar.Name = "dosyalar";
            this.dosyalar.Size = new System.Drawing.Size(303, 378);
            this.dosyalar.TabIndex = 1;
            this.dosyalar.UseCompatibleStateImageBehavior = false;
            // 
            // btnDosyaYol
            // 
            this.btnDosyaYol.Location = new System.Drawing.Point(21, 19);
            this.btnDosyaYol.Name = "btnDosyaYol";
            this.btnDosyaYol.Size = new System.Drawing.Size(106, 66);
            this.btnDosyaYol.TabIndex = 2;
            this.btnDosyaYol.Text = "Dosya yolu seç";
            this.btnDosyaYol.UseVisualStyleBackColor = true;
            this.btnDosyaYol.Click += new System.EventHandler(this.btnDosyaYol_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(193, 47);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 3;
            // 
            // files
            // 
            this.files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.files.HideSelection = false;
            this.files.Location = new System.Drawing.Point(364, 131);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(303, 378);
            this.files.TabIndex = 4;
            this.files.UseCompatibleStateImageBehavior = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(603, 22);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(116, 63);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // uygulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 528);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.files);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnDosyaYol);
            this.Controls.Add(this.dosyalar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uygulamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klasör Düzenleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView dosyalar;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.Button btnDosyaYol;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDuzenle;
    }
}

