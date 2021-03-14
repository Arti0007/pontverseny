
namespace pontverseny
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iskolak = new System.Windows.Forms.ToolStripMenuItem();
            this.diakok = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatok = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenyek = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.hely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evfolyam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iskolak,
            this.diakok,
            this.feladatok,
            this.eredmenyek,
            this.kilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 87);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iskolak
            // 
            this.iskolak.Image = global::pontverseny.Properties.Resources.school;
            this.iskolak.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iskolak.Name = "iskolak";
            this.iskolak.Size = new System.Drawing.Size(76, 83);
            this.iskolak.Text = "Iskolák";
            this.iskolak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // diakok
            // 
            this.diakok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.diakok.Image = global::pontverseny.Properties.Resources.student;
            this.diakok.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diakok.Name = "diakok";
            this.diakok.Size = new System.Drawing.Size(76, 83);
            this.diakok.Text = "Diákok";
            this.diakok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.szerkesztésToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // feladatok
            // 
            this.feladatok.Image = global::pontverseny.Properties.Resources.task;
            this.feladatok.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feladatok.Name = "feladatok";
            this.feladatok.Size = new System.Drawing.Size(76, 83);
            this.feladatok.Text = "Feladatok";
            this.feladatok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // eredmenyek
            // 
            this.eredmenyek.Image = global::pontverseny.Properties.Resources.results;
            this.eredmenyek.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eredmenyek.Name = "eredmenyek";
            this.eredmenyek.Size = new System.Drawing.Size(109, 83);
            this.eredmenyek.Text = "Eredmények";
            this.eredmenyek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kilepes
            // 
            this.kilepes.Image = global::pontverseny.Properties.Resources.exit;
            this.kilepes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(76, 83);
            this.kilepes.Text = "Kilépés";
            this.kilepes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "A 2014/15 évi pontverseny rangsora:";
            // 
            // tabla1
            // 
            this.tabla1.AllowUserToAddRows = false;
            this.tabla1.AllowUserToDeleteRows = false;
            this.tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hely,
            this.nev,
            this.pont,
            this.evfolyam,
            this.iskola});
            this.tabla1.Location = new System.Drawing.Point(16, 126);
            this.tabla1.Name = "tabla1";
            this.tabla1.ReadOnly = true;
            this.tabla1.Size = new System.Drawing.Size(772, 312);
            this.tabla1.TabIndex = 2;
            // 
            // hely
            // 
            dataGridViewCellStyle1.Format = ".";
            dataGridViewCellStyle1.NullValue = null;
            this.hely.DefaultCellStyle = dataGridViewCellStyle1;
            this.hely.FillWeight = 30F;
            this.hely.HeaderText = "Hely";
            this.hely.Name = "hely";
            this.hely.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.FillWeight = 80F;
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // pont
            // 
            this.pont.FillWeight = 40F;
            this.pont.HeaderText = "Pont";
            this.pont.Name = "pont";
            this.pont.ReadOnly = true;
            // 
            // evfolyam
            // 
            this.evfolyam.FillWeight = 40F;
            this.evfolyam.HeaderText = "Évfolyam";
            this.evfolyam.Name = "evfolyam";
            this.evfolyam.ReadOnly = true;
            // 
            // iskola
            // 
            this.iskola.FillWeight = 150F;
            this.iskola.HeaderText = "Iskola";
            this.iskola.Name = "iskola";
            this.iskola.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematika pontverseny";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iskolak;
        private System.Windows.Forms.ToolStripMenuItem diakok;
        private System.Windows.Forms.ToolStripMenuItem feladatok;
        private System.Windows.Forms.ToolStripMenuItem eredmenyek;
        private System.Windows.Forms.ToolStripMenuItem kilepes;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hely;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn pont;
        private System.Windows.Forms.DataGridViewTextBoxColumn evfolyam;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskola;
    }
}

