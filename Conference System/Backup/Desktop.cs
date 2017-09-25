using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SampleGrabberNET
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.PictureBox picScreen;
		private System.Windows.Forms.Timer Capturing;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.ComponentModel.IContainer components;

		public MainForm1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.picScreen = new System.Windows.Forms.PictureBox();
			this.Capturing = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
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
			this.menuItem1.Text = "«»œ√ «·≈—”«·";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Enabled = false;
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "«Ìﬁ«›";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "Hide";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// picScreen
			// 
			this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picScreen.Image = ((System.Drawing.Image)(resources.GetObject("picScreen.Image")));
			this.picScreen.Location = new System.Drawing.Point(0, 0);
			this.picScreen.Name = "picScreen";
			this.picScreen.Size = new System.Drawing.Size(394, 259);
			this.picScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picScreen.TabIndex = 5;
			this.picScreen.TabStop = false;
			// 
			// Capturing
			// 
			this.Capturing.Interval = 300;
			this.Capturing.Tick += new System.EventHandler(this.Capturing_Tick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(-2, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Server";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(394, 20);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "224.100.0.1";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(394, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "«·„Ã„Ê⁄…";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.contextMenu1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Multicast Conference System";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem4});
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "Show";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click_1);
			// 
			// MainForm1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(394, 259);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picScreen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Desktop Conference System - Screen Sender";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.DarkSlateBlue;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm1_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public Bitmap ResizeBitmap( Bitmap b, int nWidth, int nHeight ){  Bitmap result = new Bitmap( nWidth, nHeight );  using( Graphics g = Graphics.FromImage( (Image) result ) )    g.DrawImage( b, 0, 0, nWidth, nHeight );  return result;}
		private void Capturing_Tick(object sender, System.EventArgs e)
		{
			try
				{
				Bitmap bt = new Bitmap(CaptureScreen.GetDesktopImage());					
				picScreen.Image = ResizeBitmap(bt, 600, 400 );

				MemoryStream ms = new MemoryStream();
				picScreen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] arrImage = ms.ToArray();

				Socket server = new Socket(AddressFamily.InterNetwork,
				SocketType.Dgram, ProtocolType.Udp);
				IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 5020);
					
				server.SendTo(arrImage,iep);
				server.Close();

		
			}
			catch (Exception ex)
			{
				Capturing.Enabled = false;
				MessageBox.Show(ex.Message,"Desktop Conference System - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				menuItem1.Enabled = true;
				menuItem2.Enabled = false;
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Capturing.Enabled=true;
			menuItem1.Enabled = false;
			menuItem2.Enabled = true;
			textBox1.ReadOnly = true;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Capturing.Enabled=false;
			menuItem1.Enabled = true;
			menuItem2.Enabled = false;
			textBox1.ReadOnly = false;
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		
		}



		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Capturing.Enabled=true;
			menuItem1.Enabled = false;
			menuItem2.Enabled = true;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Capturing.Enabled=false;
			menuItem1.Enabled = true;
			menuItem2.Enabled = false;
		}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		if ((e.KeyChar <48||e.KeyChar >57)&& (e.KeyChar !=8) && (e.KeyChar !=46))  e.Handled = true;
		}

		private void MainForm1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (menuItem1.Enabled == false) e.Cancel=true;
			Capturing.Enabled = false;
			
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Hide ();
		}

		private void menuItem4_Click_1(object sender, System.EventArgs e)
		{
			this.Show ();
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
		this.Show ();
		}


	}
}
