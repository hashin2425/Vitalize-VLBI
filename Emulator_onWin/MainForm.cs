using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Emulator_onWin
{
    public partial class MainForm : Form
    {
        public class Watch
        {
            public string Title { get; set; }
            public string Content { get; set; }
        }
        public BindingList<Watch> watches = new BindingList<Watch>(); // DataGridViewに取り付ける場合はList<>ではなく、これを使う

        public MainForm()
        {
            InitializeComponent();
            watchBindingSource.DataSource = watches;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            serialPort.PortName = Port_textbox.Text;
            serialPort.Open();
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // 割り込み処理であるため、Invokeを介してBindingListを操作する。
            Invoke(new Action(Call_read));
        }

        private void Call_read()
        {
            watches.Add(new Watch { Title = "raw", Content = serialPort.ReadExisting() });
        }

    }
}
