using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CCWin;
namespace FileSpliter
{
    public partial class FileSpliterUi : CCSkinMain
    {
        public FileSpliterUi()
        {
            InitializeComponent();
            Init();
        }
        private Spliter _Spliter = new Spliter();
        private void Init()
        {
            this._OpenFileDialog.Multiselect = true;
            this._SaveFileDialog.AddExtension = false;
            CheckForIllegalCrossThreadCalls = false;

            this._Spliter.Combined += _Spliter_Combined;
            this._Spliter.Splited += _Spliter_Splited;
            this._Spliter.StartSplite += _Spliter_StartSplite;
            this._Spliter.StartCombine += _Spliter_StartCombine;

            this._Spliter.Combined += OperationExplain;
            this._Spliter.Splited += OperationExplain;
            this._Spliter.StartSplite += OperationExplain;
            this._Spliter.StartCombine+= OperationExplain;
            this._Spliter.AbNormalHappend += OperationExplain;
            this._Spliter.SpliteProgressing+=_Spliter_SpliteProgressing;
            this._Spliter.CombineProgressing+=_Spliter_CombineProgressing;
        }
        private void _Spliter_Combined(object sender, EventArgs e)
        {
            this.buttonCombineStart.Enabled = true;
        }
        private void _Spliter_Splited(object sender, EventArgs e)
        {
            this.buttonSpliteStart.Enabled = false;
        }
        private void _Spliter_StartSplite(object sender, EventArgs e)
        {
            this.buttonSpliteStart.Enabled = false;
        }
        private void _Spliter_StartCombine(object sender, EventArgs e)
        {
            this.buttonCombineStart.Enabled = false;
        }
        private void _Spliter_SpliteProgressing(object sender, EventArgs e)
        {
            this.labelSplitePro.Text = sender as String;
        }
        private void _Spliter_CombineProgressing(object sender, EventArgs e)
        {
            this.labelCombinePro.Text = sender as String;
        }
        private void labelSelectBeSplitFile_Click(object sender, EventArgs e)
        {

        }
        private OpenFileDialog _OpenFileDialog = new OpenFileDialog();
        private void buttonSelectFileOfSplite_Click(object sender, EventArgs e)
        {
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                TXT_BeSplited.Text =_OpenFileDialog.FileName;
            }
        }

        private static Object _SyncObj = new Object();
        private void OperationExplain(Object sender,EventArgs e)
        {  
           // this.labelOperatorTip.Text = sender as String;
            lock(_SyncObj)
            {
                String taskInfo = (sender as String) + "\r\n";
                this.textBoxTaskInfo.AppendText(taskInfo);
                //使得文本框始终显示最新的信息
                this.textBoxTaskInfo.ScrollToCaret();
            }
        }
    
        private void buttonSpliteStart_Click(object sender, EventArgs e)
        {
            //重置进度条
            progressBarSpliteProgress.Value = 0;
            Thread woker = new Thread(WorkingOfSplite);
            try
            {
                woker.Start();
            }
            catch(Exception exp)
            {
                MessageBox.Show("分割时出现了异常:"+exp.Message);
            }
        }
        private void WorkingOfSplite()
        {
            if (String.IsNullOrEmpty(textBoxＤepositary.Text))
            {
                MessageBox.Show(this,"存储路径为空!");
                return;
            }
            if (this.radioButtonSpliteOfSize.Checked )
            {
                _Spliter.SplitFile(textBoxＤepositary.Text, TXT_BeSplited.Text, progressBarSpliteProgress, Spliter.SpliteMode.Size, Convert.ToInt32(textBoxSpliteSize.Text.Trim()), comboBoxSpliteUnit.Text);
            }
            else 
            {
                _Spliter.SplitFile(textBoxＤepositary.Text, TXT_BeSplited.Text, progressBarSpliteProgress, Spliter.SpliteMode.Number, (Int32)numericUpDownSpliteCount.Value, comboBoxSpliteUnit.Text);
            }
        }
        private FolderBrowserDialog _FolderBrowserDialog = new FolderBrowserDialog();
        private void buttonSelectFileOfStore_Click(object sender, EventArgs e)
        {
            if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxＤepositary.Text = _FolderBrowserDialog.SelectedPath;
            }
        }

        private void comboBoxSpliteUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBarSpliteProgress_Click(object sender, EventArgs e)
        {

        }

        private void textBoxＤepositary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBeSplited_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private String[] CombinFileNames;
        private void buttonSelectedCombinFile_Click(object sender, EventArgs e)
        {
          if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                String Selectfile = "";
                String[] files = _OpenFileDialog.FileNames;
                CombinFileNames = _OpenFileDialog.FileNames;
                for (int i = 0; i < files.Length; ++i )
                {
                 
                     Selectfile +=(files[i].ToString()+"\r\n");
                }
               textBoxCombinFile.Text = Selectfile;
            }
        }
        private SaveFileDialog _SaveFileDialog = new SaveFileDialog();
        private void buttonSelectStoragePathOfCombine_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxCombinedFilePath.Text = _SaveFileDialog.FileName;
                }

                if (CombinFileNames.Length > 0)
                {
                    this.textBoxCombinedFilePath.Text += System.IO.Path.GetExtension(CombinFileNames[0]);
                }
                else
                {
                    throw new Exception("选择的文件集为空");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void buttonCombineStart_Click(object sender, EventArgs e)
        {
            //重置进度条
            progressBarCombineProcesser.Value = 0;
            Thread worker = new Thread(WorkingOfCombine);
            try
            {
                worker.Start();
            }
            catch(Exception exp)
            {
                MessageBox.Show("合并时出现了异常:"+exp.Message);
            }
        }
        private void WorkingOfCombine()
        {
            this._Spliter.CombineFile(CombinFileNames, textBoxCombinedFilePath.Text, progressBarCombineProcesser);
        }
    }
}
