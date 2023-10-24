namespace Veritabanı_Ödev
{
    partial class SilmeForm
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
            this.SilBtn = new System.Windows.Forms.Button();
            this.SilinecekDersinKoduTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listeyiGosterDgw = new System.Windows.Forms.DataGridView();
            this.listeyiGösterBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeyiGosterDgw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.MistyRose;
            this.SilBtn.Location = new System.Drawing.Point(391, 109);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(155, 44);
            this.SilBtn.TabIndex = 17;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // SilinecekDersinKoduTxt
            // 
            this.SilinecekDersinKoduTxt.BackColor = System.Drawing.Color.SeaShell;
            this.SilinecekDersinKoduTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilinecekDersinKoduTxt.Location = new System.Drawing.Point(391, 41);
            this.SilinecekDersinKoduTxt.Name = "SilinecekDersinKoduTxt";
            this.SilinecekDersinKoduTxt.Size = new System.Drawing.Size(155, 30);
            this.SilinecekDersinKoduTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Silmek istenilen verinin ders kodu\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.listeyiGösterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SilBtn);
            this.panel1.Controls.Add(this.SilinecekDersinKoduTxt);
            this.panel1.Location = new System.Drawing.Point(1, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 401);
            this.panel1.TabIndex = 18;
            // 
            // listeyiGosterDgw
            // 
            this.listeyiGosterDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeyiGosterDgw.Location = new System.Drawing.Point(602, 31);
            this.listeyiGosterDgw.Name = "listeyiGosterDgw";
            this.listeyiGosterDgw.RowHeadersWidth = 51;
            this.listeyiGosterDgw.RowTemplate.Height = 24;
            this.listeyiGosterDgw.Size = new System.Drawing.Size(834, 401);
            this.listeyiGosterDgw.TabIndex = 34;
            // 
            // listeyiGösterBtn
            // 
            this.listeyiGösterBtn.Location = new System.Drawing.Point(34, 288);
            this.listeyiGösterBtn.Name = "listeyiGösterBtn";
            this.listeyiGösterBtn.Size = new System.Drawing.Size(501, 55);
            this.listeyiGösterBtn.TabIndex = 18;
            this.listeyiGösterBtn.Text = "Listeyi Göster";
            this.listeyiGösterBtn.UseVisualStyleBackColor = true;
            this.listeyiGösterBtn.Click += new System.EventHandler(this.listeyiGösterBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.transkriptToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // transkriptToolStripMenuItem
            // 
            this.transkriptToolStripMenuItem.Name = "transkriptToolStripMenuItem";
            this.transkriptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transkriptToolStripMenuItem.Text = "Transkript";
            this.transkriptToolStripMenuItem.Click += new System.EventHandler(this.transkriptToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // SilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 432);
            this.Controls.Add(this.listeyiGosterDgw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SilmeForm";
            this.Text = "SilmeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeyiGosterDgw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.TextBox SilinecekDersinKoduTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listeyiGosterDgw;
        private System.Windows.Forms.Button listeyiGösterBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transkriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}