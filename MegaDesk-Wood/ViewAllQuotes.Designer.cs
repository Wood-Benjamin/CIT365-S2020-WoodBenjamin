namespace MegaDesk_Wood
{
    partial class ViewAllQuotes
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpViewAllQuotes = new System.Windows.Forms.GroupBox();
            this.dataGridViewAllQuotes = new System.Windows.Forms.DataGridView();
            this.grpViewAllQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(815, 345);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpViewAllQuotes
            // 
            this.grpViewAllQuotes.Controls.Add(this.dataGridViewAllQuotes);
            this.grpViewAllQuotes.Location = new System.Drawing.Point(9, 10);
            this.grpViewAllQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpViewAllQuotes.Name = "grpViewAllQuotes";
            this.grpViewAllQuotes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpViewAllQuotes.Size = new System.Drawing.Size(883, 331);
            this.grpViewAllQuotes.TabIndex = 2;
            this.grpViewAllQuotes.TabStop = false;
            this.grpViewAllQuotes.Text = "View All Quotes";
            this.grpViewAllQuotes.Enter += new System.EventHandler(this.grpViewAllQuotes_Enter);
            // 
            // dataGridViewAllQuotes
            // 
            this.dataGridViewAllQuotes.AllowUserToOrderColumns = true;
            this.dataGridViewAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllQuotes.Location = new System.Drawing.Point(11, 24);
            this.dataGridViewAllQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAllQuotes.Name = "dataGridViewAllQuotes";
            this.dataGridViewAllQuotes.RowHeadersWidth = 51;
            this.dataGridViewAllQuotes.RowTemplate.Height = 24;
            this.dataGridViewAllQuotes.Size = new System.Drawing.Size(863, 297);
            this.dataGridViewAllQuotes.TabIndex = 0;
            this.dataGridViewAllQuotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllQuotes_CellContentClick);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 377);
            this.Controls.Add(this.grpViewAllQuotes);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.grpViewAllQuotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpViewAllQuotes;
        private System.Windows.Forms.DataGridView dataGridViewAllQuotes;
    }
}