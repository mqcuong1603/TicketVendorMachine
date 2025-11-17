namespace TicketVendorMachine.Forms
{
    partial class PaymentForm
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
            this.lblQRInstruction = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(147, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Payment Method";
            // 
            // lblQRInstruction
            // 
            this.lblQRInstruction.AutoSize = true;
            this.lblQRInstruction.Location = new System.Drawing.Point(147, 205);
            this.lblQRInstruction.Name = "lblQRInstruction";
            this.lblQRInstruction.Size = new System.Drawing.Size(19, 16);
            this.lblQRInstruction.TabIndex = 1;
            this.lblQRInstruction.Text = "qr";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(147, 104);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(80, 16);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(147, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.Blue;
            this.btnCreditCard.ForeColor = System.Drawing.Color.White;
            this.btnCreditCard.Location = new System.Drawing.Point(595, 78);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCard.TabIndex = 4;
            this.btnCreditCard.Text = "CREDIT CARD";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.Orange;
            this.btnQRCode.Location = new System.Drawing.Point(595, 138);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(75, 23);
            this.btnQRCode.TabIndex = 5;
            this.btnQRCode.Text = "QR CODE PAYMENT";
            this.btnQRCode.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(595, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQR.Location = new System.Drawing.Point(257, 104);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQR.TabIndex = 7;
            this.pictureBoxQR.TabStop = false;
            this.pictureBoxQR.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblQRInstruction);
            this.Controls.Add(this.lblTitle);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQRInstruction;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxQR;
    }
}