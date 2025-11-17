namespace TicketVendorMachine.Forms
{
    partial class DestinationSelectionForm
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
            this.listBoxDestinations = new System.Windows.Forms.ListBox();
            this.lblSelectedDestination = new System.Windows.Forms.Label();
            this.lblSelectedPrice = new System.Windows.Forms.Label();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Your Destination";
            // 
            // listBoxDestinations
            // 
            this.listBoxDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDestinations.FormattingEnabled = true;
            this.listBoxDestinations.ItemHeight = 25;
            this.listBoxDestinations.Location = new System.Drawing.Point(182, 82);
            this.listBoxDestinations.Name = "listBoxDestinations";
            this.listBoxDestinations.Size = new System.Drawing.Size(400, 279);
            this.listBoxDestinations.TabIndex = 1;
            this.listBoxDestinations.SelectedIndexChanged += new System.EventHandler(this.listBoxDestinations_SelectedIndexChanged);
            // 
            // lblSelectedDestination
            // 
            this.lblSelectedDestination.AutoSize = true;
            this.lblSelectedDestination.Location = new System.Drawing.Point(65, 210);
            this.lblSelectedDestination.Name = "lblSelectedDestination";
            this.lblSelectedDestination.Size = new System.Drawing.Size(100, 16);
            this.lblSelectedDestination.TabIndex = 2;
            this.lblSelectedDestination.Text = "Selected: None";
            // 
            // lblSelectedPrice
            // 
            this.lblSelectedPrice.AutoSize = true;
            this.lblSelectedPrice.Location = new System.Drawing.Point(65, 239);
            this.lblSelectedPrice.Name = "lblSelectedPrice";
            this.lblSelectedPrice.Size = new System.Drawing.Size(83, 16);
            this.lblSelectedPrice.TabIndex = 3;
            this.lblSelectedPrice.Text = "Price: 0 VND";
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.BackColor = System.Drawing.Color.Blue;
            this.btnSelectDestination.ForeColor = System.Drawing.Color.White;
            this.btnSelectDestination.Location = new System.Drawing.Point(600, 116);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(200, 50);
            this.btnSelectDestination.TabIndex = 4;
            this.btnSelectDestination.Text = "SELECT DESTINATION";
            this.btnSelectDestination.UseVisualStyleBackColor = false;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(600, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DestinationSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.lblSelectedPrice);
            this.Controls.Add(this.lblSelectedDestination);
            this.Controls.Add(this.listBoxDestinations);
            this.Controls.Add(this.lblTitle);
            this.Name = "DestinationSelectionForm";
            this.Text = "DestinationSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox listBoxDestinations;
        private System.Windows.Forms.Label lblSelectedDestination;
        private System.Windows.Forms.Label lblSelectedPrice;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Button btnBack;
    }
}