using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Collections;
namespace Alarm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
            InitializeComponent();
			InitializeRightMenu();
			InitializeEvent();
            _alarmController = new AlarmController();
            this.DataContext = _alarmController;
		    
        }
        private AlarmController _alarmController;
        private void InitializeEvent()
        {
            this.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(MainWindow_MouseLeftButtonDown);
            this.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(MainWindow_MouseRightButtonDown);
			this.btRingCannel.Click+=new System.Windows.RoutedEventHandler(btRingCannel_Click);
			this.btFileSelect.Click+=new System.Windows.RoutedEventHandler(btFileSelect_Click);
            this.btRinging.Click+=new System.Windows.RoutedEventHandler(btRinging_Click);
        }
        private void InitializeRightMenu()
		{
      
		    _rightMenu = new ContextMenu();
		   	MenuItem closeItem=new MenuItem();
            MenuItem ringItem = new MenuItem();

            Image ringIcon = new Image();
            ringItem.Icon = ringIcon;
            ringIcon.Source = new BitmapImage(new Uri(@"Images\ring.png", UriKind.Relative));

            ringItem.Header = "闹钟";
            ringItem.InputGestureText = "None";
            ringItem.Click += new System.Windows.RoutedEventHandler(ringItem_Click);
            _rightMenu.Items.Add(ringItem);
            /////
            Image closeIcon = new Image();
            closeIcon.Source = new BitmapImage(new Uri(@"Images\close.png",UriKind.Relative)); 
            closeItem.Icon = closeIcon;
            ////
			closeItem.Header="关闭时钟";
            closeItem.InputGestureText = "None";    
			closeItem.Click+=new System.Windows.RoutedEventHandler(closeItem_Click);
			_rightMenu.Items.Add(closeItem);
            ////
          

		}
		private ContextMenu _rightMenu;
        private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this.DragMove();// 在此处添加事件处理程序实现。
        }

        private void MainWindow_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this._rightMenu.IsOpen=true;// 在此处添加事件处理程序实现。
        }
        
        private void closeItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close();// 在此处添加事件处理程序实现。
        }
        private void ringItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           // 在此处添加事件处理程序实现。
				this.RingSetting.Visibility=Visibility.Visible;
        }
 
	
        private void btRinging_Click(object sender, System.Windows.RoutedEventArgs e)
        {
		 
        	// 在此处添加事件处理程序实现。
			   this._alarmController.IsRinging=Visibility.Hidden;
			   this._alarmController.IsApplyRing=false;
        }

		  private void btRingCannel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
		
        	this.RingSetting.Visibility=Visibility.Hidden ;// 在此处添加事件处理程序实现。
        }
        private void btFileSelect_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// 在此处添加事件处理程序实现。
            _alarmController.RingSource = "";
        }
    }
}
