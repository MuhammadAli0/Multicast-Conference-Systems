using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets ;
using System.Net;
using System.IO;
using System.Threading;

namespace SampleGrabberNET
{
	/// <summary>
	/// Summary description for Receiver.
	/// </summary>
	public class Receiver : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.ComponentModel.IContainer components;

		public Receiver()
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
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receiver));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem1});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Start";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = false;
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Stop";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "Save Photos";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "224.100.0.1";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(368, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = ":Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Receiver
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Receiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Receiver ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Receiver_Closing);
            this.Load += new System.EventHandler(this.Receiver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Receiver_Load(object sender, System.EventArgs e)
		{

		}
		
		UdpClient sock;
		void Image_Receiver()
		{
			
				sock = new UdpClient(5500); 
				sock.JoinMulticastGroup(IPAddress.Parse(textBox1.Text));
				IPEndPoint iep = new IPEndPoint(IPAddress.Any, 0); 
			while(true)
			{
				byte[] data = sock.Receive(ref iep);
				MemoryStream ms = new MemoryStream(data);
				pictureBox1.Image = Image.FromStream(ms); // Show The Image that Resaved as Binary Stream
				
			}		
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			try
			{
		
				saveFileDialog1.Filter = "JPEG Image (*.jpg)|*.jpg" ; 
				if(saveFileDialog1.ShowDialog() == DialogResult.OK) 
				{ 

					string mypic_path = saveFileDialog1.FileName;
					pictureBox1.Image.Save(mypic_path);
				}
			}
			catch (Exception){}
		}
		Thread myth;
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
			myth= new Thread  (new System.Threading .ThreadStart(Image_Receiver)); // Start Thread Session
			myth.Start ();
			menuItem2.Enabled = false;
			menuItem3.Enabled = true;
			textBox1.ReadOnly = true;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			myth.Abort ();
			menuItem3.Enabled = false;
			menuItem2.Enabled = true;
			textBox1.ReadOnly = false;
		}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar <48||e.KeyChar >57)&& (e.KeyChar !=8) && (e.KeyChar !=46))  e.Handled = true;

		}

		private void Receiver_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (menuItem2.Enabled == false) e.Cancel=true;
			else
			{
			sock.Close();
			myth.Abort ();
			}
				
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
