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
    public partial class MonthCalendar : UserControl
    {
        public event Action<DateTime, DayCalendar> DayCalendarSelected;
        public DateTime SelectedDay
        {
            get
            {
                return this._selectedDay;
            }
            set
            {
                if (this._selectedDay != value && this._dayDic.ContainsKey(value))
                {
                    if (this._dayDic.ContainsKey(this._selectedDay))
                    {
                        this._dayDic[this._selectedDay].Selected = false;
                    }
                    this._selectedDay = value;
                    this._dayDic[value].Selected = true;
                    this.DayCalendarSelected?.Invoke(value, this._dayDic[value]);
                }
            }
        }
        private DateTime _selectedDay = DateTime.MinValue;
        public DayCalendar SelectedValue
        {
            get
            {
                DayCalendar calendar = null;
                if (this._dayDic.ContainsKey(this.SelectedDay))
                    calendar = this._dayDic[this.SelectedDay];
                return calendar;
            }
        }
        public DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                if (this._date.Date != value.Date)
                {
                    this._date = value;
                    this.DrawMonth(this._date);
                }
            }
        }
        private Dictionary<DateTime, DayCalendar> _dayDic = new Dictionary<DateTime, DayCalendar>();
        private DateTime _date;
        public MonthCalendar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += MonthCalendar_Load;
        }
        private void MonthCalendar_Load(object sender, EventArgs e)
        {
            this.Date = DateTime.Now;
        }
       
        private void DrawMonth(DateTime date)
        {
            this.SuspendLayout();
            this._flpDays.Visible = false;
            this._dayDic.Clear();
            this._flpDays.Controls.Clear();
            Int32 days = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime monthFirstDate = new DateTime(date.Year, date.Month, 1);
            DateTime monthLastDate = new DateTime(date.Year, date.Month, days);
            DateTime temp = monthFirstDate;
            while (temp <= monthLastDate)
            {
                DayCalendar day = new DayCalendar();
                day.MonthCalendar = this;
                day.Date = temp;
                this._dayDic.Add(day.Date, day);
                temp = temp.AddDays(1);
                this._flpDays.Controls.Add(day);
            }
            this.SelectedDay = monthFirstDate;
            this.ResumeLayout();
            this._flpDays.Visible = true;
        }

    }
}
