using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace Woagedit_cs
{
    public partial class Form1 : Form
    {
        Process p = new Process();
        //public string appdata = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            string r = Param.Text;
            if (r == string.Empty && checkBox1.Enabled == false)
            {
                p.StartInfo.FileName = "PizzaTower2.exe";
                p.StartInfo.Arguments = "";
            }
            else if(checkBox1.Enabled == true)
            {
                p.StartInfo.FileName = $"PizzaTower2.exe";
                p.StartInfo.Arguments = $"{Param.Text} -debug";
            }
            else
            {
                p.StartInfo.FileName = $"PizzaTower2.exe";
                p.StartInfo.Arguments = $"{Param.Text}";
            }
            p.Start();
        }

        private void LocalFiles_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $@"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\Appdata\Roaming\PizzaTower_GM2");
        }

        private void OpenWoagules_Click(object sender, EventArgs e)
        {
            //label5.Text = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start("explorer.exe", $@"{AppDomain.CurrentDomain.BaseDirectory}woagules");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $@"rename {AppDomain.CurrentDomain.BaseDirectory}data.win data.win.orig & copy {AppDomain.CurrentDomain.BaseDirectory}woagules\{Woagulepath.Text} & rename {AppDomain.CurrentDomain.BaseDirectory}{Woagulepath.Text} data.win";
            p.Start();
        }

        private void Param_TextChanged(object sender, EventArgs e)
        {
        }

        private void loading(object sender, EventArgs e)
        {
            //Param.Text = ConfigurationSettings.AppSettings.Set("params");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
