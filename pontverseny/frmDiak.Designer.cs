
namespace pontverseny
{
    partial class frmDiak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiak));
            this.label1 = new System.Windows.Forms.Label();
            this.azon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.evfolyam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.iskola = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kereses = new System.Windows.Forms.ToolStripMenuItem();
            this.mentes = new System.Windows.Forms.ToolStripMenuItem();
            this.torles = new System.Windows.Forms.ToolStripMenuItem();
            this.blankfrm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.evfolyam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // azon
            // 
            this.azon.Location = new System.Drawing.Point(91, 29);
            this.azon.Name = "azon";
            this.azon.ReadOnly = true;
            this.azon.Size = new System.Drawing.Size(100, 20);
            this.azon.TabIndex = 1;
            this.azon.TextChanged += new System.EventHandler(this.azon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(91, 78);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(200, 20);
            this.nev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Évfolyam:";
            // 
            // evfolyam
            // 
            this.evfolyam.Location = new System.Drawing.Point(91, 124);
            this.evfolyam.Name = "evfolyam";
            this.evfolyam.Size = new System.Drawing.Size(40, 20);
            this.evfolyam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iskola:";
            // 
            // iskola
            // 
            this.iskola.FormattingEnabled = true;
            this.iskola.Location = new System.Drawing.Point(91, 168);
            this.iskola.Name = "iskola";
            this.iskola.Size = new System.Drawing.Size(250, 21);
            this.iskola.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kereses,
            this.mentes,
            this.torles,
            this.blankfrm});
            this.menuStrip1.Location = new System.Drawing.Point(68, 243);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(365, 59);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kereses
            // 
            this.kereses.Image = global::pontverseny.Properties.Resources.keres;
            this.kereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(58, 55);
            this.kereses.Text = "Keresés";
            this.kereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kereses.Click += new System.EventHandler(this.kereses_Click);
            // 
            // mentes
            // 
            this.mentes.Image = global::pontverseny.Properties.Resources.save;
            this.mentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(58, 55);
            this.mentes.Text = "Mentés";
            this.mentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // torles
            // 
            this.torles.Enabled = false;
            this.torles.Image = global::pontverseny.Properties.Resources.delete;
            this.torles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(49, 55);
            this.torles.Text = "Törlés";
            this.torles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // blankfrm
            // 
            this.blankfrm.Image = global::pontverseny.Properties.Resources.ures_urlap;
            this.blankfrm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.blankfrm.Name = "blankfrm";
            this.blankfrm.Size = new System.Drawing.Size(72, 55);
            this.blankfrm.Text = "Üres űrlap";
            this.blankfrm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.blankfrm.Click += new System.EventHandler(this.blankfrm_Click);
            // 
            // frmDiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.iskola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evfolyam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.azon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDiak";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diák";
            this.Load += new System.EventHandler(this.frmDiak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evfolyam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox azon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown evfolyam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox iskola;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kereses;
        private System.Windows.Forms.ToolStripMenuItem mentes;
        private System.Windows.Forms.ToolStripMenuItem torles;
        private System.Windows.Forms.ToolStripMenuItem blankfrm;
    }
}