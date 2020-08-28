namespace DBLAB_EXAM
{
    partial class UpdateDrug
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
            this.hospitalDataSet = new DBLAB_EXAM.HospitalDataSet();
            this.pharmacyTableAdapter = new DBLAB_EXAM.HospitalDataSetTableAdapters.PharmacyTableAdapter();
            this.TBDrugName = new System.Windows.Forms.TextBox();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.BUpdate = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(283, 450);
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
            this.pharmacyBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // TBDrugName
            // 
            this.TBDrugName.Location = new System.Drawing.Point(412, 115);
            this.TBDrugName.Name = "TBDrugName";
            this.TBDrugName.Size = new System.Drawing.Size(100, 22);
            this.TBDrugName.TabIndex = 1;
            this.TBDrugName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDrugName_KeyPress);
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(412, 220);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(100, 22);
            this.TBQuantity.TabIndex = 2;
            this.TBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBQuantity_KeyPress);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BUpdate.ForeColor = System.Drawing.Color.Navy;
            this.BUpdate.Location = new System.Drawing.Point(552, 143);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(153, 77);
            this.BUpdate.TabIndex = 3;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.D.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.D.Location = new System.Drawing.Point(306, 115);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(95, 21);
            this.D.TabIndex = 4;
            this.D.Text = "Drug Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.Location = new System.Drawing.Point(319, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BBack.Location = new System.Drawing.Point(607, 12);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(131, 44);
            this.BBack.TabIndex = 6;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // UpdateDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 567);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.D);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.TBDrugName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateDrug";
            this.Text = "UpdateDrug";
            this.Load += new System.EventHandler(this.UpdateDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private HospitalDataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TBDrugName;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BBack;
    }
}