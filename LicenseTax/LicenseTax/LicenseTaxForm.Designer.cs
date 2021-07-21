
namespace LicenseTax
{
    partial class LicenseTaxForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseTaxForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtnAnnual = new System.Windows.Forms.RadioButton();
            this.rbtnPeriod = new System.Windows.Forms.RadioButton();
            this.cbxUsage = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelTimePicker = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTimePicker.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(234, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用牌照稅應納稅額試算";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(71, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "貼心小叮嚀：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(71, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(771, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. 本表試算之稅額僅供參考之用，不做任何證明，實際應納稅額仍應以稽徵機關核定為準。";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(3, 19);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(71, 145);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(378, 30);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2. 使用牌照稅稅額對照表及電動車應納稅額表";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel1, "新北市政府稅捐稽徵處 - 稅率及計算公式");
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 194);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "使用期間";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "用途";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "汽缸CC數／馬達馬力";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "試算結果";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbtnAnnual
            // 
            this.rbtnAnnual.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.rbtnAnnual.AutoSize = true;
            this.rbtnAnnual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnAnnual.Location = new System.Drawing.Point(287, 34);
            this.rbtnAnnual.Name = "rbtnAnnual";
            this.rbtnAnnual.Size = new System.Drawing.Size(88, 28);
            this.rbtnAnnual.TabIndex = 9;
            this.rbtnAnnual.TabStop = true;
            this.rbtnAnnual.Text = "全年度";
            this.rbtnAnnual.UseVisualStyleBackColor = false;
            this.rbtnAnnual.CheckedChanged += new System.EventHandler(this.rbtnAnnual_CheckedChanged);
            // 
            // rbtnPeriod
            // 
            this.rbtnPeriod.AutoSize = true;
            this.rbtnPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnPeriod.Location = new System.Drawing.Point(440, 34);
            this.rbtnPeriod.Name = "rbtnPeriod";
            this.rbtnPeriod.Size = new System.Drawing.Size(88, 28);
            this.rbtnPeriod.TabIndex = 10;
            this.rbtnPeriod.TabStop = true;
            this.rbtnPeriod.Text = "依期間";
            this.rbtnPeriod.UseVisualStyleBackColor = false;
            this.rbtnPeriod.CheckedChanged += new System.EventHandler(this.rbtnPeriod_CheckedChanged);
            // 
            // cbxUsage
            // 
            this.cbxUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsage.FormattingEnabled = true;
            this.cbxUsage.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxUsage.Location = new System.Drawing.Point(283, 103);
            this.cbxUsage.Name = "cbxUsage";
            this.cbxUsage.Size = new System.Drawing.Size(313, 31);
            this.cbxUsage.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cbxUsage, "請選擇車種");
            this.cbxUsage.SelectedIndexChanged += new System.EventHandler(this.cbxUsage_SelectedIndexChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "150以下 / 12HP以下(12.2PS以下)",
            "151-250 / 12.1-20HP(12.3-20.3PS)",
            "251-500 / 20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.cbxCategory.Location = new System.Drawing.Point(283, 183);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(313, 31);
            this.cbxCategory.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cbxCategory, "請選擇汽缸CC數或是馬達馬力");
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(38, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(18, 24);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "-";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.btnCalculate.FlatAppearance.BorderSize = 2;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.btnCalculate.Location = new System.Drawing.Point(222, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(174, 46);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "確定送出";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.btnReset.Location = new System.Drawing.Point(561, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 46);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(43, 11);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFrom.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(127, 31);
            this.dateTimePickerFrom.TabIndex = 16;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerUntil
            // 
            this.dateTimePickerUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUntil.Location = new System.Drawing.Point(211, 12);
            this.dateTimePickerUntil.Name = "dateTimePickerUntil";
            this.dateTimePickerUntil.Size = new System.Drawing.Size(129, 31);
            this.dateTimePickerUntil.TabIndex = 17;
            this.dateTimePickerUntil.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "從";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "至";
            // 
            // panelTimePicker
            // 
            this.panelTimePicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTimePicker.Controls.Add(this.label9);
            this.panelTimePicker.Controls.Add(this.label8);
            this.panelTimePicker.Controls.Add(this.dateTimePickerUntil);
            this.panelTimePicker.Controls.Add(this.dateTimePickerFrom);
            this.panelTimePicker.Location = new System.Drawing.Point(530, 19);
            this.panelTimePicker.Name = "panelTimePicker";
            this.panelTimePicker.Size = new System.Drawing.Size(356, 49);
            this.panelTimePicker.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(7, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 68);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(2, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 68);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(7, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 68);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(2, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 68);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(7, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 68);
            this.panel6.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(111)))), ((int)(((byte)(122)))));
            this.panel7.Location = new System.Drawing.Point(2, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 68);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Location = new System.Drawing.Point(240, 11);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(680, 68);
            this.panel8.TabIndex = 24;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Location = new System.Drawing.Point(240, 159);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(680, 68);
            this.panel9.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(7, 321);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(227, 187);
            this.panel10.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.AutoScroll = true;
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Controls.Add(this.lblResult);
            this.panel11.Location = new System.Drawing.Point(241, 321);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(678, 187);
            this.panel11.TabIndex = 27;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel11);
            this.panel12.Controls.Add(this.panel10);
            this.panel12.Controls.Add(this.panelTimePicker);
            this.panel12.Controls.Add(this.btnReset);
            this.panel12.Controls.Add(this.btnCalculate);
            this.panel12.Controls.Add(this.cbxCategory);
            this.panel12.Controls.Add(this.cbxUsage);
            this.panel12.Controls.Add(this.rbtnPeriod);
            this.panel12.Controls.Add(this.rbtnAnnual);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(this.panel2);
            this.panel12.Controls.Add(this.panel4);
            this.panel12.Controls.Add(this.panel6);
            this.panel12.Controls.Add(this.panel8);
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Location = new System.Drawing.Point(10, 216);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(929, 519);
            this.panel12.TabIndex = 28;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Controls.Add(this.panel1);
            this.panel13.Location = new System.Drawing.Point(83, 12);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(949, 746);
            this.panel13.TabIndex = 29;
            // 
            // LicenseTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1113, 785);
            this.Controls.Add(this.panel13);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LicenseTaxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用牌照稅應納稅額試算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTimePicker.ResumeLayout(false);
            this.panelTimePicker.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnAnnual;
        private System.Windows.Forms.RadioButton rbtnPeriod;
        private System.Windows.Forms.ComboBox cbxUsage;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerUntil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}