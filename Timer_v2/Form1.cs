using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_turn_on();
        }
        void timer_turn_on()
        {
            if (int.TryParse(textBox1.Text, out int hours) && hours > 0)
            {
                int seconds = hours * 60 * 60;
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c shutdown -s -f -t {seconds}",
                    WindowStyle = ProcessWindowStyle.Hidden
            });
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }
        void timer_turn_off()
        {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c shutdown -a",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer_turn_off();
        }
    }
}
