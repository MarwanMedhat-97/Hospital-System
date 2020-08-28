namespace DBLAB_EXAM
{
    partial class View_Department
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
            this.hospitalDataSet6 = new DBLAB_EXAM.HospitalDataSet6();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new DBLAB_EXAM.HospitalDataSet6TableAdapters.DepartmentTableAdapter();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDOCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsearchID = new System.Windows.Forms.Button();
            this.Bsearchname = new System.Windows.Forms.Button();
            this.CBDEPID = new System.Windows.Forms.ComboBox();
            this.CBDTYPE = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BsearchDEP = new System.Windows.Forms.Button();
            this.BHeadDoc = new System.Windows.Forms.Button();
            this.BsearchDocID = new System.Windows.Forms.Button();
            this.CBHDOCDID = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.BBack = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.departmentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.BHNURSEDID = new System.Windows.Forms.Button();
            this.BSearchEMP = new System.Windows.Forms.Button();
            this.BSearchEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource3)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 312);
            this.dataGridView1.TabIndex = 0;
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
            // BsearchID
            // 
            this.BsearchID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BsearchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BsearchID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BsearchID.ForeColor = System.Drawing.Color.Navy;
            this.BsearchID.Location = new System.Drawing.Point(47, 23);
            this.BsearchID.Name = "BsearchID";
            this.BsearchID.Size = new System.Drawing.Size(147, 50);
            this.BsearchID.TabIndex = 4;
            this.BsearchID.Text = "Search By ID";
            this.BsearchID.UseVisualStyleBackColor = false;
            this.BsearchID.Visible = false;
            this.BsearchID.Click += new System.EventHandler(this.BsearchID_Click);
            // 
            // Bsearchname
            // 
            this.Bsearchname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Bsearchname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsearchname.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Bsearchname.ForeColor = System.Drawing.Color.Navy;
            this.Bsearchname.Location = new System.Drawing.Point(47, 91);
            this.Bsearchname.Name = "Bsearchname";
            this.Bsearchname.Size = new System.Drawing.Size(147, 50);
            this.Bsearchname.TabIndex = 5;
            this.Bsearchname.Text = "Search By Type";
            this.Bsearchname.UseVisualStyleBackColor = false;
            this.Bsearchname.Visible = false;
            this.Bsearchname.Click += new System.EventHandler(this.Bsearchname_Click);
            // 
            // CBDEPID
            // 
            this.CBDEPID.DataSource = this.departmentBindingSource1;
            this.CBDEPID.DisplayMember = "DID";
            this.CBDEPID.FormattingEnabled = true;
            this.CBDEPID.Location = new System.Drawing.Point(306, 38);
            this.CBDEPID.Name = "CBDEPID";
            this.CBDEPID.Size = new System.Drawing.Size(121, 24);
            this.CBDEPID.TabIndex = 6;
            this.CBDEPID.Visible = false;
            // 
            // CBDTYPE
            // 
            this.CBDTYPE.DataSource = this.departmentBindingSource;
            this.CBDTYPE.DisplayMember = "Dtype";
            this.CBDTYPE.FormattingEnabled = true;
            this.CBDTYPE.Location = new System.Drawing.Point(306, 106);
            this.CBDTYPE.Name = "CBDTYPE";
            this.CBDTYPE.Size = new System.Drawing.Size(121, 24);
            this.CBDTYPE.TabIndex = 7;
            this.CBDTYPE.Visible = false;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.hospitalDataSet6;
            // 
            // BsearchDEP
            // 
            this.BsearchDEP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BsearchDEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BsearchDEP.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BsearchDEP.ForeColor = System.Drawing.Color.Navy;
            this.BsearchDEP.Location = new System.Drawing.Point(470, 23);
            this.BsearchDEP.Name = "BsearchDEP";
            this.BsearchDEP.Size = new System.Drawing.Size(147, 50);
            this.BsearchDEP.TabIndex = 8;
            this.BsearchDEP.Text = "Search Department";
            this.BsearchDEP.UseVisualStyleBackColor = false;
            this.BsearchDEP.Click += new System.EventHandler(this.BsearchDEP_Click);
            // 
            // BHeadDoc
            // 
            this.BHeadDoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BHeadDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BHeadDoc.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BHeadDoc.ForeColor = System.Drawing.Color.Navy;
            this.BHeadDoc.Location = new System.Drawing.Point(439, 91);
            this.BHeadDoc.Name = "BHeadDoc";
            this.BHeadDoc.Size = new System.Drawing.Size(178, 50);
            this.BHeadDoc.TabIndex = 9;
            this.BHeadDoc.Text = "Search Department Heads";
            this.BHeadDoc.UseVisualStyleBackColor = false;
            this.BHeadDoc.Click += new System.EventHandler(this.BHeadDoc_Click);
            // 
            // BsearchDocID
            // 
            this.BsearchDocID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BsearchDocID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BsearchDocID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BsearchDocID.ForeColor = System.Drawing.Color.Navy;
            this.BsearchDocID.Location = new System.Drawing.Point(47, 23);
            this.BsearchDocID.Name = "BsearchDocID";
            this.BsearchDocID.Size = new System.Drawing.Size(147, 50);
            this.BsearchDocID.TabIndex = 10;
            this.BsearchDocID.Text = "Search Doc ID";
            this.BsearchDocID.UseVisualStyleBackColor = false;
            this.BsearchDocID.Visible = false;
            this.BsearchDocID.Click += new System.EventHandler(this.BsearchDocID_Click);
            // 
            // CBHDOCDID
            // 
            this.CBHDOCDID.DataSource = this.departmentBindingSource3;
            this.CBHDOCDID.DisplayMember = "DID";
            this.CBHDOCDID.FormattingEnabled = true;
            this.CBHDOCDID.Location = new System.Drawing.Point(306, 68);
            this.CBHDOCDID.Name = "CBHDOCDID";
            this.CBHDOCDID.Size = new System.Drawing.Size(121, 24);
            this.CBHDOCDID.TabIndex = 11;
            this.CBHDOCDID.Visible = false;
            // 
            // departmentBindingSource2
            // 
            this.departmentBindingSource2.DataMember = "Department";
            this.departmentBindingSource2.DataSource = this.hospitalDataSet6;
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BBack.ForeColor = System.Drawing.SystemColors.Control;
            this.BBack.Location = new System.Drawing.Point(635, 6);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(125, 36);
            this.BBack.TabIndex = 12;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(748, 314);
            this.dataGridView2.TabIndex = 13;
            // 
            // departmentBindingSource3
            // 
            this.departmentBindingSource3.DataMember = "Department";
            this.departmentBindingSource3.DataSource = this.hospitalDataSet6;
            // 
            // BHNURSEDID
            // 
            this.BHNURSEDID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BHNURSEDID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BHNURSEDID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BHNURSEDID.ForeColor = System.Drawing.Color.Navy;
            this.BHNURSEDID.Location = new System.Drawing.Point(47, 91);
            this.BHNURSEDID.Name = "BHNURSEDID";
            this.BHNURSEDID.Size = new System.Drawing.Size(147, 50);
            this.BHNURSEDID.TabIndex = 14;
            this.BHNURSEDID.Text = "Search Nurse ID";
            this.BHNURSEDID.UseVisualStyleBackColor = false;
            this.BHNURSEDID.Visible = false;
            this.BHNURSEDID.Click += new System.EventHandler(this.BHNURSEDID_Click);
            // 
            // BSearchEMP
            // 
            this.BSearchEMP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearchEMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearchEMP.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BSearchEMP.ForeColor = System.Drawing.Color.Navy;
            this.BSearchEMP.Location = new System.Drawing.Point(623, 91);
            this.BSearchEMP.Name = "BSearchEMP";
            this.BSearchEMP.Size = new System.Drawing.Size(147, 50);
            this.BSearchEMP.TabIndex = 15;
            this.BSearchEMP.Text = "Search Employees";
            this.BSearchEMP.UseVisualStyleBackColor = false;
            this.BSearchEMP.Click += new System.EventHandler(this.BSearchEMP_Click);
            // 
            // BSearchEmployees
            // 
            this.BSearchEmployees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearchEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearchEmployees.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.BSearchEmployees.ForeColor = System.Drawing.Color.Navy;
            this.BSearchEmployees.Location = new System.Drawing.Point(47, 53);
            this.BSearchEmployees.Name = "BSearchEmployees";
            this.BSearchEmployees.Size = new System.Drawing.Size(147, 50);
            this.BSearchEmployees.TabIndex = 16;
            this.BSearchEmployees.Text = "Find Employees";
            this.BSearchEmployees.UseVisualStyleBackColor = false;
            this.BSearchEmployees.Visible = false;
            this.BSearchEmployees.Click += new System.EventHandler(this.BSearchEmployees_Click);
            // 
            // View_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 491);
            this.Controls.Add(this.BSearchEmployees);
            this.Controls.Add(this.BSearchEMP);
            this.Controls.Add(this.BHNURSEDID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.CBHDOCDID);
            this.Controls.Add(this.BsearchDocID);
            this.Controls.Add(this.BHeadDoc);
            this.Controls.Add(this.BsearchDEP);
            this.Controls.Add(this.CBDTYPE);
            this.Controls.Add(this.CBDEPID);
            this.Controls.Add(this.Bsearchname);
            this.Controls.Add(this.BsearchID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_Department";
            this.Text = "View_Department";
            this.Load += new System.EventHandler(this.View_Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource3)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button BsearchID;
        private System.Windows.Forms.Button Bsearchname;
        private System.Windows.Forms.ComboBox CBDEPID;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.ComboBox CBDTYPE;
        private System.Windows.Forms.Button BsearchDEP;
        private System.Windows.Forms.Button BHeadDoc;
        private System.Windows.Forms.Button BsearchDocID;
        private System.Windows.Forms.ComboBox CBHDOCDID;
        private System.Windows.Forms.BindingSource departmentBindingSource2;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource departmentBindingSource3;
        private System.Windows.Forms.Button BHNURSEDID;
        private System.Windows.Forms.Button BSearchEMP;
        private System.Windows.Forms.Button BSearchEmployees;
    }
}