namespace SeSet
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.globalswitches = new System.Windows.Forms.CheckBox();
			this.id0 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.id1 = new System.Windows.Forms.NumericUpDown();
			this.email = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.worldid = new System.Windows.Forms.TextBox();
			this.startreset = new System.Windows.Forms.Button();
			this.xpos = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ypos = new System.Windows.Forms.NumericUpDown();
			this.gates = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.portalStart = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.id0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.id1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ypos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.portalStart)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 349);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "SeSet: Instantly make switch resets - by ninjasupeatsninja\r\nCredits to pingohits " +
    "for switch reset!";
			// 
			// globalswitches
			// 
			this.globalswitches.AutoSize = true;
			this.globalswitches.Location = new System.Drawing.Point(6, 19);
			this.globalswitches.Name = "globalswitches";
			this.globalswitches.Size = new System.Drawing.Size(102, 17);
			this.globalswitches.TabIndex = 1;
			this.globalswitches.Text = "Global Switches";
			this.globalswitches.UseVisualStyleBackColor = true;
			// 
			// id0
			// 
			this.id0.Location = new System.Drawing.Point(6, 14);
			this.id0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.id0.Name = "id0";
			this.id0.Size = new System.Drawing.Size(102, 20);
			this.id0.TabIndex = 2;
			this.id0.ValueChanged += new System.EventHandler(this.valchange);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "to";
			// 
			// id1
			// 
			this.id1.Location = new System.Drawing.Point(154, 14);
			this.id1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.id1.Name = "id1";
			this.id1.Size = new System.Drawing.Size(112, 20);
			this.id1.TabIndex = 4;
			this.id1.ValueChanged += new System.EventHandler(this.domin);
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(6, 19);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(258, 20);
			this.email.TabIndex = 5;
			this.email.Text = "Email";
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(6, 45);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(258, 20);
			this.password.TabIndex = 6;
			this.password.Text = "Password";
			this.password.UseSystemPasswordChar = true;
			// 
			// worldid
			// 
			this.worldid.Location = new System.Drawing.Point(6, 71);
			this.worldid.Name = "worldid";
			this.worldid.Size = new System.Drawing.Size(258, 20);
			this.worldid.TabIndex = 7;
			this.worldid.Text = "World ID";
			// 
			// startreset
			// 
			this.startreset.Location = new System.Drawing.Point(13, 323);
			this.startreset.Name = "startreset";
			this.startreset.Size = new System.Drawing.Size(272, 23);
			this.startreset.TabIndex = 8;
			this.startreset.Text = "Start Reset";
			this.startreset.UseVisualStyleBackColor = true;
			this.startreset.Click += new System.EventHandler(this.startreset_Click);
			// 
			// xpos
			// 
			this.xpos.Location = new System.Drawing.Point(26, 13);
			this.xpos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.xpos.Name = "xpos";
			this.xpos.Size = new System.Drawing.Size(92, 20);
			this.xpos.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "X";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(130, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Y";
			// 
			// ypos
			// 
			this.ypos.Location = new System.Drawing.Point(163, 13);
			this.ypos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.ypos.Name = "ypos";
			this.ypos.Size = new System.Drawing.Size(95, 20);
			this.ypos.TabIndex = 13;
			// 
			// gates
			// 
			this.gates.AutoSize = true;
			this.gates.Location = new System.Drawing.Point(114, 19);
			this.gates.Name = "gates";
			this.gates.Size = new System.Drawing.Size(152, 17);
			this.gates.TabIndex = 15;
			this.gates.Text = "Use gates instead of doors";
			this.gates.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Portal ID to start using ";
			// 
			// portalStart
			// 
			this.portalStart.Location = new System.Drawing.Point(133, 19);
			this.portalStart.Name = "portalStart";
			this.portalStart.Size = new System.Drawing.Size(120, 20);
			this.portalStart.TabIndex = 16;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.globalswitches);
			this.groupBox1.Controls.Add(this.gates);
			this.groupBox1.Location = new System.Drawing.Point(12, 121);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 50);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.id0);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.id1);
			this.groupBox2.Location = new System.Drawing.Point(12, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 37);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Switch IDs to reset";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.email);
			this.groupBox3.Controls.Add(this.password);
			this.groupBox3.Controls.Add(this.worldid);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(270, 103);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Account Information";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.xpos);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.ypos);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Location = new System.Drawing.Point(12, 220);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(270, 39);
			this.groupBox4.TabIndex = 21;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Position";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.portalStart);
			this.groupBox5.Location = new System.Drawing.Point(15, 265);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(270, 52);
			this.groupBox5.TabIndex = 22;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Portal Id";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 392);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.startreset);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(313, 430);
			this.MinimumSize = new System.Drawing.Size(313, 430);
			this.Name = "Form1";
			this.Text = "SeSet";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
			((System.ComponentModel.ISupportInitialize)(this.id0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.id1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ypos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.portalStart)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox globalswitches;
		private System.Windows.Forms.NumericUpDown id0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown id1;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox worldid;
		private System.Windows.Forms.Button startreset;
		private System.Windows.Forms.NumericUpDown xpos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown ypos;
		private System.Windows.Forms.CheckBox gates;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown portalStart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
	}
}

