namespace TicketVendorMachine.Reports
{
    partial class TransactionReportForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(103, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 Transaction Report";
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.dateTimePickerTo);
            this.panelFilters.Controls.Add(this.label2);
            this.panelFilters.Controls.Add(this.dateTimePickerFrom);
            this.panelFilters.Controls.Add(this.label1);
            this.panelFilters.Location = new System.Drawing.Point(47, 143);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(245, 153);
            this.panelFilters.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(3, 23);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(0, 67);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(0, 95);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(109, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Apply Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(430, 57);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewReport.TabIndex = 2;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnPrint);
            this.panelButtons.Controls.Add(this.btnExport);
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Location = new System.Drawing.Point(470, 264);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(200, 120);
            this.panelButtons.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "🔄 REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(0, 29);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "📥 EXPORT TO EXCEL";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(0, 58);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "🖨️ PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 87);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "❌ CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(722, 396);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Ready";
            // 
            // TransactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 463);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.lblTitle);
            this.Name = "TransactionReportForm";
            this.Text = "Transaction Report";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatus;
    }
}