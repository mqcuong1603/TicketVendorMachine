namespace TicketVendorMachine.Forms
{
    partial class TicketDisplayForm
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
            this.lblTicketCode = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panelTicketInfo = new System.Windows.Forms.Panel();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.groupBoxBarcode = new System.Windows.Forms.GroupBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panelTicketInfo.SuspendLayout();
            this.groupBoxBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(95, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎫 Your Ticket";
            // 
            // lblTicketCode
            // 
            this.lblTicketCode.AutoSize = true;
            this.lblTicketCode.Location = new System.Drawing.Point(101, 92);
            this.lblTicketCode.Name = "lblTicketCode";
            this.lblTicketCode.Size = new System.Drawing.Size(175, 16);
            this.lblTicketCode.TabIndex = 1;
            this.lblTicketCode.Text = "Ticket Code: TKT123456789";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(13, 16);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(145, 16);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination: Ben Thanh";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 32);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: 15,000 VND";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(329, 169);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "🖨️ PRINT TICKET";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panelTicketInfo
            // 
            this.panelTicketInfo.Controls.Add(this.lblDestination);
            this.panelTicketInfo.Controls.Add(this.lblIssueDate);
            this.panelTicketInfo.Controls.Add(this.lblPrice);
            this.panelTicketInfo.Location = new System.Drawing.Point(88, 92);
            this.panelTicketInfo.Name = "panelTicketInfo";
            this.panelTicketInfo.Size = new System.Drawing.Size(200, 100);
            this.panelTicketInfo.TabIndex = 7;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(5, 48);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(192, 16);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "Issue Date: 2025-11-17 14:30:00";
            // 
            // groupBoxBarcode
            // 
            this.groupBoxBarcode.Controls.Add(this.pictureBoxBarcode);
            this.groupBoxBarcode.Location = new System.Drawing.Point(88, 218);
            this.groupBoxBarcode.Name = "groupBoxBarcode";
            this.groupBoxBarcode.Size = new System.Drawing.Size(200, 100);
            this.groupBoxBarcode.TabIndex = 9;
            this.groupBoxBarcode.TabStop = false;
            this.groupBoxBarcode.Text = "Ticket Barcode / QR Code";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(51, 30);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBarcode.TabIndex = 10;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(329, 230);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "✓ FINISH";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // TicketDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblTicketCode);
            this.Controls.Add(this.groupBoxBarcode);
            this.Controls.Add(this.panelTicketInfo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTitle);
            this.Name = "TicketDisplayForm";
            this.Text = "Ticket Display";
            this.panelTicketInfo.ResumeLayout(false);
            this.panelTicketInfo.PerformLayout();
            this.groupBoxBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTicketCode;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panelTicketInfo;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.GroupBox groupBoxBarcode;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Button btnFinish;
    }
}