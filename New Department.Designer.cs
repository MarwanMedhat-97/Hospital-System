namespace DBLAB_EXAM
{
    partial class New_Department
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
            this.TBID = new System.Windows.Forms.TextBox();
            this.TBLOCATION = new System.Windows.Forms.TextBox();
            this.TBCAPACITY = new System.Windows.Forms.TextBox();
            this.TBTYPE = new System.Windows.Forms.TextBox();
            this.CBHDOCTOR = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet5 = new DBLAB_EXAM.HospitalDataSet5();
            this.CBHNURSE = new System.Windows.Forms.ComboBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet7 = new DBLAB_EXAM.HospitalDataSet7();
            this.departmentTableAdapter = new DBLAB_EXAM.HospitalDataSet6TableAdapters.DepartmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BADD = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.hospitalDataSet2 = new DBLAB_EXAM.HospitalDataSet2();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new DBLAB_EXAM.HospitalDataSet2TableAdapters.DoctorTableAdapter();
            this.doctorTableAdapter1 = new DBLAB_EXAM.HospitalDataSet5TableAdapters.DoctorTableAdapter();
            this.nurseTableAdapter = new DBLAB_EXAM.HospitalDataSet7TableAdapters.NurseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 240);
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
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(174, 53);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(100, 22);
            this.TBID.TabIndex = 1;
            this.TBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBID_KeyPress);
            // 
            // TBLOCATION
            // 
            this.TBLOCATION.Location = new System.Drawing.Point(174, 94);
            this.TBLOCATION.Name = "TBLOCATION";
            this.TBLOCATION.Size = new System.Drawing.Size(100, 22);
            this.TBLOCATION.TabIndex = 2;
            this.TBLOCATION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLOCATION_KeyPress);
            // 
            // TBCAPACITY
            // 
            this.TBCAPACITY.Location = new System.Drawing.Point(174, 131);
            this.TBCAPACITY.Name = "TBCAPACITY";
            this.TBCAPACITY.Size = new System.Drawing.Size(100, 22);
            this.TBCAPACITY.TabIndex = 3;
            this.TBCAPACITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCAPACITY_KeyPress);
            // 
            // TBTYPE
            // 
            this.TBTYPE.Location = new System.Drawing.Point(174, 167);
            this.TBTYPE.Name = "TBTYPE";
            this.TBTYPE.Size = new System.Drawing.Size(100, 22);
            this.TBTYPE.TabIndex = 4;
            this.TBTYPE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTYPE_KeyPress);
            // 
            // CBHDOCTOR
            // 
            this.CBHDOCTOR.DataSource = this.doctorBindingSource1;
            this.CBHDOCTOR.DisplayMember = "DRID";
            this.CBHDOCTOR.FormattingEnabled = true;
            this.CBHDOCTOR.Location = new System.Drawing.Point(395, 53);
            this.CBHDOCTOR.Name = "CBHDOCTOR";
            this.CBHDOCTOR.Size = new System.Drawing.Size(121, 24);
            this.CBHDOCTOR.TabIndex = 5;
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.hospitalDataSet5;
            // 
            // hospitalDataSet5
            // 
            this.hospitalDataSet5.DataSetName = "HospitalDataSet5";
            this.hospitalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBHNURSE
            // 
            this.CBHNURSE.DataSource = this.nurseBindingSource;
            this.CBHNURSE.DisplayMember = "NID";
            this.CBHNURSE.FormattingEnabled = true;
            this.CBHNURSE.Location = new System.Drawing.Point(395, 131);
            this.CBHNURSE.Name = "CBHNURSE";
            this.CBHNURSE.Size = new System.Drawing.Size(121, 24);
            this.CBHNURSE.TabIndex = 6;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.hospitalDataSet7;
            // 
            // hospitalDataSet7
            // 
            this.hospitalDataSet7.DataSetName = "HospitalDataSet7";
            this.hospitalDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Department Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label4.Location = new System.Drawing.Point(65, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label5.Location = new System.Drawing.Point(294, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Head Doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label6.Location = new System.Drawing.Point(305, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Head Nurse";
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BADD.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BADD.ForeColor = System.Drawing.Color.Navy;
            this.BADD.Location = new System.Drawing.Point(542, 72);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(162, 58);
            this.BADD.TabIndex = 24;
            this.BADD.Text = "Insert";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BBack.Location = new System.Drawing.Point(593, 7);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(132, 44);
            this.BBack.TabIndex = 25;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
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
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // New_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 474);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBHNURSE);
            this.Controls.Add(this.CBHDOCTOR);
            this.Controls.Add(this.TBTYPE);
            this.Controls.Add(this.TBCAPACITY);
            this.Controls.Add(this.TBLOCATION);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "New_Department";
            this.Text = "New_Department";
            this.Load += new System.EventHandler(this.New_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.TextBox TBLOCATION;
        private System.Windows.Forms.TextBox TBCAPACITY;
        private System.Windows.Forms.TextBox TBTYPE;
        private System.Windows.Forms.ComboBox CBHDOCTOR;
        private System.Windows.Forms.ComboBox CBHNURSE;
        private HospitalDataSet6 hospitalDataSet6;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HospitalDataSet6TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Button BBack;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private HospitalDataSet5 hospitalDataSet5;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private HospitalDataSet5TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private HospitalDataSet7 hospitalDataSet7;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private HospitalDataSet7TableAdapters.NurseTableAdapter nurseTableAdapter;
    }
}