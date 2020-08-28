namespace DBLAB_EXAM
{
    partial class New_Patient
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
            this.TBSSN = new System.Windows.Forms.TextBox();
            this.TBFNAME = new System.Windows.Forms.TextBox();
            this.TBMINIT = new System.Windows.Forms.TextBox();
            this.TBLNAME = new System.Windows.Forms.TextBox();
            this.TBVISIT = new System.Windows.Forms.TextBox();
            this.TBCONTACTINFO = new System.Windows.Forms.TextBox();
            this.TBAGE = new System.Windows.Forms.TextBox();
            this.TBRECORD = new System.Windows.Forms.TextBox();
            this.CBDOCID = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new DBLAB_EXAM.HospitalDataSet2();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.CBBLOOD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.doctorTableAdapter = new DBLAB_EXAM.HospitalDataSet2TableAdapters.DoctorTableAdapter();
            this.BADD = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(1071, 324);
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
            // TBSSN
            // 
            this.TBSSN.Location = new System.Drawing.Point(104, 29);
            this.TBSSN.Name = "TBSSN";
            this.TBSSN.Size = new System.Drawing.Size(100, 22);
            this.TBSSN.TabIndex = 1;
            this.TBSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TBFNAME
            // 
            this.TBFNAME.Location = new System.Drawing.Point(104, 69);
            this.TBFNAME.Name = "TBFNAME";
            this.TBFNAME.Size = new System.Drawing.Size(100, 22);
            this.TBFNAME.TabIndex = 2;
            this.TBFNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // TBMINIT
            // 
            this.TBMINIT.Location = new System.Drawing.Point(104, 111);
            this.TBMINIT.Name = "TBMINIT";
            this.TBMINIT.Size = new System.Drawing.Size(100, 22);
            this.TBMINIT.TabIndex = 3;
            this.TBMINIT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TBMINIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // TBLNAME
            // 
            this.TBLNAME.Location = new System.Drawing.Point(104, 148);
            this.TBLNAME.Name = "TBLNAME";
            this.TBLNAME.Size = new System.Drawing.Size(100, 22);
            this.TBLNAME.TabIndex = 4;
            this.TBLNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLNAME_KeyPress);
            // 
            // TBVISIT
            // 
            this.TBVISIT.Location = new System.Drawing.Point(341, 148);
            this.TBVISIT.Name = "TBVISIT";
            this.TBVISIT.Size = new System.Drawing.Size(100, 22);
            this.TBVISIT.TabIndex = 5;
            this.TBVISIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBVISIT_KeyPress);
            // 
            // TBCONTACTINFO
            // 
            this.TBCONTACTINFO.Location = new System.Drawing.Point(341, 29);
            this.TBCONTACTINFO.Name = "TBCONTACTINFO";
            this.TBCONTACTINFO.Size = new System.Drawing.Size(100, 22);
            this.TBCONTACTINFO.TabIndex = 6;
            this.TBCONTACTINFO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCONTACTINFO_KeyPress);
            // 
            // TBAGE
            // 
            this.TBAGE.Location = new System.Drawing.Point(341, 69);
            this.TBAGE.Name = "TBAGE";
            this.TBAGE.Size = new System.Drawing.Size(100, 22);
            this.TBAGE.TabIndex = 7;
            this.TBAGE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAGE_KeyPress);
            // 
            // TBRECORD
            // 
            this.TBRECORD.Location = new System.Drawing.Point(341, 111);
            this.TBRECORD.Name = "TBRECORD";
            this.TBRECORD.Size = new System.Drawing.Size(100, 22);
            this.TBRECORD.TabIndex = 8;
            this.TBRECORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBRECORD_KeyPress);
            // 
            // CBDOCID
            // 
            this.CBDOCID.DataSource = this.doctorBindingSource1;
            this.CBDOCID.DisplayMember = "DRID";
            this.CBDOCID.FormattingEnabled = true;
            this.CBDOCID.Location = new System.Drawing.Point(775, 67);
            this.CBDOCID.Name = "CBDOCID";
            this.CBDOCID.Size = new System.Drawing.Size(121, 24);
            this.CBDOCID.TabIndex = 9;
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.hospitalDataSet2;
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
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBGender.Location = new System.Drawing.Point(574, 25);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(121, 24);
            this.CBGender.TabIndex = 10;
            // 
            // CBBLOOD
            // 
            this.CBBLOOD.FormattingEnabled = true;
            this.CBBLOOD.Items.AddRange(new object[] {
            "O",
            "OH",
            "H",
            "H+",
            "H-",
            "B",
            "B-",
            "A-",
            "A"});
            this.CBBLOOD.Location = new System.Drawing.Point(574, 105);
            this.CBBLOOD.Name = "CBBLOOD";
            this.CBBLOOD.Size = new System.Drawing.Size(121, 24);
            this.CBBLOOD.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label5.Location = new System.Drawing.Point(225, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact Info";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label6.Location = new System.Drawing.Point(270, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label7.Location = new System.Drawing.Point(256, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Record";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label8.Location = new System.Drawing.Point(242, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Visit Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label9.Location = new System.Drawing.Point(450, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Blood Catogary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label10.Location = new System.Drawing.Point(490, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label11.Location = new System.Drawing.Point(679, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Doctor ID";
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BADD.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BADD.ForeColor = System.Drawing.Color.Navy;
            this.BADD.Location = new System.Drawing.Point(921, 80);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(162, 74);
            this.BADD.TabIndex = 23;
            this.BADD.Text = "Insert";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BBack.Location = new System.Drawing.Point(951, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(132, 44);
            this.BBack.TabIndex = 24;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // New_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 548);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBBLOOD);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.CBDOCID);
            this.Controls.Add(this.TBRECORD);
            this.Controls.Add(this.TBAGE);
            this.Controls.Add(this.TBCONTACTINFO);
            this.Controls.Add(this.TBVISIT);
            this.Controls.Add(this.TBLNAME);
            this.Controls.Add(this.TBMINIT);
            this.Controls.Add(this.TBFNAME);
            this.Controls.Add(this.TBSSN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "New_Patient";
            this.Text = "New_Patient";
            this.Load += new System.EventHandler(this.New_Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox TBSSN;
        private System.Windows.Forms.TextBox TBFNAME;
        private System.Windows.Forms.TextBox TBMINIT;
        private System.Windows.Forms.TextBox TBLNAME;
        private System.Windows.Forms.TextBox TBVISIT;
        private System.Windows.Forms.TextBox TBCONTACTINFO;
        private System.Windows.Forms.TextBox TBAGE;
        private System.Windows.Forms.TextBox TBRECORD;
        private System.Windows.Forms.ComboBox CBDOCID;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.ComboBox CBBLOOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
    }
}