namespace webBrowser_ve_panel_nesnesı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sıl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_gıt = new System.Windows.Forms.Button();
            this.btn_reflesh = new System.Windows.Forms.Button();
            this.btn_ılerı = new System.Windows.Forms.Button();
            this.btn_gerı = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_gıt);
            this.panel1.Controls.Add(this.btn_reflesh);
            this.panel1.Controls.Add(this.btn_ılerı);
            this.panel1.Controls.Add(this.btn_gerı);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 72);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 66);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sıl);
            this.panel2.Location = new System.Drawing.Point(640, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 69);
            this.panel2.TabIndex = 2;
            // 
            // btn_sıl
            // 
            this.btn_sıl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sıl.ImageIndex = 0;
            this.btn_sıl.ImageList = this.ımageList1;
            this.btn_sıl.Location = new System.Drawing.Point(-6, -3);
            this.btn_sıl.Name = "btn_sıl";
            this.btn_sıl.Size = new System.Drawing.Size(102, 72);
            this.btn_sıl.TabIndex = 0;
            this.btn_sıl.UseVisualStyleBackColor = false;
            this.btn_sıl.Click += new System.EventHandler(this.btn_sıl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Button-Button-Delete.256.png");
            this.ımageList1.Images.SetKeyName(1, "Hopstarter-Button-Button-Refresh.256.png");
            // 
            // btn_gıt
            // 
            this.btn_gıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_gıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gıt.Location = new System.Drawing.Point(738, 0);
            this.btn_gıt.Name = "btn_gıt";
            this.btn_gıt.Size = new System.Drawing.Size(136, 71);
            this.btn_gıt.TabIndex = 1;
            this.btn_gıt.Text = "GİT";
            this.btn_gıt.UseVisualStyleBackColor = false;
            this.btn_gıt.Click += new System.EventHandler(this.btn_gıt_Click);
            // 
            // btn_reflesh
            // 
            this.btn_reflesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_reflesh.ImageIndex = 1;
            this.btn_reflesh.ImageList = this.ımageList1;
            this.btn_reflesh.Location = new System.Drawing.Point(238, 1);
            this.btn_reflesh.Name = "btn_reflesh";
            this.btn_reflesh.Size = new System.Drawing.Size(123, 71);
            this.btn_reflesh.TabIndex = 1;
            this.btn_reflesh.UseVisualStyleBackColor = false;
            this.btn_reflesh.Click += new System.EventHandler(this.btn_reflesh_Click);
            // 
            // btn_ılerı
            // 
            this.btn_ılerı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ılerı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ılerı.Location = new System.Drawing.Point(118, 1);
            this.btn_ılerı.Name = "btn_ılerı";
            this.btn_ılerı.Size = new System.Drawing.Size(123, 71);
            this.btn_ılerı.TabIndex = 1;
            this.btn_ılerı.Text = ">";
            this.btn_ılerı.UseVisualStyleBackColor = false;
            this.btn_ılerı.Click += new System.EventHandler(this.btn_ılerı_Click);
            // 
            // btn_gerı
            // 
            this.btn_gerı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_gerı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gerı.Location = new System.Drawing.Point(0, 0);
            this.btn_gerı.Name = "btn_gerı";
            this.btn_gerı.Size = new System.Drawing.Size(122, 71);
            this.btn_gerı.TabIndex = 1;
            this.btn_gerı.Text = "<";
            this.btn_gerı.UseVisualStyleBackColor = false;
            this.btn_gerı.Click += new System.EventHandler(this.btn_gerı_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(915, 452);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 524);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_reflesh;
        private System.Windows.Forms.Button btn_ılerı;
        private System.Windows.Forms.Button btn_gerı;
        private System.Windows.Forms.Button btn_gıt;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sıl;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

