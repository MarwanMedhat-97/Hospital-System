namespace DBLAB_EXAM
{
    partial class Remove_Department
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BRemove = new System.Windows.Forms.Button();
            this.CBDEPID = new System.Windows.Forms.ComboBox();
            this.BFind = new System.Windows.Forms.Button();
            this.BShow = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.hospitalDataSet6 = new DBLAB_EXAM.HospitalDataSet6();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new DBLAB_EXAM.HospitalDataSet6TableAdapters.DepartmentTableAdapter();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIDDataGridViewTextBoxColumn,
            this.dLocationDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.dtypeDataGridViewTextBoxColumn,
            this.hDOCIDDataGridViewTextBoxColumn,
            this.hNURSEIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRemove.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BRemove.ForeColor = System.Drawing.Color.Navy;
            this.BRemove.Location = new System.Drawing.Point(276, 123);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(178, 69);
            this.BRemove.TabIndex = 10;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // CBDEPID
            // 
            this.CBDEPID.DataSource = this.departmentBindingSource;
            this.CBDEPID.DisplayMember = "DID";
            this.CBDEPID.FormattingEnabled = true;
            this.CBDEPID.Location = new System.Drawing.Point(79, 97);
            this.CBDEPID.Name = "CBDEPID";
            this.CBDEPID.Size = new System.Drawing.Size(121, 24);
            this.CBDEPID.TabIndex = 12;
            // 
            // BFind
            // 
            this.BFind.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFind.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BFind.ForeColor = System.Drawing.Color.Navy;
            this.BFind.Location = new System.Drawing.Point(276, 28);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(178, 69);
            this.BFind.TabIndex = 13;
            this.BFind.Text = "Find";
            this.BFind.UseVisualStyleBackColor = false;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // BShow
            // 
            this.BShow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BShow.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BShow.ForeColor = System.Drawing.Color.Navy;
            this.BShow.Location = new System.Drawing.Point(522, 73);
            this.BShow.Name = "BShow";
            this.BShow.Size = new System.Drawing.Size(178, 69);
            this.BShow.TabIndex = 14;
            this.BShow.Text = "Show ALL";
            this.BShow.UseVisualStyleBackColor = false;
            this.BShow.Click += new System.EventHandler(this.BShow_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BBack.ForeColor = System.Drawing.SystemColors.Control;
            this.BBack.Location = new System.Drawing.Point(650, 7);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(125, 36);
            this.BBack.TabIndex = 15;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // hospitalDataSet6
            // 
            this.hospitalDataSet6.DataSetName = "HospitalDataSet6";
            this.hospitalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hospitalDataSet6;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.hospitalDataSet6;
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "DID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "DID";
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            // 
            // dLocationDataGridViewTextBoxColumn
            // 
            this.dLocationDataGridViewTextBoxColumn.DataPropertyName = "DLocation";
            this.dLocationDataGridViewTextBoxColumn.HeaderText = "DLocation";
            this.dLocationDataGridViewTextBoxColumn.Name = "dLocationDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // dtypeDataGridViewTextBoxColumn
            // 
            this.dtypeDataGridViewTextBoxColumn.DataPropertyName = "Dtype";
            this.dtypeDataGridViewTextBoxColumn.HeaderText = "Dtype";
            this.dtypeDataGridViewTextBoxColumn.Name = "dtypeDataGridViewTextBoxColumn";
            // 
            // hDOCIDDataGridViewTextBoxColumn
            // 
            this.hDOCIDDataGridViewTextBoxColumn.DataPropertyName = "HDOCID";
            this.hDOCIDDataGridViewTextBoxColumn.HeaderText = "HDOCID";
            this.hDOCIDDataGridViewTextBoxColumn.Name = "hDOCIDDataGridViewTextBoxColumn";
            // 
            // hNURSEIDDataGridViewTextBoxColumn
            // 
            this.hNURSEIDDataGridViewTextBoxColumn.DataPropertyName = "HNURSEID";
            this.hNURSEIDDataGridViewTextBoxColumn.HeaderText = "HNURSEID";
            this.hNURSEIDDataGridViewTextBoxColumn.Name = "hNURSEIDDataGridViewTextBoxColumn";
            // 
            // Remove_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 555);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BShow);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.CBDEPID);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Remove_Department";
            this.Text = "Remove_Department";
            this.Load += new System.EventHandler(this.Remove_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.ComboBox CBDEPID;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button BShow;
        private System.Windows.Forms.Button BBack;
        private HospitalDataSet6 hospitalDataSet6;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HospitalDataSet6TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
    }
}