using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerIOClient;
using System.Threading;

namespace SeSet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public Connection x;

		private void domin(object sender, EventArgs e)
		{
			if (id1.Value < id0.Value)
				id1.Value = id0.Value;
		}

		private void valchange(object sender, EventArgs e)
		{
			if (id1.Value < id0.Value)
				id1.Value = id0.Value;
		}

		private void startreset_Click(object sender, EventArgs wqrge)
		{
			string e = email.Text;
			string p = password.Text;
			string w = worldid.Text;

			var cl = PlayerIO.QuickConnect.SimpleConnect("everybody-edits-su9rn58o40itdbnw69plyw", e, p, null);
			var c = cl.Multiplayer.CreateJoinRoom(w, "Everybodyedits" + cl.BigDB.Load("config", "config")["version"], true, null, null);

			c.OnMessage += c_OnMessage;
			x = c;
			c.Send("init");
		}

		public int _w = 0, _h = 0;
		public bool edit = false;

		void c_OnMessage(object sender, PlayerIOClient.Message e)
		{
			switch(e.Type)
			{
				case "init":
					int width = e.GetInt(18);
					int height = e.GetInt(19);
					edit = e.GetBoolean(14);
					_w = width;
					_h= height;
					x.Send("init2");
					break;
				case "init2":
					//start building
					x.Send("say", "Ready to build!");
					if(edit)
					{
						Build();
					}
					break;
				case "access":
					Build();
					break;
			}
		}

		public void Build()
		{
			int portal = Convert.ToInt32(portalStart.Value);
			bool gate = gates.Checked;
			bool global = globalswitches.Checked;
			int sOn = Convert.ToInt32(id0.Value),
				max = Convert.ToInt32(id1.Value);
			for (int px = Convert.ToInt32(xpos.Value); px < _w - 5; px += 3)
			{
				if (!(sOn > max))
				{
					x.Send("b", 0, px, Convert.ToInt32(ypos.Value), 9); Thread.Sleep(20);
					x.Send("b", 0, px + 1, Convert.ToInt32(ypos.Value), 242, 0, portal, portal + 1); Thread.Sleep(20);
					x.Send("b", 0, px + 2, Convert.ToInt32(ypos.Value), 9); Thread.Sleep(20);
					x.Send("b", 0, px + 3, Convert.ToInt32(ypos.Value), 9); Thread.Sleep(20);
					portal++;
				}
				int last = 0;
				for (int py = Convert.ToInt32(ypos.Value) + 1; py < _h - 5; py += 3)
				{
					if (!(sOn > max))
					{
						BuildSwitch(gate, global, px, py, sOn);
						sOn++;
						last = py;
					}
				}
				if (!(sOn > max))
				{
					x.Send("b", 0, px, last + 3, 9); Thread.Sleep(20);
					x.Send("b", 0, px + 1, last + 3, 242, 0, portal, portal + 1); Thread.Sleep(20);
					x.Send("b", 0, px + 2, last + 3, 9); Thread.Sleep(20);
					x.Send("b", 0, px + 3, last + 3, 9); Thread.Sleep(20);
					portal++;
				}
			}
			x.Send("say", "[SeSet] I have completed my task in building a switch resetter!");
			x.Disconnect();
			x = null;
		}

		public void BuildSwitch(bool gate, bool global, int px, int py, int id)
		{
			int door = 184;
			int switc = 113;

			if (gate)
				door = 185;

			if (global)
				door = 1079;

			if (global)
				switc = 467;

			if (global && gate)
				door = 1080;
			/*
			x.Send("b", 0, px, py, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py, 117); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py, 9); Thread.Sleep(20);*/
			/*
			x.Send("b", 0, px, py + 1, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py + 1, 115); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py + 1, door, id); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py + 1, 9); Thread.Sleep(20);

			x.Send("b", 0, px, py + 2, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py + 2, 114); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py + 2, switc, id); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py + 2, 9); Thread.Sleep(20);

			
			x.Send("b", 0, px, py + 3, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py + 3, 117); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py + 3, 114); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py + 3, 9); Thread.Sleep(20);
			/**/

			x.Send("b", 0, px, py, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py, 115); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py, door, id); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py, 9); Thread.Sleep(20);

			x.Send("b", 0, px, py + 1, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py + 1, 114); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py + 1, switc, id); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py + 1, 9); Thread.Sleep(20);


			x.Send("b", 0, px, py + 2, 9); Thread.Sleep(20);
			x.Send("b", 0, px + 1, py + 2, 117); Thread.Sleep(20);
			x.Send("b", 0, px + 2, py + 2, 114); Thread.Sleep(20);
			x.Send("b", 0, px + 3, py + 2, 9); Thread.Sleep(20);
		}

		private void closing(object sender, FormClosingEventArgs e)
		{
			if(Program.Kill)
			Application.Exit();
		}
	}
}
