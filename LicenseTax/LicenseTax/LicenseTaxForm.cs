using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseTax
{
    public partial class LicenseTaxForm : Form
    {
        public LicenseTaxForm()
        {
            InitializeComponent();
        }
        //超連結
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tax.ntpc.gov.tw/cp-1017-1707-f8b26-1.html");
        }

        #region 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        #region 月曆隱藏
        private void rbtnAnnual_CheckedChanged(object sender, EventArgs e)
        {
            this.panelTimePicker.Visible = false;
        }
        private void rbtnPeriod_CheckedChanged(object sender, EventArgs e)
        {
            this.panelTimePicker.Visible = true;
        }
        #endregion

        #region 按鍵變色
        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.FromArgb(7, 111, 122);
            btnCalculate.ForeColor = Color.White;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
            btnCalculate.ForeColor = Color.FromArgb(7, 111, 122);
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(7, 111, 122);
            btnReset.ForeColor = Color.White;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.FromArgb(7, 111, 122);
        }
        #endregion

        #endregion

        #region 試算結果
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int Tax = this.GetTaxPercentage();

            //計算天數
            DateTime df = dateTimePickerFrom.Value;
            DateTime du = dateTimePickerUntil.Value;
            TimeSpan daysDiff = du - df;

            //提示訊息
            while (du < df)
            {
                MessageBox.Show("使用期間的起始日期不可大於結束日期", "小提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };

            //辨別是否為閏年
            int yearSrc = dateTimePickerFrom.Value.Year;
            int yearType;

            if (yearSrc % 4 == 0 && yearSrc % 100 != 0 || yearSrc % 400 == 0)
            {
                yearType = 366;
            }
            else
            {
                yearType = 365;
            }

            int fy = dateTimePickerFrom.Value.Year;
            int fm = dateTimePickerFrom.Value.Month;
            int fd = dateTimePickerFrom.Value.Day;
            int uy = dateTimePickerUntil.Value.Year;
            int um = dateTimePickerUntil.Value.Month;
            int ud = dateTimePickerUntil.Value.Day;

            int CalDays = daysDiff.Days + 1;
            int Result = Tax * CalDays / yearType;


            if (CalDays <= 366)
            {
                this.lblResult.Text = $"使用期間：{fy}/{fm}/{fd} ～ {uy}/{um}/{ud}" + Environment.NewLine +
                    $"計算天數：{CalDays}天" + Environment.NewLine +
                    $"汽缸CC數：{cbxCategory.SelectedItem}" + Environment.NewLine +
                    $"用途：{cbxUsage.SelectedItem}" + Environment.NewLine +
                    $"計算公式：{Tax}*{CalDays} / {yearType} = {Result}元" + Environment.NewLine +
                    $"應繳稅額：共{Result}元" + Environment.NewLine;
            }


            this.DateTimePickerReset();
        }
        #endregion


        #region 各式方法
        //表單重置
        private void Init()
        {
            this.rbtnAnnual.Checked = true;
            this.cbxUsage.SelectedIndex = 0;
            this.cbxCategory.SelectedIndex = 0;
            this.lblResult.Text = string.Empty;
            this.panelTimePicker.Visible = false;
            this.DateTimePickerReset();
        }

        //DateTimePicker重置
        private void DateTimePickerReset()
        {
            dateTimePickerFrom.Value = new DateTime(DateTime.Now.Year, 01, 01);
            dateTimePickerUntil.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        //選單連動
        private void cbxUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxUsage.SelectedIndex == 0)
            {
                this.cbxCategory.Items.Clear();
                this.cbxCategory.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                this.cbxCategory.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                this.cbxCategory.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                this.cbxCategory.Items.Add("501-600");
                this.cbxCategory.Items.Add("601-1200");
                this.cbxCategory.Items.Add("1201-1800");
                this.cbxCategory.Items.Add("1801或以上");
                this.cbxCategory.SelectedIndex = 0;
            }

            else if (this.cbxUsage.SelectedIndex == 1)
            {
                this.cbxCategory.Items.Clear();
                this.cbxCategory.Items.Add("500以下");
                this.cbxCategory.Items.Add("501-600");
                this.cbxCategory.Items.Add("601-1200");
                this.cbxCategory.Items.Add("1201-1800");
                this.cbxCategory.Items.Add("1801-2400");
                this.cbxCategory.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.cbxCategory.Items.Add("3001-3600");
                this.cbxCategory.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.cbxCategory.Items.Add("4201-4800");
                this.cbxCategory.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.cbxCategory.Items.Add("5401-6000");
                this.cbxCategory.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.cbxCategory.Items.Add("6601-7200");
                this.cbxCategory.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.cbxCategory.Items.Add("7801-8400");
                this.cbxCategory.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.cbxCategory.Items.Add("9001-9600");
                this.cbxCategory.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbxCategory.Items.Add("10201以上");
                this.cbxCategory.SelectedIndex = 0;
            }

            else if (this.cbxUsage.SelectedIndex == 2)
            {
                this.cbxCategory.Items.Clear();
                this.cbxCategory.Items.Add("600以下");
                this.cbxCategory.Items.Add("601-1200");
                this.cbxCategory.Items.Add("1201-1800");
                this.cbxCategory.Items.Add("1801-2400");
                this.cbxCategory.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.cbxCategory.Items.Add("3001-3600");
                this.cbxCategory.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.cbxCategory.Items.Add("4201-4800");
                this.cbxCategory.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.cbxCategory.Items.Add("5401-6000");
                this.cbxCategory.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.cbxCategory.Items.Add("6601-7200");
                this.cbxCategory.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.cbxCategory.Items.Add("7801-8400");
                this.cbxCategory.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.cbxCategory.Items.Add("9001-9600");
                this.cbxCategory.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbxCategory.Items.Add("10201以上");
                this.cbxCategory.SelectedIndex = 0;
            }

            else if (this.cbxUsage.SelectedIndex == 3)
            {
                this.cbxCategory.Items.Clear();
                this.cbxCategory.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbxCategory.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbxCategory.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.cbxCategory.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.cbxCategory.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.cbxCategory.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.cbxCategory.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                this.cbxCategory.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.cbxCategory.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.cbxCategory.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbxCategory.Items.Add("7801以上");
                this.cbxCategory.SelectedIndex = 0;
            }

            else if (this.cbxUsage.SelectedIndex == 4)
            {
                this.cbxCategory.Items.Clear();
                this.cbxCategory.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbxCategory.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbxCategory.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.cbxCategory.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.cbxCategory.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.cbxCategory.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.cbxCategory.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                this.cbxCategory.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.cbxCategory.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.cbxCategory.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbxCategory.Items.Add("7801以上");
                this.cbxCategory.SelectedIndex = 0;
            }
        }

        //計算
        private int GetTaxPercentage()
        {
            if (this.cbxUsage.SelectedIndex == 0)
            {
                string taxType = this.cbxCategory.Text;
                switch (taxType)
                {
                    case "150以下 / 12HP以下(12.2PS以下)":
                        return 0;

                    case "151-250 / 12.1-20HP(12.3-20.3PS)":
                        return 800;

                    case "251-500 / 20.1HP以上(20.4PS以上)":
                        return 1620;

                    case "501-600":
                        return 2160;

                    case "601-1200":
                        return 4320;

                    case "1201-1800":
                        return 7120;

                    case "1801或以上":
                        return 11230;

                    default:
                        return 0;
                }
            }
            else if (this.cbxUsage.SelectedIndex == 1)
            {
                string taxType = this.cbxCategory.Text;
                switch (taxType)
                {
                    case "500以下":
                        return 900;

                    case "501-600":
                        return 1080;

                    case "601-1200":
                        return 1800;

                    case "1201-1800":
                        return 2700;

                    case "1801-2400":
                        return 3600;

                    case "2401-3000 / 138HP以下(140.1PS以下)":
                        return 4500;

                    case "3001-3600":
                        return 5400;

                    case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                        return 6300;

                    case "4201-4800":
                        return 7200;

                    case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                        return 8100;

                    case "5401-6000":
                        return 9000;

                    case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                        return 9900;

                    case "6601-7200":
                        return 10800;

                    case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                        return 11700;

                    case "7801-8400":
                        return 12600;

                    case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                        return 13500;

                    case "9001-9600":
                        return 14400;

                    case "9601-10200 / 361.1HP以上(366.5PS以上)":
                        return 15300;

                    case "10201以上":
                        return 16200;

                    default:
                        return 0;
                }
            }
            else if (this.cbxUsage.SelectedIndex == 2)
            {
                string taxType = this.cbxCategory.Text;
                switch (taxType)
                {
                    case "600以下":
                        return 1080;

                    case "601-1200":
                        return 1800;

                    case "1201-1800":
                        return 2700;

                    case "1801-2400":
                        return 3600;

                    case "2401-3000 / 138HP以下(140.1PS以下)":
                        return 4500;

                    case "3001-3600":
                        return 5400;

                    case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                        return 6300;

                    case "4201-4800":
                        return 7200;

                    case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                        return 8100;

                    case "5401-6000":
                        return 9000;

                    case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                        return 9900;

                    case "6601-7200":
                        return 10800;

                    case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                        return 11700;

                    case "7801-8400":
                        return 12600;

                    case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                        return 13500;

                    case "9001-9600":
                        return 14400;

                    case "9601-10200 / 361.1HP以上(366.5PS以上)":
                        return 15300;

                    case "10201以上":
                        return 16200;

                    default:
                        return 0;
                }
            }
            else if (this.cbxUsage.SelectedIndex == 3)
            {
                string taxType = this.cbxCategory.Text;
                switch (taxType)
                {
                    case "500以下 / 38HP以下(38.6PS以下)":
                        return 1620;

                    case "501~600 / 38.1-56HP(38.7-56.8PS)":
                        return 2160;

                    case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                        return 4320;

                    case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                        return 7120;

                    case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                        return 11230;

                    case "2401~3000 / 262.1-322HP(266-326.8PS)":
                        return 15210;

                    case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                        return 28220;

                    case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                        return 46170;

                    case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                        return 69690;

                    case "6601-7800 / 509.1HP以上(516.7PS以上)":
                        return 117000;

                    case "7801以上":
                        return 151200;

                    default:
                        return 0;
                }
            }
            else if (this.cbxUsage.SelectedIndex == 4)
            {
                string taxType = this.cbxCategory.Text;
                switch (taxType)
                {
                    case "500以下 / 38HP以下(38.6PS以下)":
                        return 900;

                    case "501~600 / 38.1-56HP(38.7-56.8PS)":
                        return 1260;

                    case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                        return 2160;

                    case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                        return 3060;

                    case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                        return 6480;

                    case "2401~3000 / 262.1-322HP(266-326.8PS)":
                        return 9900;

                    case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                        return 16380;

                    case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                        return 24300;

                    case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                        return 33660;

                    case "6601-7800 / 509.1HP以上(516.7PS以上)":
                        return 44460;

                    case "7801以上":
                        return 56700;

                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}