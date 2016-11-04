namespace SeSet
{
	partial class Updater
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		public void InitializeComponent()
		{
			this.updatedownload = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.instructionlist = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.changelogdownload = new System.Windows.Forms.TextBox();
			this.changelog = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// updatedownload
			// 
			this.updatedownload.Location = new System.Drawing.Point(149, 12);
			this.updatedownload.Name = "updatedownload";
			this.updatedownload.ReadOnly = true;
			this.updatedownload.Size = new System.Drawing.Size(366, 20);
			this.updatedownload.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Downloading update from:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Instruction list followed at:";
			// 
			// instructionlist
			// 
			this.instructionlist.Location = new System.Drawing.Point(146, 38);
			this.instructionlist.Name = "instructionlist";
			this.instructionlist.ReadOnly = true;
			this.instructionlist.Size = new System.Drawing.Size(369, 20);
			this.instructionlist.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Changelog found at:";
			// 
			// changelogdownload
			// 
			this.changelogdownload.Location = new System.Drawing.Point(124, 64);
			this.changelogdownload.Name = "changelogdownload";
			this.changelogdownload.ReadOnly = true;
			this.changelogdownload.Size = new System.Drawing.Size(391, 20);
			this.changelogdownload.TabIndex = 4;
			// 
			// changelog
			// 
			this.changelog.Location = new System.Drawing.Point(15, 90);
			this.changelog.Multiline = true;
			this.changelog.Name = "changelog";
			this.changelog.ReadOnly = true;
			this.changelog.Size = new System.Drawing.Size(503, 91);
			this.changelog.TabIndex = 6;
			this.changelog.Text = "Current Version: something.something.something\r\nVersion Downloadable: something.s" +
    "omething.something\r\nUpdates:\r\nadd ed something";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 187);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(503, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Download";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Updater
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 217);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.changelog);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.changelogdownload);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.instructionlist);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.updatedownload);
			this.Name = "Updater";
			this.Text = "Updater";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox updatedownload;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox instructionlist;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox changelogdownload;
		public System.Windows.Forms.TextBox changelog;
		public System.Windows.Forms.Button button1;
	}
}