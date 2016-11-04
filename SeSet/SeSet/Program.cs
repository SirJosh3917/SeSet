using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeSet
{
	static class Program
	{
		public static bool Kill = true;
		public static Updater update;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var Form = new Form1();
			update = new Updater();
			new Thread(delegate()
			{
				try
				{
					WebClient getinfo = new WebClient() { Proxy = null };
					string x = "https://raw.githubusercontent.com/SirJosh3917/SeSet/master/Web/instructions.txt";
					update.Show();
					update.Hide();
					update.Invoke((MethodInvoker)(() => update.instructionlist.Text = x));
					update.Invoke((MethodInvoker)(() => update.updatedownload.Text = x));
					var info = getinfo.DownloadData(x);

					string data = "";
					foreach (byte i in info)
						data += Convert.ToChar(i).ToString();

					data.Replace('\r', '\0');
					var instructions = data.Split('\n');

					bool show = false;
					bool intense = false;

					foreach (string i in instructions)
					{
						if (i == string.Concat("ForceUpdate=true for ", Config.Version) || (
							i != string.Concat("ForceUpdate=true for all but ", Config.Version) && i.StartsWith("ForceUpdate=true for all but ")) ||
							(i == "ForceUpdate=true for all"))
						{
							Kill = !Kill;
							Form.Invoke((MethodInvoker)(() => Form.Close()));
							MessageBox.Show("An update is availible and is required to download.");
							intense = true;
							Application.Run(update);
							Application.Exit();
						}
						if(!intense)
							if (i.StartsWith("LatestVersion="))
								if (i != string.Concat("LatestVersion=", Config.Version))
									if (DialogResult.Yes == MessageBox.Show("An update is availible. Would you like to download it?", "Update Availible", MessageBoxButtons.YesNo))
									{
										Application.Run(update);
										show = !show;
									}
						if (i.StartsWith("ChangelogDownload="))
						{
							update.Invoke((MethodInvoker)(() => update.changelogdownload.Text = i.Split('=')[1]));
							var changelog = getinfo.DownloadData(i.Split('=')[1]);
							update.Invoke((MethodInvoker)(() => update.changelog.Text = "Current Version: " + Config.Version + "\r\n" + String(changelog)));
						}
						if (i.StartsWith("UpdateDownload="))
						{
							update.Invoke((MethodInvoker)(() => update.updatedownload.Text = i.Split('=')[1]));
						}
					}
					if (show)
						update.Show();
				}
				catch(Exception e)
				{
					MessageBox.Show("Failed at downloading the most recent update instructions.\r\nPlease open this when you have internet, or take a look at the following error: " + e.Message);
					Application.Exit();
				}
			}).Start();
			Application.Run(Form);
			Application.Exit();
		}

		private static string String(byte[ ]array)
		{
			string ret = "";
			foreach (byte i in array)
				ret += Convert.ToChar(i).ToString();
			return ret;
		}
	}
}
