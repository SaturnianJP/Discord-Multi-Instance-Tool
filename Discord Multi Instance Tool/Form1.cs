using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Discord_Multi_Instance_Tool
{
    public partial class Form1 : Form
    {
        private string multiInstance = "--multi-instance";

        public Form1()
        {
            InitializeComponent();
        }

        private void _run_discord(object sender, EventArgs e)
        {
            Process[] discords = Process.GetProcessesByName("discord");

            if (discords.Length == 0)
            {
                MessageBox.Show("ディスコードのプロセスが見つかりませんでした。", "Discord Multi Instance Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process discord = discords[0];
            if (discord == null)
            {
                MessageBox.Show("ディスコードのプロセスが見つかりませんでした。", "Discord Multi Instance Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process.Start(discord.MainModule.FileName, multiInstance);
        }
    }
}
