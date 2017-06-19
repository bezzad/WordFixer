namespace WordFixer
{
    partial class MainForm
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
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.dgvPatterns = new System.Windows.Forms.DataGridView();
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.colPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatterns)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(96, 6);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(373, 25);
            this.txtPattern.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(69, 257);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(390, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(465, 256);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(46, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = ". . .";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regex Pattern:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Path:";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Location = new System.Drawing.Point(12, 286);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceAll.Location = new System.Drawing.Point(96, 286);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "&Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // dgvPatterns
            // 
            this.dgvPatterns.AllowUserToAddRows = false;
            this.dgvPatterns.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPatterns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatterns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPatterns.ColumnHeadersHeight = 40;
            this.dgvPatterns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPattern,
            this.colActive});
            this.dgvPatterns.Location = new System.Drawing.Point(15, 37);
            this.dgvPatterns.Name = "dgvPatterns";
            this.dgvPatterns.RowHeadersWidth = 30;
            this.dgvPatterns.Size = new System.Drawing.Size(496, 199);
            this.dgvPatterns.TabIndex = 7;
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPattern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPattern.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPattern.Location = new System.Drawing.Point(475, 5);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(36, 23);
            this.btnAddPattern.TabIndex = 8;
            this.btnAddPattern.Text = "+";
            this.btnAddPattern.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPattern.UseVisualStyleBackColor = false;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // colPattern
            // 
            this.colPattern.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPattern.HeaderText = "Pattern";
            this.colPattern.Name = "colPattern";
            // 
            // colActive
            // 
            this.colActive.HeaderText = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Width = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 321);
            this.Controls.Add(this.btnAddPattern);
            this.Controls.Add(this.dgvPatterns);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtPattern);
            this.Name = "MainForm";
            this.Text = "Word Fixer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatterns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.DataGridView dgvPatterns;
        private System.Windows.Forms.Button btnAddPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPattern;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
    }
}

