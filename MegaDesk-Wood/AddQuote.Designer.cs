namespace MegaDesk_Wood
{
    partial class AddQuote
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
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuoteDate = new System.Windows.Forms.Label();
            this.grpSelectMaterial = new System.Windows.Forms.GroupBox();
            this.cmbDeskMaterial = new System.Windows.Forms.ComboBox();
            this.grpCalArea = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.TextBox();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpQuoteInfo = new System.Windows.Forms.GroupBox();
            this.grpDrawers = new System.Windows.Forms.GroupBox();
            this.numDrawers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpRushDays = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.rd3Days = new System.Windows.Forms.RadioButton();
            this.rd5Days = new System.Windows.Forms.RadioButton();
            this.rd7Days = new System.Windows.Forms.RadioButton();
            this.rd14Days = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.grpRushDetails = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSubmitDisplayQuote = new System.Windows.Forms.Button();
            this.grpQuoteSummary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.grpSelectMaterial.SuspendLayout();
            this.grpCalArea.SuspendLayout();
            this.grpQuoteInfo.SuspendLayout();
            this.grpDrawers.SuspendLayout();
            this.grpRushDays.SuspendLayout();
            this.grpRushDetails.SuspendLayout();
            this.grpQuoteSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(629, 652);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(6, 22);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(72, 19);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Name:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(126, 19);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(203, 22);
            this.txtCustName.TabIndex = 0;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quote Date:";
            // 
            // lblQuoteDate
            // 
            this.lblQuoteDate.Location = new System.Drawing.Point(473, 19);
            this.lblQuoteDate.Name = "lblQuoteDate";
            this.lblQuoteDate.Size = new System.Drawing.Size(167, 22);
            this.lblQuoteDate.TabIndex = 5;
            this.lblQuoteDate.Text = "27 september 2020";
            this.lblQuoteDate.TextChanged += new System.EventHandler(this.lblQuoteDate_TextChanged);
            // 
            // grpSelectMaterial
            // 
            this.grpSelectMaterial.Controls.Add(this.cmbDeskMaterial);
            this.grpSelectMaterial.Location = new System.Drawing.Point(29, 357);
            this.grpSelectMaterial.Name = "grpSelectMaterial";
            this.grpSelectMaterial.Size = new System.Drawing.Size(335, 77);
            this.grpSelectMaterial.TabIndex = 4;
            this.grpSelectMaterial.TabStop = false;
            this.grpSelectMaterial.Text = "Select Material";
            // 
            // cmbDeskMaterial
            // 
            this.cmbDeskMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeskMaterial.FormattingEnabled = true;
            this.cmbDeskMaterial.Location = new System.Drawing.Point(126, 31);
            this.cmbDeskMaterial.Name = "cmbDeskMaterial";
            this.cmbDeskMaterial.Size = new System.Drawing.Size(203, 24);
            this.cmbDeskMaterial.TabIndex = 1;
            this.cmbDeskMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbDeskMaterial_SelectedIndexChanged);
            // 
            // grpCalArea
            // 
            this.grpCalArea.Controls.Add(this.label7);
            this.grpCalArea.Controls.Add(this.numDepth);
            this.grpCalArea.Controls.Add(this.label6);
            this.grpCalArea.Controls.Add(this.numWidth);
            this.grpCalArea.Controls.Add(this.lblSurfaceArea);
            this.grpCalArea.Controls.Add(this.label4);
            this.grpCalArea.Controls.Add(this.label3);
            this.grpCalArea.Controls.Add(this.label2);
            this.grpCalArea.Location = new System.Drawing.Point(29, 82);
            this.grpCalArea.Name = "grpCalArea";
            this.grpCalArea.Size = new System.Drawing.Size(335, 189);
            this.grpCalArea.TabIndex = 2;
            this.grpCalArea.TabStop = false;
            this.grpCalArea.Text = "Calculate Area";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(136, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "(min 12\", max 48\")";
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(125, 94);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(203, 22);
            this.numDepth.TabIndex = 19;
            this.numDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDepth.TextChanged += new System.EventHandler(this.numDepth_TextChanged);
            this.numDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDepth_KeyPress);
            this.numDepth.Validating += new System.ComponentModel.CancelEventHandler(this.numDepth_Validating);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(136, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "(min 24\", max 96\")";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(125, 29);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(203, 22);
            this.numWidth.TabIndex = 18;
            this.numWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWidth.TextChanged += new System.EventHandler(this.numWidth_TextChanged);
            this.numWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numWidth_KeyPress);
            this.numWidth.Validating += new System.ComponentModel.CancelEventHandler(this.numWidth_Validating);
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceArea.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSurfaceArea.Location = new System.Drawing.Point(193, 157);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(92, 25);
            this.lblSurfaceArea.TabIndex = 4;
            this.lblSurfaceArea.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surface Area (sq. inches):";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth (Inches):";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width (Inches):";
            // 
            // grpQuoteInfo
            // 
            this.grpQuoteInfo.Controls.Add(this.lblCustName);
            this.grpQuoteInfo.Controls.Add(this.txtCustName);
            this.grpQuoteInfo.Controls.Add(this.label1);
            this.grpQuoteInfo.Controls.Add(this.lblQuoteDate);
            this.grpQuoteInfo.Location = new System.Drawing.Point(28, 23);
            this.grpQuoteInfo.Name = "grpQuoteInfo";
            this.grpQuoteInfo.Size = new System.Drawing.Size(678, 53);
            this.grpQuoteInfo.TabIndex = 1;
            this.grpQuoteInfo.TabStop = false;
            this.grpQuoteInfo.Text = "Customer";
            // 
            // grpDrawers
            // 
            this.grpDrawers.Controls.Add(this.numDrawers);
            this.grpDrawers.Controls.Add(this.label8);
            this.grpDrawers.Location = new System.Drawing.Point(29, 277);
            this.grpDrawers.Name = "grpDrawers";
            this.grpDrawers.Size = new System.Drawing.Size(334, 74);
            this.grpDrawers.TabIndex = 3;
            this.grpDrawers.TabStop = false;
            this.grpDrawers.Text = "How Many Drawers?";
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(125, 30);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(203, 22);
            this.numDrawers.TabIndex = 20;
            this.numDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDrawers.TextChanged += new System.EventHandler(this.numDrawers_TextChanged);
            this.numDrawers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDrawers_KeyPress);
            this.numDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.numDrawers_Validating);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Select 0 to 7:  ";
            // 
            // grpRushDays
            // 
            this.grpRushDays.Controls.Add(this.label38);
            this.grpRushDays.Controls.Add(this.rd3Days);
            this.grpRushDays.Controls.Add(this.rd5Days);
            this.grpRushDays.Controls.Add(this.rd7Days);
            this.grpRushDays.Controls.Add(this.rd14Days);
            this.grpRushDays.Location = new System.Drawing.Point(29, 440);
            this.grpRushDays.Name = "grpRushDays";
            this.grpRushDays.Size = new System.Drawing.Size(334, 188);
            this.grpRushDays.TabIndex = 5;
            this.grpRushDays.TabStop = false;
            this.grpRushDays.Text = "How Soon?";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(6, 154);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(206, 24);
            this.label38.TabIndex = 21;
            this.label38.Text = "* See Additional Rush Cost";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rd3Days
            // 
            this.rd3Days.AutoSize = true;
            this.rd3Days.Location = new System.Drawing.Point(8, 112);
            this.rd3Days.Name = "rd3Days";
            this.rd3Days.Size = new System.Drawing.Size(82, 21);
            this.rd3Days.TabIndex = 4;
            this.rd3Days.TabStop = true;
            this.rd3Days.Text = "3 Days *";
            this.rd3Days.UseVisualStyleBackColor = true;
            this.rd3Days.CheckedChanged += new System.EventHandler(this.rd3Days_CheckedChanged);
            // 
            // rd5Days
            // 
            this.rd5Days.AutoSize = true;
            this.rd5Days.Location = new System.Drawing.Point(8, 85);
            this.rd5Days.Name = "rd5Days";
            this.rd5Days.Size = new System.Drawing.Size(82, 21);
            this.rd5Days.TabIndex = 3;
            this.rd5Days.TabStop = true;
            this.rd5Days.Text = "5 Days *";
            this.rd5Days.UseVisualStyleBackColor = true;
            this.rd5Days.CheckedChanged += new System.EventHandler(this.rd5Days_CheckedChanged);
            // 
            // rd7Days
            // 
            this.rd7Days.AutoSize = true;
            this.rd7Days.Location = new System.Drawing.Point(8, 58);
            this.rd7Days.Name = "rd7Days";
            this.rd7Days.Size = new System.Drawing.Size(82, 21);
            this.rd7Days.TabIndex = 2;
            this.rd7Days.TabStop = true;
            this.rd7Days.Text = "7 Days *";
            this.rd7Days.UseVisualStyleBackColor = true;
            this.rd7Days.CheckedChanged += new System.EventHandler(this.rd7Days_CheckedChanged);
            // 
            // rd14Days
            // 
            this.rd14Days.AutoSize = true;
            this.rd14Days.Location = new System.Drawing.Point(8, 31);
            this.rd14Days.Name = "rd14Days";
            this.rd14Days.Size = new System.Drawing.Size(153, 21);
            this.rd14Days.TabIndex = 1;
            this.rd14Days.TabStop = true;
            this.rd14Days.Text = "14 Days (Standard)";
            this.rd14Days.UseVisualStyleBackColor = true;
            this.rd14Days.CheckedChanged += new System.EventHandler(this.rd14Days_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "3 Days";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "5 Days";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "7 Days";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 39);
            this.label12.TabIndex = 8;
            this.label12.Text = "Less than 1000";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(93, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 22);
            this.label15.TabIndex = 11;
            this.label15.Text = "$60";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(93, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 22);
            this.label16.TabIndex = 12;
            this.label16.Text = "$40";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(93, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 22);
            this.label17.TabIndex = 13;
            this.label17.Text = "$30";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(144, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "1000 to 2000";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 39);
            this.label14.TabIndex = 21;
            this.label14.Text = "Greater than 2000";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(8, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 22);
            this.label24.TabIndex = 22;
            this.label24.Text = "Inches Sq.";
            // 
            // grpRushDetails
            // 
            this.grpRushDetails.Controls.Add(this.label37);
            this.grpRushDetails.Controls.Add(this.label21);
            this.grpRushDetails.Controls.Add(this.label22);
            this.grpRushDetails.Controls.Add(this.label23);
            this.grpRushDetails.Controls.Add(this.label18);
            this.grpRushDetails.Controls.Add(this.label19);
            this.grpRushDetails.Controls.Add(this.label20);
            this.grpRushDetails.Controls.Add(this.label24);
            this.grpRushDetails.Controls.Add(this.label14);
            this.grpRushDetails.Controls.Add(this.label13);
            this.grpRushDetails.Controls.Add(this.label17);
            this.grpRushDetails.Controls.Add(this.label16);
            this.grpRushDetails.Controls.Add(this.label15);
            this.grpRushDetails.Controls.Add(this.label12);
            this.grpRushDetails.Controls.Add(this.label11);
            this.grpRushDetails.Controls.Add(this.label10);
            this.grpRushDetails.Controls.Add(this.label9);
            this.grpRushDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRushDetails.Location = new System.Drawing.Point(387, 440);
            this.grpRushDetails.Name = "grpRushDetails";
            this.grpRushDetails.Size = new System.Drawing.Size(335, 188);
            this.grpRushDetails.TabIndex = 11;
            this.grpRushDetails.TabStop = false;
            this.grpRushDetails.Text = "* Additional Rush Costs";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(8, 69);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(320, 19);
            this.label37.TabIndex = 14;
            this.label37.Text = "----------------------------------------------------------------------------";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(266, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 22);
            this.label21.TabIndex = 28;
            this.label21.Text = "$40";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(266, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 22);
            this.label22.TabIndex = 27;
            this.label22.Text = "$60";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(266, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 22);
            this.label23.TabIndex = 26;
            this.label23.Text = "$80";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(176, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 22);
            this.label18.TabIndex = 25;
            this.label18.Text = "$35";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(176, 124);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 22);
            this.label19.TabIndex = 24;
            this.label19.Text = "$50";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(176, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 22);
            this.label20.TabIndex = 23;
            this.label20.Text = "$70";
            // 
            // btnSubmitDisplayQuote
            // 
            this.btnSubmitDisplayQuote.Location = new System.Drawing.Point(457, 652);
            this.btnSubmitDisplayQuote.Name = "btnSubmitDisplayQuote";
            this.btnSubmitDisplayQuote.Size = new System.Drawing.Size(141, 30);
            this.btnSubmitDisplayQuote.TabIndex = 6;
            this.btnSubmitDisplayQuote.Text = "Display Quote";
            this.btnSubmitDisplayQuote.UseVisualStyleBackColor = true;
            this.btnSubmitDisplayQuote.Click += new System.EventHandler(this.btnSubmitDisplayQuote_Click);
            // 
            // grpQuoteSummary
            // 
            this.grpQuoteSummary.Controls.Add(this.label5);
            this.grpQuoteSummary.Controls.Add(this.label36);
            this.grpQuoteSummary.Controls.Add(this.label35);
            this.grpQuoteSummary.Controls.Add(this.label34);
            this.grpQuoteSummary.Controls.Add(this.label33);
            this.grpQuoteSummary.Controls.Add(this.label32);
            this.grpQuoteSummary.Controls.Add(this.label31);
            this.grpQuoteSummary.Controls.Add(this.label30);
            this.grpQuoteSummary.Controls.Add(this.label29);
            this.grpQuoteSummary.Controls.Add(this.label28);
            this.grpQuoteSummary.Controls.Add(this.label27);
            this.grpQuoteSummary.Controls.Add(this.label26);
            this.grpQuoteSummary.Controls.Add(this.label25);
            this.grpQuoteSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpQuoteSummary.Location = new System.Drawing.Point(387, 82);
            this.grpQuoteSummary.Name = "grpQuoteSummary";
            this.grpQuoteSummary.Size = new System.Drawing.Size(335, 352);
            this.grpQuoteSummary.TabIndex = 13;
            this.grpQuoteSummary.TabStop = false;
            this.grpQuoteSummary.Text = "Quote Summary";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "----------------------------------------------------------------------------";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Green;
            this.label36.Location = new System.Drawing.Point(181, 309);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(92, 25);
            this.label36.TabIndex = 12;
            this.label36.Text = "0";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Blue;
            this.label35.Location = new System.Drawing.Point(181, 247);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 25);
            this.label35.TabIndex = 11;
            this.label35.Text = "0";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Blue;
            this.label34.Location = new System.Drawing.Point(181, 191);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 25);
            this.label34.TabIndex = 10;
            this.label34.Text = "0";
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Blue;
            this.label33.Location = new System.Drawing.Point(181, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 25);
            this.label33.TabIndex = 9;
            this.label33.Text = "0";
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Blue;
            this.label32.Location = new System.Drawing.Point(181, 83);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(92, 25);
            this.label32.TabIndex = 8;
            this.label32.Text = "0";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Blue;
            this.label31.Location = new System.Drawing.Point(181, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 25);
            this.label31.TabIndex = 7;
            this.label31.Text = "0";
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(6, 309);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(169, 20);
            this.label30.TabIndex = 6;
            this.label30.Text = "Sub Total:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(7, 247);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(169, 20);
            this.label29.TabIndex = 5;
            this.label29.Text = "Shipping:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(6, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(169, 20);
            this.label28.TabIndex = 4;
            this.label28.Text = "Drawers Cost:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(7, 136);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(169, 20);
            this.label27.TabIndex = 3;
            this.label27.Text = "Material Cost:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(7, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(169, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "Surface Area Upgrade:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(10, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(165, 19);
            this.label25.TabIndex = 1;
            this.label25.Text = "Base Cost:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.Location = new System.Drawing.Point(34, 650);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(228, 42);
            this.btnSaveQuote.TabIndex = 14;
            this.btnSaveQuote.Text = "Save Quote (**Test**, BW)";
            this.btnSaveQuote.UseVisualStyleBackColor = true;
            this.btnSaveQuote.Click += new System.EventHandler(this.btnSaveQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 705);
            this.Controls.Add(this.btnSaveQuote);
            this.Controls.Add(this.grpQuoteSummary);
            this.Controls.Add(this.btnSubmitDisplayQuote);
            this.Controls.Add(this.grpRushDetails);
            this.Controls.Add(this.grpRushDays);
            this.Controls.Add(this.grpDrawers);
            this.Controls.Add(this.grpQuoteInfo);
            this.Controls.Add(this.grpCalArea);
            this.Controls.Add(this.grpSelectMaterial);
            this.Controls.Add(this.btnClose);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.grpSelectMaterial.ResumeLayout(false);
            this.grpCalArea.ResumeLayout(false);
            this.grpCalArea.PerformLayout();
            this.grpQuoteInfo.ResumeLayout(false);
            this.grpQuoteInfo.PerformLayout();
            this.grpDrawers.ResumeLayout(false);
            this.grpDrawers.PerformLayout();
            this.grpRushDays.ResumeLayout(false);
            this.grpRushDays.PerformLayout();
            this.grpRushDetails.ResumeLayout(false);
            this.grpQuoteSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuoteDate;
        private System.Windows.Forms.GroupBox grpSelectMaterial;
        private System.Windows.Forms.ComboBox cmbDeskMaterial;
        private System.Windows.Forms.GroupBox grpCalArea;
        private System.Windows.Forms.GroupBox grpQuoteInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDrawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpRushDays;
        private System.Windows.Forms.RadioButton rd3Days;
        private System.Windows.Forms.RadioButton rd5Days;
        private System.Windows.Forms.RadioButton rd7Days;
        private System.Windows.Forms.RadioButton rd14Days;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpRushDetails;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSubmitDisplayQuote;
        private System.Windows.Forms.GroupBox grpQuoteSummary;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox numDepth;
        private System.Windows.Forms.TextBox numWidth;
        private System.Windows.Forms.TextBox numDrawers;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveQuote;
    }
}