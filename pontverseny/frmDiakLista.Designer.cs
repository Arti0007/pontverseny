
namespace pontverseny
{
    partial class frmDiakLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiakLista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nev = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iskola = new System.Windows.Forms.TextBox();
            this.tabla2 = new System.Windows.Forms.DataGridView();
            this.tabla2_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table2_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table2_evf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table2_iskola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nev);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés név alapján:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(16, 29);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(243, 20);
            this.nev.TabIndex = 0;
            this.nev.TextChanged += new System.EventHandler(this.nev_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iskola);
            this.groupBox2.Location = new System.Drawing.Point(347, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés iskola alapján:";
            // 
            // iskola
            // 
            this.iskola.Location = new System.Drawing.Point(16, 29);
            this.iskola.Name = "iskola";
            this.iskola.Size = new System.Drawing.Size(243, 20);
            this.iskola.TabIndex = 0;
            this.iskola.TextChanged += new System.EventHandler(this.iskola_TextChanged);
            // 
            // tabla2
            // 
            this.tabla2.AllowUserToAddRows = false;
            this.tabla2.AllowUserToDeleteRows = false;
            this.tabla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabla2_id,
            this.table2_nev,
            this.table2_evf,
            this.table2_iskola});
            this.tabla2.Location = new System.Drawing.Point(12, 100);
            this.tabla2.Name = "tabla2";
            this.tabla2.ReadOnly = true;
            this.tabla2.Size = new System.Drawing.Size(610, 249);
            this.tabla2.TabIndex = 2;
            this.tabla2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabla2_RowHeaderMouseClick);
            // 
            // tabla2_id
            // 
            this.tabla2_id.FillWeight = 25F;
            this.tabla2_id.HeaderText = "ID";
            this.tabla2_id.Name = "tabla2_id";
            this.tabla2_id.ReadOnly = true;
            // 
            // table2_nev
            // 
            this.table2_nev.FillWeight = 60F;
            this.table2_nev.HeaderText = "Név";
            this.table2_nev.Name = "table2_nev";
            this.table2_nev.ReadOnly = true;
            // 
            // table2_evf
            // 
            this.table2_evf.FillWeight = 25F;
            this.table2_evf.HeaderText = "Évf";
            this.table2_evf.Name = "table2_evf";
            this.table2_evf.ReadOnly = true;
            // 
            // table2_iskola
            // 
            this.table2_iskola.FillWeight = 150F;
            this.table2_iskola.HeaderText = "Iskola";
            this.table2_iskola.Name = "table2_iskola";
            this.table2_iskola.ReadOnly = true;
            // 
            // frmDiakLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.tabla2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiakLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diákok";
            this.Load += new System.EventHandler(this.frmDiakLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox iskola;
        private System.Windows.Forms.DataGridView tabla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabla2_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table2_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn table2_evf;
        private System.Windows.Forms.DataGridViewTextBoxColumn table2_iskola;
    }
}