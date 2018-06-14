using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DayCalendar : UserControl
    {
        protected static Int32 RgbDiff = 50;
        protected static String[] WeekDays = new String[]
            {
                "日","一", "二", "三", "四", "五", "六"
            };
        /// <summary>
        /// 所属的<see cref="MonthCalendar"/> 
        /// </summary>
        public MonthCalendar MonthCalendar { get; internal set; }
        public Boolean Selected
        {
            get
            {
                return this._selected;
            }
            set
            {
                this._selected = value;
                this.Invalidate();
            }
        }
        private Boolean _selected = false;
        [Description("获取或设置控件所表示的日期")]
        public DateTime Date
        {
            get { return this._date; }
            set
            {
                if (this._date.Date != value.Date)
                {
                    this._date = value;
                    this.IsHoliday = this.JudgeIsHoliday((Int32)this._date.DayOfWeek);
                    this.DrawDate();
                }
            }
        }
        /// <summary>
        /// 表示当前日期是否是节假日
        /// </summary>
        public Boolean IsHoliday { get; set; }
        private DateTime _date = DateTime.Now;
        public DayCalendar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.InitlizeEvent();
            this.InitlizeView();
            this.DrawDate();
        }
        protected void InitlizeView()
        {
            this.Cursor = Cursors.Hand;
        }
        protected void InitlizeEvent()
        {
            this.MouseEnter += DayCalendar_MouseEnter;
            this.MouseLeave += DayCalendar_MouseLeave;
            this.Click += DayCalendar_Click;
            this._lblWeek.MouseEnter += DayCalendar_MouseEnter;
            this._lblDay.MouseEnter += DayCalendar_MouseEnter;
            this._lblYearMonth.MouseEnter += DayCalendar_MouseEnter;
            this._lblHoliday.MouseEnter += DayCalendar_MouseEnter;

            this._lblWeek.MouseLeave += DayCalendar_MouseLeave;
            this._lblDay.MouseLeave += DayCalendar_MouseLeave;
            this._lblYearMonth.MouseLeave += DayCalendar_MouseLeave;
            this._lblHoliday.MouseLeave += DayCalendar_MouseLeave;

            this._lblWeek.Click += DayCalendar_Click;
            this._lblDay.Click += DayCalendar_Click;
            this._lblYearMonth.Click += DayCalendar_Click;
            this._lblHoliday.Click += DayCalendar_Click;
        }

        private void DayCalendar_Click(object sender, EventArgs e)
        {
            if (this.MonthCalendar != null)
            {
                this.MonthCalendar.SelectedDay = this.Date;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.Selected)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 8);
                g.DrawRectangle(pen, this.ClientRectangle);
                pen.Dispose();
            }
        }
        private void DayCalendar_MouseLeave(object sender, EventArgs e)
        {
            this.SettingBackColorDiff(RgbDiff);
        }

        private void DayCalendar_MouseEnter(object sender, EventArgs e)
        {
            this.SettingBackColorDiff(-RgbDiff);
        }
        private void SettingBackColorDiff(Int32 diffValue)
        {
            this.BackColor = Color.FromArgb(
              this.BackColor.R + diffValue,
              this.BackColor.B + diffValue,
              this.BackColor.G + diffValue);
            this.Invalidate();
        }



        public void DrawDate()
        {
            this._lblYearMonth.Text = this._date.ToString("yyyy-MM");
            this._lblDay.Text = this._date.ToString("dd");
            this._lblWeek.Text = String.Format("星期{0}", WeekConvertUpper(((Int32)this._date.DayOfWeek)));
            if (this.IsHoliday) this._lblHoliday.Visible = true;
            else this._lblHoliday.Visible = false;
        }
        public String WeekConvertUpper(Int32 number)
        {
            if (number < 0 || number > 6)
            {
                return String.Empty;
            }
            return WeekDays[number];
        }
        public Boolean JudgeIsHoliday(Int32 weekDay)
        {
            return (weekDay == 6 || weekDay == 0);
        }
    }
}
