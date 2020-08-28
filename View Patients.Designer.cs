namespace DBLAB_EXAM
{
    partial class View_Patients
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
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new DBLAB_EXAM.HospitalDataSet1();
            this.hospitalDataSet = new DBLAB_EXAM.HospitalDataSet();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new DBLAB_EXAM.HospitalDataSet1TableAdapters.PatientTableAdapter();
            this.RSSN = new System.Windows.Forms.RadioButton();
            this.RDOCID = new System.Windows.Forms.RadioButton();
            this.TBDATA = new System.Windows.Forms.TextBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BSearchPatient = new System.Windows.Forms.Button();
            this.BSearchDoctor = new System.Windows.Forms.Button();
            this.BSearchA = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hospitalDataSet5 = new DBLAB_EXAM.HospitalDataSet5();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new DBLAB_EXAM.HospitalDataSet5TableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSNDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.minitDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bloodCategoryDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.recordDataGridViewTextBoxColumn,
            this.visitTypeDataGridViewTextBoxColumn,
            this.dOCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // minitDataGridViewTextBoxColumn
            // 
            this.minitDataGridViewTextBoxColumn.DataPropertyName = "Minit";
            this.minitDataGridViewTextBoxColumn.HeaderText = "Minit";
            this.minitDataGridViewTextBoxColumn.Name = "minitDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bloodCategoryDataGridViewTextBoxColumn
            // 
            this.bloodCategoryDataGridViewTextBoxColumn.DataPropertyName = "BloodCategory";
            this.bloodCategoryDataGridViewTextBoxColumn.HeaderText = "BloodCategory";
            this.bloodCategoryDataGridViewTextBoxColumn.Name = "bloodCategoryDataGridViewTextBoxColumn";
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // recordDataGridViewTextBoxColumn
            // 
            this.recordDataGridViewTextBoxColumn.DataPropertyName = "Record";
            this.recordDataGridViewTextBoxColumn.HeaderText = "Record";
            this.recordDataGridViewTextBoxColumn.Name = "recordDataGridViewTextBoxColumn";
            // 
            // visitTypeDataGridViewTextBoxColumn
            // 
            this.visitTypeDataGridViewTextBoxColumn.DataPropertyName = "VisitType";
            this.visitTypeDataGridViewTextBoxColumn.HeaderText = "VisitType";
            this.visitTypeDataGridViewTextBoxColumn.Name = "visitTypeDataGridViewTextBoxColumn";
            // 
            // dOCIDDataGridViewTextBoxColumn
            // 
            this.dOCIDDataGridViewTextBoxColumn.DataPropertyName = "DOCID";
            this.dOCIDDataGridViewTextBoxColumn.HeaderText = "DOCID";
            this.dOCIDDataGridViewTextBoxColumn.Name = "dOCIDDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "HospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // RSSN
            // 
            this.RSSN.AutoSize = true;
            this.RSSN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RSSN.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.RSSN.Location = new System.Drawing.Point(735, 42);
            this.RSSN.Name = "RSSN";
            this.RSSN.Size = new System.Drawing.Size(148, 25);
            this.RSSN.TabIndex = 1;
            this.RSSN.TabStop = true;
            this.RSSN.Text = "Search By SSN";
            this.RSSN.UseVisualStyleBackColor = false;
            this.RSSN.Visible = false;
            // 
            // RDOCID
            // 
            this.RDOCID.AutoSize = true;
            this.RDOCID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RDOCID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.RDOCID.Location = new System.Drawing.Point(735, 86);
            this.RDOCID.Name = "RDOCID";
            this.RDOCID.Size = new System.Drawing.Size(190, 25);
            this.RDOCID.TabIndex = 2;
            this.RDOCID.TabStop = true;
            this.RDOCID.Text = "Search By Doctor ID";
            this.RDOCID.UseVisualStyleBackColor = false;
            this.RDOCID.Visible = false;
            // 
            // TBDATA
            // 
            this.TBDATA.Location = new System.Drawing.Point(497, 61);
            this.TBDATA.Name = "TBDATA";
            this.TBDATA.Size = new System.Drawing.Size(174, 22);
            this.TBDATA.TabIndex = 3;
            this.TBDATA.Visible = false;
            this.TBDATA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDATA_KeyPress);
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearch.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BSearch.ForeColor = System.Drawing.Color.Navy;
            this.BSearch.Location = new System.Drawing.Point(254, 42);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(185, 57);
            this.BSearch.TabIndex = 4;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = false;
            this.BSearch.Visible = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BBack.Location = new System.Drawing.Point(1033, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(133, 51);
            this.BBack.TabIndex = 5;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BSearchPatient
            // 
            this.BSearchPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearchPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearchPatient.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BSearchPatient.ForeColor = System.Drawing.Color.Navy;
            this.BSearchPatient.Location = new System.Drawing.Point(12, 16);
            this.BSearchPatient.Name = "BSearchPatient";
            this.BSearchPatient.Size = new System.Drawing.Size(188, 54);
            this.BSearchPatient.TabIndex = 6;
            this.BSearchPatient.Text = "Search For A Patient";
            this.BSearchPatient.UseVisualStyleBackColor = false;
            this.BSearchPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // BSearchDoctor
            // 
            this.BSearchDoctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearchDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearchDoctor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BSearchDoctor.ForeColor = System.Drawing.Color.Navy;
            this.BSearchDoctor.Location = new System.Drawing.Point(12, 86);
            this.BSearchDoctor.Name = "BSearchDoctor";
            this.BSearchDoctor.Size = new System.Drawing.Size(188, 54);
            this.BSearchDoctor.TabIndex = 7;
            this.BSearchDoctor.Text = "Search For Attending Doctor";
            this.BSearchDoctor.UseVisualStyleBackColor = false;
            this.BSearchDoctor.Click += new System.EventHandler(this.BSearchDoctor_Click);
            // 
            // BSearchA
            // 
            this.BSearchA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearchA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearchA.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BSearchA.ForeColor = System.Drawing.Color.Navy;
            this.BSearchA.Location = new System.Drawing.Point(254, 43);
            this.BSearchA.Name = "BSearchA";
            this.BSearchA.Size = new System.Drawing.Size(185, 57);
            this.BSearchA.TabIndex = 8;
            this.BSearchA.Text = "Search Attendent";
            this.BSearchA.UseVisualStyleBackColor = false;
            this.BSearchA.Visible = false;
            this.BSearchA.Click += new System.EventHandler(this.BSearchA_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1140, 362);
            this.dataGridView2.TabIndex = 9;
            // 
            // hospitalDataSet5
            // 
            this.hospitalDataSet5.DataSetName = "HospitalDataSet5";
            this.hospitalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDataSet5;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // View_Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 565);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BSearchA);
            this.Controls.Add(this.BSearchDoctor);
            this.Controls.Add(this.BSearchPatient);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.TBDATA);
            this.Controls.Add(this.RDOCID);
            this.Controls.Add(this.RSSN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Patients";
            this.Text = "View_Patients";
            this.Load += new System.EventHandler(this.View_Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet hospitalDataSet;
        private HospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton RSSN;
        private System.Windows.Forms.RadioButton RDOCID;
        private System.Windows.Forms.TextBox TBDATA;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BSearchPatient;
        private System.Windows.Forms.Button BSearchDoctor;
        private System.Windows.Forms.Button BSearchA;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HospitalDataSet5 hospitalDataSet5;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDataSet5TableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}