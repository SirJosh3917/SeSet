using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeSet
{
	public partial class Updater : Form
	{
		public Updater()
		{
			InitializeComponent();
		}

		private void closing(object sender, FormClosingEventArgs e)
		{
			if(e.CloseReason != CloseReason.UserClosing)
				e.Cancel = true;
			if (!Program.Kill)
				Application.Exit();
			this.Invoke((MethodInvoker)(() => this.Hide()));
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new WebClient() { Proxy = null }.DownloadFile(updatedownload.Text, "update.zip");
			MessageBox.Show("Update has been downloaded. Please open update.zip");
			this.Hide();
			Application.Exit();
		}
	}
}
