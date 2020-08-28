namespace DBLAB_EXAM
{
    partial class Update_Patient
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
            this.patientTableAdapter = new DBLAB_EXAM.HospitalDataSet1TableAdapters.PatientTableAdapter();
            this.TBCONTACT = new System.Windows.Forms.TextBox();
            this.TBAGE = new System.Windows.Forms.TextBox();
            this.TBVISIT = new System.Windows.Forms.TextBox();
            this.CBSSN = new System.Windows.Forms.ComboBox();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet4 = new DBLAB_EXAM.HospitalDataSet4();
            this.CBDOCID = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new DBLAB_EXAM.HospitalDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bupdate = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.patientTableAdapter1 = new DBLAB_EXAM.HospitalDataSet4TableAdapters.PatientTableAdapter();
            this.doctorTableAdapter = new DBLAB_EXAM.HospitalDataSet2TableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 311);
            this.dataGridView1.TabIndex = 0;
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
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // TBCONTACT
            // 
            this.TBCONTACT.Location = new System.Drawing.Point(497, 43);
            this.TBCONTACT.Name = "TBCONTACT";
            this.TBCONTACT.Size = new System.Drawing.Size(100, 22);
            this.TBCONTACT.TabIndex = 1;
            this.TBCONTACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCONTACT_KeyPress);
            // 
            // TBAGE
            // 
            this.TBAGE.Location = new System.Drawing.Point(497, 94);
            this.TBAGE.Name = "TBAGE";
            this.TBAGE.Size = new System.Drawing.Size(100, 22);
            this.TBAGE.TabIndex = 2;
            this.TBAGE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAGE_KeyPress);
            // 
            // TBVISIT
            // 
            this.TBVISIT.Location = new System.Drawing.Point(497, 145);
            this.TBVISIT.Name = "TBVISIT";
            this.TBVISIT.Size = new System.Drawing.Size(100, 22);
            this.TBVISIT.TabIndex = 3;
            this.TBVISIT.TextChanged += new System.EventHandler(this.TBVISIT_TextChanged);
            this.TBVISIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBVISIT_KeyPress);
            // 
            // CBSSN
            // 
            this.CBSSN.DataSource = this.patientBindingSource1;
            this.CBSSN.DisplayMember = "SSN";
            this.CBSSN.FormattingEnabled = true;
            this.CBSSN.Location = new System.Drawing.Point(170, 60);
            this.CBSSN.Name = "CBSSN";
            this.CBSSN.Size = new System.Drawing.Size(121, 24);
            this.CBSSN.TabIndex = 4;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.hospitalDataSet4;
            // 
            // hospitalDataSet4
            // 
            this.hospitalDataSet4.DataSetName = "HospitalDataSet4";
            this.hospitalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBDOCID
            // 
            this.CBDOCID.DataSource = this.doctorBindingSource;
            this.CBDOCID.DisplayMember = "DRID";
            this.CBDOCID.FormattingEnabled = true;
            this.CBDOCID.Location = new System.Drawing.Point(182, 125);
            this.CBDOCID.Name = "CBDOCID";
            this.CBDOCID.Size = new System.Drawing.Size(121, 24);
            this.CBDOCID.TabIndex = 5;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDataSet2;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paitent SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attending Doctor ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label3.Location = new System.Drawing.Point(324, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label4.Location = new System.Drawing.Point(371, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Visit Purpose";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label5.Location = new System.Drawing.Point(416, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age";
            // 
            // Bupdate
            // 
            this.Bupdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Bupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bupdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Bupdate.ForeColor = System.Drawing.Color.Navy;
            this.Bupdate.Location = new System.Drawing.Point(674, 69);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(190, 73);
            this.Bupdate.TabIndex = 11;
            this.Bupdate.Text = "Update Information";
            this.Bupdate.UseVisualStyleBackColor = false;
            this.Bupdate.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BBack.Location = new System.Drawing.Point(939, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(141, 51);
            this.BBack.TabIndex = 12;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // Update_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 546);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBDOCID);
            this.Controls.Add(this.CBSSN);
            this.Controls.Add(this.TBVISIT);
            this.Controls.Add(this.TBAGE);
            this.Controls.Add(this.TBCONTACT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Update_Patient";
            this.Text = "Update_Patient";
            this.Load += new System.EventHandler(this.Update_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox TBCONTACT;
        private System.Windows.Forms.TextBox TBAGE;
        private System.Windows.Forms.TextBox TBVISIT;
        private System.Windows.Forms.ComboBox CBSSN;
        private System.Windows.Forms.ComboBox CBDOCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button BBack;
        private HospitalDataSet4 hospitalDataSet4;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private HospitalDataSet4TableAdapters.PatientTableAdapter patientTableAdapter1;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}