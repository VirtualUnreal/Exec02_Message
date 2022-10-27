using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			MessageBox.Show($"你好，現在時間是{dt}","您好", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void ClickButton2_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			MessageBox.Show($"你好~~~~~~~\r\n現在時間是{dt}", "您好", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ClickLabel1_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			LabelOne.Text = "你好，現在時間是" + dt;
		}

		private void ClickLabel2_Click(object sender, EventArgs e)
		{

			DateTime dt = DateTime.Now;
			LabelTwo.Text = "你好~~~~~\r\n現在時間是" + dt;
		}
	}
}
