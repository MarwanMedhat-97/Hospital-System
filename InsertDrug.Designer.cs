namespace DBLAB_EXAM
{
    partial class InsertDrug
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
            this.drugNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new DBLAB_EXAM.HospitalDataSet();
            this.BADD = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BInsert = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.TBDNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BBack = new System.Windows.Forms.Button();
            this.pharmacyTableAdapter = new DBLAB_EXAM.HospitalDataSetTableAdapters.PharmacyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pharmacyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // drugNameDataGridViewTextBoxColumn
            // 
            this.drugNameDataGridViewTextBoxColumn.DataPropertyName = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.HeaderText = "DrugName";
            this.drugNameDataGridViewTextBoxColumn.Name = "drugNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.hospitalDataSetBindingSource;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BADD.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BADD.ForeColor = System.Drawing.Color.Navy;
            this.BADD.Location = new System.Drawing.Point(306, 36);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(171, 60);
            this.BADD.TabIndex = 1;
            this.BADD.Text = "ADD";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Visible = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(126, 33);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 22);
            this.TBName.TabIndex = 2;
            this.TBName.Visible = false;
            this.TBName.TextChanged += new System.EventHandler(this.TBName_TextChanged);
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(126, 82);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(100, 22);
            this.TBQuantity.TabIndex = 3;
            this.TBQuantity.Visible = false;
            this.TBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBQuantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drug Name";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BInsert
            // 
            this.BInsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BInsert.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BInsert.ForeColor = System.Drawing.Color.Navy;
            this.BInsert.Location = new System.Drawing.Point(524, 82);
            this.BInsert.Name = "BInsert";
            this.BInsert.Size = new System.Drawing.Size(176, 60);
            this.BInsert.TabIndex = 6;
            this.BInsert.Text = "Insert A Drug";
            this.BInsert.UseVisualStyleBackColor = false;
            this.BInsert.Click += new System.EventHandler(this.BInsert_Click);
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRemove.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BRemove.ForeColor = System.Drawing.Color.Navy;
            this.BRemove.Location = new System.Drawing.Point(524, 168);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(176, 61);
            this.BRemove.TabIndex = 7;
            this.BRemove.Text = "Remove A Drug";
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // BDelete
            // 
            this.BDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDelete.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.BDelete.ForeColor = System.Drawing.Color.Navy;
            this.BDelete.Location = new System.Drawing.Point(306, 149);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(171, 61);
            this.BDelete.TabIndex = 8;
            this.BDelete.Text = "Remove";
            this.BDelete.UseVisualStyleBackColor = false;
            this.BDelete.Visible = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // TBDNAME
            // 
            this.TBDNAME.Location = new System.Drawing.Point(126, 168);
            this.TBDNAME.Name = "TBDNAME";
            this.TBDNAME.Size = new System.Drawing.Size(100, 22);
            this.TBDNAME.TabIndex = 9;
            this.TBDNAME.Visible = false;
            this.TBDNAME.TextChanged += new System.EventHandler(this.TBDNAME_TextChanged);
            this.TBDNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDNAME_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label3.Location = new System.Drawing.Point(21, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Drug Name";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BBack.Location = new System.Drawing.Point(592, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(132, 49);
            this.BBack.TabIndex = 11;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // InsertDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 549);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBDNAME);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InsertDrug";
            this.Text = "InsertDrug";
            this.Load += new System.EventHandler(this.InsertDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BInsert;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.TextBox TBDNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private HospitalDataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}