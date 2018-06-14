using System;
using System.Windows.Forms;

namespace PowerOnRegister
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            this.AddPowerOnItem();
        }
        private void AddPowerOnItem()
        {
            if (!String.IsNullOrEmpty(this._tbPowerOnName.Text) &&
                !String.IsNullOrEmpty(this._tbPowerOnPath.Text))
            {
                if (RegisterManager.AddOrUpdatePowerOnItemValue(this._tbPowerOnName.Text,
                    this._tbPowerOnPath.Text,
                    this._tbPoweronParameter.Text
                    ))
                {
                    MessageBox.Show("已成功更新至注册表！", "添加启动项", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("更新失败！", "添加启动项", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("名称与启动路径是必须的！", "无效内容", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void _btnSelectPath_Click(Object sender, EventArgs e)
        {
            if (DialogResult.OK == this.openFileDialog1.ShowDialog())
            {
                this._tbPowerOnPath.Text = this.openFileDialog1.FileName;
            }
        }
    }
}
