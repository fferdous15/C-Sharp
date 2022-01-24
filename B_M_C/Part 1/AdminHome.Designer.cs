namespace B_M_C
{
    partial class AdminHome
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.finalTableDataSet8 = new B_M_C.FinalTableDataSet8();
            this.reportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableTableAdapter = new B_M_C.FinalTableDataSet8TableAdapters.ReportTableTableAdapter();
            this.bandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hirerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalTableDataSet9 = new B_M_C.FinalTableDataSet9();
            this.bandFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandFinalTableAdapter = new B_M_C.FinalTableDataSet9TableAdapters.BandFinalTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalTableDataSet10 = new B_M_C.FinalTableDataSet10();
            this.userFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userFinalTableAdapter = new B_M_C.FinalTableDataSet10TableAdapters.UserFinalTableAdapter();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFinalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bandNameDataGridViewTextBoxColumn,
            this.hirerDataGridViewTextBoxColumn,
            this.reportStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bandFinalBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(31, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(387, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.userFinalBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(31, 347);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(387, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // finalTableDataSet8
            // 
            this.finalTableDataSet8.DataSetName = "FinalTableDataSet8";
            this.finalTableDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTableBindingSource
            // 
            this.reportTableBindingSource.DataMember = "ReportTable";
            this.reportTableBindingSource.DataSource = this.finalTableDataSet8;
            // 
            // reportTableTableAdapter
            // 
            this.reportTableTableAdapter.ClearBeforeFill = true;
            // 
            // bandNameDataGridViewTextBoxColumn
            // 
            this.bandNameDataGridViewTextBoxColumn.DataPropertyName = "Band_Name";
            this.bandNameDataGridViewTextBoxColumn.HeaderText = "Band_Name";
            this.bandNameDataGridViewTextBoxColumn.Name = "bandNameDataGridViewTextBoxColumn";
            // 
            // hirerDataGridViewTextBoxColumn
            // 
            this.hirerDataGridViewTextBoxColumn.DataPropertyName = "Hirer";
            this.hirerDataGridViewTextBoxColumn.HeaderText = "Hirer";
            this.hirerDataGridViewTextBoxColumn.Name = "hirerDataGridViewTextBoxColumn";
            // 
            // reportStatusDataGridViewTextBoxColumn
            // 
            this.reportStatusDataGridViewTextBoxColumn.DataPropertyName = "Report_Status";
            this.reportStatusDataGridViewTextBoxColumn.HeaderText = "Report_Status";
            this.reportStatusDataGridViewTextBoxColumn.Name = "reportStatusDataGridViewTextBoxColumn";
            // 
            // finalTableDataSet9
            // 
            this.finalTableDataSet9.DataSetName = "FinalTableDataSet9";
            this.finalTableDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandFinalBindingSource
            // 
            this.bandFinalBindingSource.DataMember = "BandFinal";
            this.bandFinalBindingSource.DataSource = this.finalTableDataSet9;
            // 
            // bandFinalTableAdapter
            // 
            this.bandFinalTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // finalTableDataSet10
            // 
            this.finalTableDataSet10.DataSetName = "FinalTableDataSet10";
            this.finalTableDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userFinalBindingSource
            // 
            this.userFinalBindingSource.DataMember = "UserFinal";
            this.userFinalBindingSource.DataSource = this.finalTableDataSet10;
            // 
            // userFinalTableAdapter
            // 
            this.userFinalTableAdapter.ClearBeforeFill = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(658, 529);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTableDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFinalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private FinalTableDataSet8 finalTableDataSet8;
        private System.Windows.Forms.BindingSource reportTableBindingSource;
        private FinalTableDataSet8TableAdapters.ReportTableTableAdapter reportTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hirerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportStatusDataGridViewTextBoxColumn;
        private FinalTableDataSet9 finalTableDataSet9;
        private System.Windows.Forms.BindingSource bandFinalBindingSource;
        private FinalTableDataSet9TableAdapters.BandFinalTableAdapter bandFinalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private FinalTableDataSet10 finalTableDataSet10;
        private System.Windows.Forms.BindingSource userFinalBindingSource;
        private FinalTableDataSet10TableAdapters.UserFinalTableAdapter userFinalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}