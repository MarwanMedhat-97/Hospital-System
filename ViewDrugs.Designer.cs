namespace DBLAB_EXAM
{
    partial class ViewDrugs
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
            this.hospitalDataSet3 = new DBLAB_EXAM.HospitalDataSet3();
            this.TBDrugname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BSearch = new System.Windows.Forms.Button();
            this.BSeacrhN = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.pharmacyTableAdapter = new DBLAB_EXAM.HospitalDataSet3TableAdapters.PharmacyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 354);
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
            this.pharmacyBindingSource.DataSource = this.hospitalDataSet3;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "HospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBDrugname
            // 
            this.TBDrugname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDrugname.Location = new System.Drawing.Point(107, 58);
            this.TBDrugname.Multiline = true;
            this.TBDrugname.Name = "TBDrugname";
            this.TBDrugname.Size = new System.Drawing.Size(131, 31);
            this.TBDrugname.TabIndex = 1;
            this.TBDrugname.Visible = false;
            this.TBDrugname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDrugname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drug Name";
            this.label1.Visible = false;
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSearch.ForeColor = System.Drawing.Color.Navy;
            this.BSearch.Location = new System.Drawing.Point(421, 40);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(171, 67);
            this.BSearch.TabIndex = 4;
            this.BSearch.Text = "Search for a Drug";
            this.BSearch.UseVisualStyleBackColor = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BSeacrhN
            // 
            this.BSeacrhN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSeacrhN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSeacrhN.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSeacrhN.ForeColor = System.Drawing.Color.Navy;
            this.BSeacrhN.Location = new System.Drawing.Point(266, 45);
            this.BSeacrhN.Name = "BSeacrhN";
            this.BSeacrhN.Size = new System.Drawing.Size(130, 58);
            this.BSeacrhN.TabIndex = 5;
            this.BSeacrhN.Text = "Find";
            this.BSeacrhN.UseVisualStyleBackColor = false;
            this.BSeacrhN.Visible = false;
            this.BSeacrhN.Click += new System.EventHandler(this.BSeacrhN_Click);
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BBack.ForeColor = System.Drawing.SystemColors.Control;
            this.BBack.Location = new System.Drawing.Point(601, 7);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(125, 36);
            this.BBack.TabIndex = 6;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 522);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BSeacrhN);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDrugname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDrugs";
            this.Text = "ViewDrugs";
            this.Load += new System.EventHandler(this.ViewDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBDrugname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button BSeacrhN;
        private System.Windows.Forms.Button BBack;
        private HospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private HospitalDataSet3TableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}