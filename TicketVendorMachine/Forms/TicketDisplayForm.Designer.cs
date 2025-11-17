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
            this.panelTicket = new System.Windows.Forms.Panel();
            this.panelTicketInfo.SuspendLayout();
            this.groupBoxBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.panelTicket.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Ticket";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblTicketCode
            //
            this.lblTicketCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTicketCode.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTicketCode.Location = new System.Drawing.Point(20, 20);
            this.lblTicketCode.Name = "lblTicketCode";
            this.lblTicketCode.Size = new System.Drawing.Size(410, 30);
            this.lblTicketCode.TabIndex = 1;
            this.lblTicketCode.Text = "Ticket Code: TKT123456789";
            this.lblTicketCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblDestination
            //
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDestination.Location = new System.Drawing.Point(15, 15);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(163, 25);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination: Ben Thanh";
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPrice.Location = new System.Drawing.Point(15, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(166, 28);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: 15,000 VND";
            //
            // btnPrint
            //
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(310, 570);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(240, 50);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "PRINT TICKET";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            //
            // panelTicketInfo
            //
            this.panelTicketInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTicketInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelTicketInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicketInfo.Controls.Add(this.lblDestination);
            this.panelTicketInfo.Controls.Add(this.lblIssueDate);
            this.panelTicketInfo.Controls.Add(this.lblPrice);
            this.panelTicketInfo.Location = new System.Drawing.Point(10, 60);
            this.panelTicketInfo.Name = "panelTicketInfo";
            this.panelTicketInfo.Padding = new System.Windows.Forms.Padding(10);
            this.panelTicketInfo.Size = new System.Drawing.Size(430, 120);
            this.panelTicketInfo.TabIndex = 7;
            //
            // lblIssueDate
            //
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblIssueDate.Location = new System.Drawing.Point(15, 85);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(231, 23);
            this.lblIssueDate.TabIndex = 8;
            this.lblIssueDate.Text = "Issue Date: 2025-11-17 14:30:00";
            //
            // groupBoxBarcode
            //
            this.groupBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxBarcode.Controls.Add(this.pictureBoxBarcode);
            this.groupBoxBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxBarcode.Location = new System.Drawing.Point(10, 195);
            this.groupBoxBarcode.Name = "groupBoxBarcode";
            this.groupBoxBarcode.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxBarcode.Size = new System.Drawing.Size(430, 240);
            this.groupBoxBarcode.TabIndex = 9;
            this.groupBoxBarcode.TabStop = false;
            this.groupBoxBarcode.Text = "Ticket QR Code";
            //
            // pictureBoxBarcode
            //
            this.pictureBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBarcode.BackColor = System.Drawing.Color.White;
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(115, 40);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(200, 180);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarcode.TabIndex = 10;
            this.pictureBoxBarcode.TabStop = false;
            //
            // btnFinish
            //
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(30, 570);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(240, 50);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            //
            // panelTicket
            //
            this.panelTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTicket.BackColor = System.Drawing.Color.White;
            this.panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicket.Controls.Add(this.lblTicketCode);
            this.panelTicket.Controls.Add(this.panelTicketInfo);
            this.panelTicket.Controls.Add(this.groupBoxBarcode);
            this.panelTicket.Location = new System.Drawing.Point(65, 85);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(452, 450);
            this.panelTicket.TabIndex = 11;
            //
            // TicketDisplayForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "TicketDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Display";
            this.panelTicketInfo.ResumeLayout(false);
            this.panelTicketInfo.PerformLayout();
            this.groupBoxBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.panelTicket.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelTicket;
    }
}