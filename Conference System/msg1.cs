using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SampleGrabberNET
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class msg1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox msg;
		private System.Windows.Forms.TextBox txt_host;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		Thread myth;
		public msg1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msg = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(474, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = ":Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msg
            // 
            this.msg.Dock = System.Windows.Forms.DockStyle.Top;
            this.msg.Enabled = false;
            this.msg.Location = new System.Drawing.Point(0, 43);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(474, 20);
            this.msg.TabIndex = 10;
            this.msg.Text = "Write your Message Here";
            this.msg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msg_KeyPress);
            // 
            // txt_host
            // 
            this.txt_host.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_host.Location = new System.Drawing.Point(0, 23);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(474, 20);
            this.txt_host.TabIndex = 9;
            this.txt_host.Text = "225.100.0.1";
            this.txt_host.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_host_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(474, 218);
            this.listBox1.TabIndex = 11;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Connect";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "End Conection";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5});
            this.menuItem3.Text = "Font &Color";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Color";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Line";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // msg1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(474, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "msg1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Conference";
            this.TopMost = true;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.msg1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.msg1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
		}
		public void server()
		{
			try
			{
				UdpClient sock = new UdpClient(9050); 
				sock.JoinMulticastGroup(IPAddress.Parse(txt_host.Text), 50);
				IPEndPoint iep = new IPEndPoint(IPAddress.Any, 0); 

				byte[] data = sock.Receive(ref iep);
				string stringData = Encoding.ASCII.GetString(data, 0, data.Length);
				listBox1.Items.Add(iep.Address.ToString() +" :_  "+stringData );
				sock.Close();
				listBox1.Focus();
				msg.Focus();
				myth.Abort();
				
			}
			catch(Exception){}
		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
	
			myth= new Thread  (new System.Threading .ThreadStart(server)); // Start Thread Session
			myth.Start ();
		}

		private void msg1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (menuItem1.Enabled == false) e.Cancel=true;
			
		}
		
		
		

		private void msg1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		msg.Focus();
		}

		private void msg_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == '\r')
			{
				try
				{
					Socket server = new Socket(AddressFamily.InterNetwork,
						SocketType.Dgram, ProtocolType.Udp);
					IPEndPoint iep = new IPEndPoint(IPAddress.Parse(txt_host.Text), 9050);
   
					byte[] data = Encoding.ASCII.GetBytes(msg.Text);
					server.SendTo(data, iep);
					server.Close();
					msg.Clear();
					msg.Focus();
				
				}
		
				catch(Exception){}
			}
		}

		private void txt_host_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		if ((e.KeyChar <48||e.KeyChar >57)&& (e.KeyChar !=8) && (e.KeyChar !=46))  e.Handled = true;
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			timer1.Enabled = true;
			txt_host.ReadOnly = true;
			menuItem1.Enabled = false;
			menuItem2.Enabled = true;
			msg.Enabled = true;
			msg.Focus();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			timer1.Enabled = false;
			txt_host.ReadOnly = false;
			menuItem1.Enabled = true;
			menuItem2.Enabled = false;
			timer1.Enabled = false;
			msg.Enabled=false;
			try
			{
				Socket server = new Socket(AddressFamily.InterNetwork,
					SocketType.Dgram, ProtocolType.Udp);
				IPEndPoint iep = new IPEndPoint(IPAddress.Parse(txt_host.Text), 9050);
   
				byte[] data = Encoding.ASCII.GetBytes("has Left the Room");
				server.SendTo(data, iep);
				server.Close();
				msg.Clear();
				msg.Focus();
				
			}
		
			catch(Exception){}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			colorDialog1.ShowDialog();
			listBox1.ForeColor = colorDialog1.Color;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			fontDialog1.ShowDialog();
			listBox1.Font = fontDialog1.Font;
		}
	}
}
