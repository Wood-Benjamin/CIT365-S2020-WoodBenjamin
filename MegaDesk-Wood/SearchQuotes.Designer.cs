namespace MegaDesk_Wood
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.dataGridSearchQuotes = new System.Windows.Forms.DataGridView();
            this.grpSearchQuotes = new System.Windows.Forms.GroupBox();
            this.cmbSearchMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchQuotes)).BeginInit();
            this.grpSearchQuotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(633, 340);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCloseSearch.Location = new System.Drawing.Point(1029, 427);
            this.btnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(157, 54);
            this.btnCloseSearch.TabIndex = 3;
            this.btnCloseSearch.Text = "Close";
            this.btnCloseSearch.UseVisualStyleBackColor = true;
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click);
            // 
            // dataGridSearchQuotes
            // 
            this.dataGridSearchQuotes.AllowUserToOrderColumns = true;
            this.dataGridSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchQuotes.Location = new System.Drawing.Point(5, 71);
            this.dataGridSearchQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSearchQuotes.Name = "dataGridSearchQuotes";
            this.dataGridSearchQuotes.RowHeadersWidth = 51;
            this.dataGridSearchQuotes.RowTemplate.Height = 24;
            this.dataGridSearchQuotes.Size = new System.Drawing.Size(1165, 316);
            this.dataGridSearchQuotes.TabIndex = 0;
            // 
            // grpSearchQuotes
            // 
            this.grpSearchQuotes.BackColor = System.Drawing.Color.Transparent;
            this.grpSearchQuotes.Controls.Add(this.cmbSearchMaterial);
            this.grpSearchQuotes.Controls.Add(this.label1);
            this.grpSearchQuotes.Controls.Add(this.dataGridSearchQuotes);
            this.grpSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.grpSearchQuotes.Location = new System.Drawing.Point(16, 18);
            this.grpSearchQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearchQuotes.Name = "grpSearchQuotes";
            this.grpSearchQuotes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearchQuotes.Size = new System.Drawing.Size(1177, 402);
            this.grpSearchQuotes.TabIndex = 4;
            this.grpSearchQuotes.TabStop = false;
            this.grpSearchQuotes.Text = "Search Quotes";
            // 
            // cmbSearchMaterial
            // 
            this.cmbSearchMaterial.FormattingEnabled = true;
            this.cmbSearchMaterial.Location = new System.Drawing.Point(285, 28);
            this.cmbSearchMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSearchMaterial.Name = "cmbSearchMaterial";
            this.cmbSearchMaterial.Size = new System.Drawing.Size(160, 30);
            this.cmbSearchMaterial.TabIndex = 2;
            this.cmbSearchMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMaterial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Quotes by Material: ";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Wood.Properties.Resources.displayBackgroundOverLayLong;
            this.ClientSize = new System.Drawing.Size(1204, 490);
            this.Controls.Add(this.btnCloseSearch);
            this.Controls.Add(this.grpSearchQuotes);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchQuotes)).EndInit();
            this.grpSearchQuotes.ResumeLayout(false);
            this.grpSearchQuotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.DataGridView dataGridSearchQuotes;
        private System.Windows.Forms.GroupBox grpSearchQuotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchMaterial;
    }
}