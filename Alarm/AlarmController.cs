using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows;
using System.Windows.Forms;
namespace Alarm
{
    public sealed class AlarmController : INotifyPropertyChanged,IDisposable
    {
     
        public bool IsApplyRing
        {
            get { return _isApplyRing; }
            set
            {
                _isApplyRing = value;
                if (_isApplyRing)
                {
                    if (String.IsNullOrEmpty(_ringSource))
                        _alarmPlayer.Open(new Uri(_redundancyRingSource, UriKind.Relative));
                    else
                        _alarmPlayer.Open(new Uri(_ringSource, UriKind.Absolute));
                    _ringTimer.Interval = _ringTime*60*1000;
                    _ringTimer.Start();
                }
                else
                {
                    _ringTimer.Stop();
                    _alarmPlayer.Stop();
                }
                OnPropertyChanged("IsApplyRing");
            }
        }
        private bool _isApplyRing = false;
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        public string RingSource
        {
            get { return _ringSource; }
            set
            {
                _openFileDialog.ShowDialog();
                _ringSource = _openFileDialog.FileName;
                OnPropertyChanged("RingSource");
            }
        }
        private string _ringSource ="";
        private string _redundancyRingSource=@"Vedio\佐藤康夫 - 夜明.mp3";
        public double RingTime
        {
            get { return _ringTime; }
            set
            {
                _ringTime = value;
                OnPropertyChanged("RingTime");
            }
        }
        private double _ringTime=1;
        public double Hour
        {
            get { return _hour; }
            set
            {
                _hour = value;
                OnPropertyChanged("Hour");
            }
        }
        public double Minute
        {
            get { return _minute; }
            set
            {
                _minute = value;
                OnPropertyChanged("Minute");
            }
        }
        public double Second
        {
            get { return _second; }
            set
            {
                _second = value;
                OnPropertyChanged("Second");
            }
        }

        public Visibility IsRinging
        {
            get { return _isRinging; }
            set
            {
                _isRinging = value;
                OnPropertyChanged("IsRinging");
            }
        }
        private Visibility _isRinging = Visibility.Hidden;
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Timer触发间隔
        /// </summary>
        private static Double _timerInterval = 1000;
        /// <summary>
        /// 指针角度修正值
        /// </summary>
        private static Double _correctiveAngle = -90;
        public AlarmController()
        {
            initialDateTime();
            _alarmPlayer.Volume = 1;
            _alarmPlayer.MediaEnded+=_alarmPlayer_MediaEnded;
            _timer = new System.Timers.Timer(_timerInterval);
            _ringTimer = new System.Timers.Timer();
            _ringTimer.AutoReset = false;

            _ringTimer.Elapsed+=_ringTimer_Elapsed;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }
        void _alarmPlayer_MediaEnded(Object sender,EventArgs e)
        {
            //循环播放
            PlayRing();
        }
        public void StopPlayRing()
        {
            _alarmPlayer.Stop();
			_ringTimer.Stop();
        }
        ~AlarmController()
        {
        }
        public void Dispose()
        {
            _timer.Stop();
            _timer.Dispose();
           _alarmPlayer.Stop();
           _alarmPlayer.Close();
        }
        MediaPlayer _alarmPlayer = new MediaPlayer();

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            initialDateTime();
        }
        void _ringTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.IsRinging = Visibility.Visible;
            PlayRing();
        }
        void PlayRing()
        {
            _alarmPlayer.Dispatcher.Invoke(new Action(delegate() { _alarmPlayer.Play(); }));
        }
        /// <summary>
        ///  秒针 一秒钟转6度 
        /// </summary>
        private static Int32 _secondHandEachAngle = 6;
        /// <summary>
        /// 分针 一分钟转6度 
        /// </summary>
        private static Int32 _minuteHandEachAngle = 6;
        /// <summary>
        /// 时针 一小时转动30度
        /// </summary>
        private static Int32 _hourHandEachAngle = 30;
        /// <summary>
        /// 12小时制
        /// </summary>
        private static Int32 _hoursSystem = 12;
        /// <summary>
        /// 分时换算率
        /// </summary>
        private static Double _conversionRate = 60.0;
        void initialDateTime()
        {
            Double angle = 0d;
            Int32 vhour = DateTime.Now.Hour;

            Int32 vsecond = DateTime.Now.Second;
            angle = _correctiveAngle + vsecond * _secondHandEachAngle;
            Second = angle;
    
            Int32 vminute = DateTime.Now.Minute;
            angle = _correctiveAngle + vminute * _minuteHandEachAngle;
            if(angle!=Minute)
            {
                Minute = angle;
                vhour = vhour > _hoursSystem ? vhour - _hoursSystem : vhour; //12小时制
                angle = _correctiveAngle + vhour * _hourHandEachAngle;// 时针 1小时转30度 
                //时针角度与分针也有关系，整点角度+一小时所过时间百分比
                Hour = angle + vminute / _conversionRate * _hourHandEachAngle;
            }
        }


        private void OnPropertyChanged(String info)
        {

            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        private Double _hour, _minute, _second;
       
        private System.Timers.Timer _timer;
        private System.Timers.Timer _ringTimer;
    }
}
