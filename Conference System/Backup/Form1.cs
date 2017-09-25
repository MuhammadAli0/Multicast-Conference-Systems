using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SampleGrabberNET
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		public bool video = false;
		public MainForm mf;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem9});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem14,
																					  this.menuItem5,
																					  this.menuItem12,
																					  this.menuItem11,
																					  this.menuItem4,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem1.Text = "«»œ√ „‰ Â‰«";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem3.Text = "Video Conference »œ√";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "≈—”«· «·ﬂ„Ì—«";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 1;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem15});
			this.menuItem14.Text = "Voice Conference «»œ√";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.Text = "«»œ√ «·„Õ«œÀ… «·’Ê Ì…";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6});
			this.menuItem5.Text = "Desktop Conference »œ√ ";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "«—”«· ’Ê—… ”ÿÕ «·„ﬂ »";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 3;
			this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem13});
			this.menuItem12.Text = "Text Conference «»œ√";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 0;
			this.menuItem13.Text = "»œ√ «·„Õ«œÀ… «·‰’Ì…";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 4;
			this.menuItem11.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 5;
			this.menuItem4.Text = "«” ﬁ»«· ﬂ„Ì—«";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "≈‰Â«¡";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10});
			this.menuItem9.Text = "«·„”«⁄œ…";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "ÕÊ·";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.statusBar1.Location = new System.Drawing.Point(0, 244);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(560, 22);
			this.statusBar1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(560, 266);
			this.Controls.Add(this.statusBar1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Multicast Conference System - for support please email me on: fadi822000@yahoo.co" +
				"m";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion
			static void Main() 
			{
				Application.Run(new Form1());
			}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		statusBar1.Text = DateTime.Now.ToShortDateString() + " - Welcome to my Conference System -„‘—Ê⁄ «·„ƒ „—«  - „‘—Ê⁄ „Œ’’ ·√Âœ«›  ⁄·Ì„Ì…";
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		
			if (video == false)
			{
			    mf = new MainForm();
				mf.Show();
				video = true;
			}
			else mf.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Receiver rc = new Receiver();
			rc.Show();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			About ab = new About();
			ab.Show();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
		MainForm1 mf = new MainForm1();
			mf.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			msg1 mg = new msg1();
			mg.Show();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			Form_VOIP frvo = new Form_VOIP ();
			frvo.Show ();
		}
	}
}
