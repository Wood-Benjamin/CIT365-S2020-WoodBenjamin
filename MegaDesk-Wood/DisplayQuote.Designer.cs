namespace MegaDesk_Wood
{
    partial class DisplayQuote
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
            this.btnCancelQuote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuoteDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSurfaceMaterial = new System.Windows.Forms.Label();
            this.lblDrawerCount = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lbldeliveryTime = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblRushCost = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblAreaCost = new System.Windows.Forms.Label();
            this.lblBaseCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelQuote
            // 
            this.btnCancelQuote.Location = new System.Drawing.Point(303, 431);
            this.btnCancelQuote.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelQuote.Name = "btnCancelQuote";
            this.btnCancelQuote.Size = new System.Drawing.Size(118, 44);
            this.btnCancelQuote.TabIndex = 1;
            this.btnCancelQuote.Text = "Cancel Quote";
            this.btnCancelQuote.UseVisualStyleBackColor = true;
            this.btnCancelQuote.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuoteDate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblQuoteDate
            // 
            this.lblQuoteDate.AutoSize = true;
            this.lblQuoteDate.Location = new System.Drawing.Point(335, 19);
            this.lblQuoteDate.Name = "lblQuoteDate";
            this.lblQuoteDate.Size = new System.Drawing.Size(51, 16);
            this.lblQuoteDate.TabIndex = 1;
            this.lblQuoteDate.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSurfaceMaterial);
            this.groupBox2.Controls.Add(this.lblDrawerCount);
            this.groupBox2.Controls.Add(this.lblDepth);
            this.groupBox2.Controls.Add(this.lblWidth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desk Specifications";
            // 
            // lblSurfaceMaterial
            // 
            this.lblSurfaceMaterial.AutoSize = true;
            this.lblSurfaceMaterial.Location = new System.Drawing.Point(25, 136);
            this.lblSurfaceMaterial.Name = "lblSurfaceMaterial";
            this.lblSurfaceMaterial.Size = new System.Drawing.Size(46, 18);
            this.lblSurfaceMaterial.TabIndex = 3;
            this.lblSurfaceMaterial.Text = "label4";
            // 
            // lblDrawerCount
            // 
            this.lblDrawerCount.AutoSize = true;
            this.lblDrawerCount.Location = new System.Drawing.Point(24, 95);
            this.lblDrawerCount.Name = "lblDrawerCount";
            this.lblDrawerCount.Size = new System.Drawing.Size(46, 18);
            this.lblDrawerCount.TabIndex = 2;
            this.lblDrawerCount.Text = "label3";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(25, 64);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(46, 18);
            this.lblDepth.TabIndex = 1;
            this.lblDepth.Text = "label2";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(22, 34);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 18);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDeliveryDate);
            this.groupBox3.Controls.Add(this.lbldeliveryTime);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Delivery";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(23, 50);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(46, 18);
            this.lblDeliveryDate.TabIndex = 6;
            this.lblDeliveryDate.Text = "label1";
            // 
            // lbldeliveryTime
            // 
            this.lbldeliveryTime.AutoSize = true;
            this.lbldeliveryTime.Location = new System.Drawing.Point(20, 25);
            this.lbldeliveryTime.Name = "lbldeliveryTime";
            this.lbldeliveryTime.Size = new System.Drawing.Size(46, 18);
            this.lbldeliveryTime.TabIndex = 5;
            this.lbldeliveryTime.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDrawerCost);
            this.groupBox4.Controls.Add(this.lblRushCost);
            this.groupBox4.Controls.Add(this.lblMaterialCost);
            this.groupBox4.Controls.Add(this.lblAreaCost);
            this.groupBox4.Controls.Add(this.lblBaseCost);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(273, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 254);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detailed Cost Breakdown";
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.AutoSize = true;
            this.lblDrawerCost.Location = new System.Drawing.Point(27, 177);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(46, 18);
            this.lblDrawerCost.TabIndex = 4;
            this.lblDrawerCost.Text = "label5";
            // 
            // lblRushCost
            // 
            this.lblRushCost.AutoSize = true;
            this.lblRushCost.Location = new System.Drawing.Point(27, 228);
            this.lblRushCost.Name = "lblRushCost";
            this.lblRushCost.Size = new System.Drawing.Size(46, 18);
            this.lblRushCost.TabIndex = 3;
            this.lblRushCost.Text = "label4";
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.AutoSize = true;
            this.lblMaterialCost.Location = new System.Drawing.Point(27, 131);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Size = new System.Drawing.Size(46, 18);
            this.lblMaterialCost.TabIndex = 2;
            this.lblMaterialCost.Text = "label3";
            // 
            // lblAreaCost
            // 
            this.lblAreaCost.AutoSize = true;
            this.lblAreaCost.Location = new System.Drawing.Point(27, 81);
            this.lblAreaCost.Name = "lblAreaCost";
            this.lblAreaCost.Size = new System.Drawing.Size(46, 18);
            this.lblAreaCost.TabIndex = 1;
            this.lblAreaCost.Text = "label2";
            // 
            // lblBaseCost
            // 
            this.lblBaseCost.AutoSize = true;
            this.lblBaseCost.Location = new System.Drawing.Point(27, 39);
            this.lblBaseCost.Name = "lblBaseCost";
            this.lblBaseCost.Size = new System.Drawing.Size(46, 18);
            this.lblBaseCost.TabIndex = 0;
            this.lblBaseCost.Text = "label1";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(309, 372);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(52, 18);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "label1";
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.Location = new System.Drawing.Point(47, 431);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(126, 44);
            this.btnSaveQuote.TabIndex = 7;
            this.btnSaveQuote.Text = "Save Quote";
            this.btnSaveQuote.UseVisualStyleBackColor = true;
            this.btnSaveQuote.Click += new System.EventHandler(this.btnSaveQuote_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 578);
            this.Controls.Add(this.btnSaveQuote);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelQuote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelQuote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuoteDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSurfaceMaterial;
        private System.Windows.Forms.Label lblDrawerCount;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbldeliveryTime;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDrawerCost;
        private System.Windows.Forms.Label lblRushCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblAreaCost;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnSaveQuote;
    }
}