namespace DBLAB_EXAM
{
    partial class Department_Update
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
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet6 = new DBLAB_EXAM.HospitalDataSet6();
            this.departmentTableAdapter = new DBLAB_EXAM.HospitalDataSet6TableAdapters.DepartmentTableAdapter();
            this.BBack = new System.Windows.Forms.Button();
            this.BFind = new System.Windows.Forms.Button();
            this.CBDEPID = new System.Windows.Forms.ComboBox();
            this.BShow = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.TBCAPACITY = new System.Windows.Forms.TextBox();
            this.CBHDOCID = new System.Windows.Forms.ComboBox();
            this.CBHNURSEID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hospitalDataSet2 = new DBLAB_EXAM.HospitalDataSet2();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new DBLAB_EXAM.HospitalDataSet2TableAdapters.DoctorTableAdapter();
            this.hospitalDataSet7 = new DBLAB_EXAM.HospitalDataSet7();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter = new DBLAB_EXAM.HospitalDataSet7TableAdapters.NurseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 320);
            this.dataGridView1.TabIndex = 0;
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
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hospitalDataSet6;
            // 
            // hospitalDataSet6
            // 
            this.hospitalDataSet6.DataSetName = "HospitalDataSet6";
            this.hospitalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BBack.ForeColor = System.Drawing.SystemColors.Control;
            this.BBack.Location = new System.Drawing.Point(525, 8);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(125, 36);
            this.BBack.TabIndex = 16;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BFind
            // 
            this.BFind.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFind.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BFind.ForeColor = System.Drawing.Color.Navy;
            this.BFind.Location = new System.Drawing.Point(265, 12);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(178, 69);
            this.BFind.TabIndex = 17;
            this.BFind.Text = "Find";
            this.BFind.UseVisualStyleBackColor = false;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // CBDEPID
            // 
            this.CBDEPID.DataSource = this.departmentBindingSource;
            this.CBDEPID.DisplayMember = "DID";
            this.CBDEPID.FormattingEnabled = true;
            this.CBDEPID.Location = new System.Drawing.Point(131, 36);
            this.CBDEPID.Name = "CBDEPID";
            this.CBDEPID.Size = new System.Drawing.Size(121, 24);
            this.CBDEPID.TabIndex = 18;
            // 
            // BShow
            // 
            this.BShow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BShow.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BShow.ForeColor = System.Drawing.Color.Navy;
            this.BShow.Location = new System.Drawing.Point(462, 105);
            this.BShow.Name = "BShow";
            this.BShow.Size = new System.Drawing.Size(178, 69);
            this.BShow.TabIndex = 19;
            this.BShow.Text = "Show ALL";
            this.BShow.UseVisualStyleBackColor = false;
            this.BShow.Click += new System.EventHandler(this.BShow_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdate.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BUpdate.ForeColor = System.Drawing.Color.Navy;
            this.BUpdate.Location = new System.Drawing.Point(265, 105);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(178, 69);
            this.BUpdate.TabIndex = 20;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // TBCAPACITY
            // 
            this.TBCAPACITY.Location = new System.Drawing.Point(130, 165);
            this.TBCAPACITY.Name = "TBCAPACITY";
            this.TBCAPACITY.Size = new System.Drawing.Size(100, 22);
            this.TBCAPACITY.TabIndex = 21;
            this.TBCAPACITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCAPACITY_KeyPress);
            // 
            // CBHDOCID
            // 
            this.CBHDOCID.DataSource = this.doctorBindingSource;
            this.CBHDOCID.DisplayMember = "DRID";
            this.CBHDOCID.FormattingEnabled = true;
            this.CBHDOCID.Location = new System.Drawing.Point(121, 105);
            this.CBHDOCID.Name = "CBHDOCID";
            this.CBHDOCID.Size = new System.Drawing.Size(121, 24);
            this.CBHDOCID.TabIndex = 22;
            // 
            // CBHNURSEID
            // 
            this.CBHNURSEID.DataSource = this.nurseBindingSource;
            this.CBHNURSEID.DisplayMember = "NID";
            this.CBHNURSEID.FormattingEnabled = true;
            this.CBHNURSEID.Location = new System.Drawing.Point(121, 135);
            this.CBHNURSEID.Name = "CBHNURSEID";
            this.CBHNURSEID.Size = new System.Drawing.Size(121, 24);
            this.CBHNURSEID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Head Doc ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Head Nurse ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Department ID";
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDataSet2;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalDataSet7
            // 
            this.hospitalDataSet7.DataSetName = "HospitalDataSet7";
            this.hospitalDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.hospitalDataSet7;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // Department_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBHNURSEID);
            this.Controls.Add(this.CBHDOCID);
            this.Controls.Add(this.TBCAPACITY);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.BShow);
            this.Controls.Add(this.CBDEPID);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Department_Update";
            this.Text = "Department_Update";
            this.Load += new System.EventHandler(this.Department_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet6 hospitalDataSet6;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HospitalDataSet6TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.ComboBox CBDEPID;
        private System.Windows.Forms.Button BShow;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.TextBox TBCAPACITY;
        private System.Windows.Forms.ComboBox CBHDOCID;
        private System.Windows.Forms.ComboBox CBHNURSEID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private HospitalDataSet7 hospitalDataSet7;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private HospitalDataSet7TableAdapters.NurseTableAdapter nurseTableAdapter;
    }
}