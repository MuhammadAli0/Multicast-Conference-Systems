/******************************************************
                  DirectShow .NET
		      netmaster@swissonline.ch
*******************************************************/
//				SampleGrabber MainForm

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Net.Sockets ;
using System.Net;
//using System.IO;
using DShowNET;
using DShowNET.Device;


namespace SampleGrabberNET
{

/// <summary> Summary description for MainForm. </summary>
public class MainForm : System.Windows.Forms.Form, ISampleGrabberCB
{
	private System.Windows.Forms.Splitter splitter1;
	private System.Windows.Forms.ToolBar toolBar;
	private System.Windows.Forms.Panel videoPanel;
	private System.Windows.Forms.Panel stillPanel;
	private System.Windows.Forms.PictureBox pictureBox;
	private System.Windows.Forms.ToolBarButton toolBarBtnTune;
	private System.Windows.Forms.ToolBarButton toolBarBtnGrab;
	private System.Windows.Forms.ToolBarButton toolBarBtnSave;
	private System.Windows.Forms.ToolBarButton toolBarBtnSep;
	private System.Windows.Forms.ImageList imgListToolBar;
	private System.Windows.Forms.MainMenu mainMenu1;
	private System.Windows.Forms.MenuItem menuItem1;
	private System.Windows.Forms.MenuItem menuItem2;
	private System.Windows.Forms.Timer timer1;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.MenuItem menuItem3;
	private System.Windows.Forms.NotifyIcon notifyIcon1;
	private System.Windows.Forms.ContextMenu contextMenu1;
	private System.Windows.Forms.MenuItem menuItem4;
	private System.ComponentModel.IContainer components;

	public MainForm()
	{
		// Required for Windows Form Designer support
		InitializeComponent();
	}

	/// <summary> Clean up any resources being used. </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			CloseInterfaces();
			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.toolBarBtnTune = new System.Windows.Forms.ToolBarButton();
            this.toolBarBtnGrab = new System.Windows.Forms.ToolBarButton();
            this.toolBarBtnSep = new System.Windows.Forms.ToolBarButton();
            this.toolBarBtnSave = new System.Windows.Forms.ToolBarButton();
            this.imgListToolBar = new System.Windows.Forms.ImageList(this.components);
            this.videoPanel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.stillPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.stillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarBtnTune,
            this.toolBarBtnGrab,
            this.toolBarBtnSep,
            this.toolBarBtnSave});
            this.toolBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.imgListToolBar;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(610, 42);
            this.toolBar.TabIndex = 0;
            this.toolBar.Visible = false;
            this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
            // 
            // toolBarBtnTune
            // 
            this.toolBarBtnTune.Enabled = false;
            this.toolBarBtnTune.ImageIndex = 0;
            this.toolBarBtnTune.Name = "toolBarBtnTune";
            this.toolBarBtnTune.Text = "Tune";
            this.toolBarBtnTune.ToolTipText = "TV tuner dialog";
            // 
            // toolBarBtnGrab
            // 
            this.toolBarBtnGrab.ImageIndex = 1;
            this.toolBarBtnGrab.Name = "toolBarBtnGrab";
            this.toolBarBtnGrab.Text = "Grab";
            this.toolBarBtnGrab.ToolTipText = "Grab picture from stream";
            // 
            // toolBarBtnSep
            // 
            this.toolBarBtnSep.Enabled = false;
            this.toolBarBtnSep.Name = "toolBarBtnSep";
            this.toolBarBtnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarBtnSave
            // 
            this.toolBarBtnSave.Enabled = false;
            this.toolBarBtnSave.ImageIndex = 2;
            this.toolBarBtnSave.Name = "toolBarBtnSave";
            this.toolBarBtnSave.Text = "Save";
            this.toolBarBtnSave.ToolTipText = "Save image to file";
            // 
            // imgListToolBar
            // 
            this.imgListToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListToolBar.ImageStream")));
            this.imgListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListToolBar.Images.SetKeyName(0, "");
            this.imgListToolBar.Images.SetKeyName(1, "");
            this.imgListToolBar.Images.SetKeyName(2, "");
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.Black;
            this.videoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.videoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.videoPanel.Location = new System.Drawing.Point(0, 42);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(328, 241);
            this.videoPanel.TabIndex = 1;
            this.videoPanel.Resize += new System.EventHandler(this.videoPanel_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(328, 42);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 241);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // stillPanel
            // 
            this.stillPanel.AutoScroll = true;
            this.stillPanel.AutoScrollMargin = new System.Drawing.Size(8, 8);
            this.stillPanel.AutoScrollMinSize = new System.Drawing.Size(32, 32);
            this.stillPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stillPanel.Controls.Add(this.label2);
            this.stillPanel.Controls.Add(this.pictureBox);
            this.stillPanel.Controls.Add(this.textBox1);
            this.stillPanel.Controls.Add(this.label1);
            this.stillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stillPanel.Location = new System.Drawing.Point(333, 42);
            this.stillPanel.Name = "stillPanel";
            this.stillPanel.Size = new System.Drawing.Size(277, 241);
            this.stillPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paused";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-16, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(394, 259);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "224.100.0.1";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Group";
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
            this.menuItem1.Text = "Send";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Stop";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Hide";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(610, 283);
            this.Controls.Add(this.stillPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.toolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Camera";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stillPanel.ResumeLayout(false);
            this.stillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
//	static void Main() 
//	{
//		Application.Run(new MainForm());
//	}

	private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		this.Hide ();
		e.Cancel = true;
//		this.Hide();
//		CloseInterfaces();
	}

		/// <summary> detect first form appearance, start grabber. </summary>
	private void MainForm_Activated(object sender, System.EventArgs e)
	{
		if( firstActive )
			return;
		firstActive = true;

		if( ! DsUtils.IsCorrectDirectXVersion() )
		{
			MessageBox.Show( this, "DirectX 8.1 NOT installed!", "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			this.Close(); return;
		}

		if( ! DsDev.GetDevicesOfCat( FilterCategory.VideoInputDevice, out capDevices ) )
		{
			MessageBox.Show( this, "No video capture devices found!", "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			this.Close(); return;
		}

		DsDevice dev = null;
		if( capDevices.Count == 1 )
			dev = capDevices[0] as DsDevice;
		else
		{
			DeviceSelector selector = new DeviceSelector( capDevices );
			selector.ShowDialog( this );
			dev = selector.SelectedDevice;
		}

		if( dev == null )
		{
			this.Close(); return;
		}

		if( ! StartupVideo( dev.Mon ) )
			this.Close();
	}

	private void videoPanel_Resize(object sender, System.EventArgs e)
	{
		ResizeVideoWindow();
	}


		/// <summary> handler for toolbar button clicks. </summary>
	private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
	{
		try
		{
			Trace.WriteLine( "!!BTN: toolBar_ButtonClick" );
		
			int hr;
			if( sampGrabber == null )
				return;

			Trace.WriteLine( "!!BTN: toolBarBtnGrab" );

			if( savedArray == null )
			{
				int size = videoInfoHeader.BmiHeader.ImageSize;
				if( (size < 1000) || (size > 16000000) )
					return;
				savedArray = new byte[ size + 64000 ];
			}

			toolBarBtnSave.Enabled = false;
			Image old = pictureBox.Image;
			//pictureBox.Image = null;
			if( old != null )
				old.Dispose();

			toolBarBtnGrab.Enabled = false;
			captured = false;
			hr = sampGrabber.SetCallback( this, 1 );
			Trace.WriteLine( "!!BTN: toolBarBtnSave" );

			if( capGraph != null )
				DsUtils.ShowTunerPinDialog( capGraph, capFilter, this.Handle );
		}
		catch (Exception){}
	}

		/// <summary> capture event, triggered by buffer callback. </summary>
	void OnCaptureDone()
	{
	try {
		Trace.WriteLine( "!!DLG: OnCaptureDone" );
	
			toolBarBtnGrab.Enabled = true;
			int hr;
			if( sampGrabber == null )
				return;
			hr = sampGrabber.SetCallback( null, 0 );

			int w = videoInfoHeader.BmiHeader.Width;
			int h = videoInfoHeader.BmiHeader.Height;
			if( ((w & 0x03) != 0) || (w < 32) || (w > 4096) || (h < 32) || (h > 4096) )
				return;
			int stride = w * 3;

			GCHandle handle = GCHandle.Alloc( savedArray, GCHandleType.Pinned );
			int scan0 = (int) handle.AddrOfPinnedObject();
			scan0 += (h - 1) * stride;
			Bitmap b = new Bitmap( w, h, -stride, PixelFormat.Format24bppRgb, (IntPtr) scan0 );
			handle.Free();
			savedArray = null;
			Image old = pictureBox.Image;
			pictureBox.Image = b;
			if( old != null )
				old.Dispose();
			toolBarBtnSave.Enabled = true;
		}
		catch( Exception)
		{
		}
	}



		/// <summary> start all the interfaces, graphs and preview window. </summary>
	bool StartupVideo( UCOMIMoniker mon )
	{
		int hr;
		try {
			if( ! CreateCaptureDevice( mon ) )
				return false;

			if( ! GetInterfaces() )
				return false;

			if( ! SetupGraph() )
				return false;

			if( ! SetupVideoWindow() )
				return false;

			#if DEBUG
				DsROT.AddGraphToRot( graphBuilder, out rotCookie );		// graphBuilder capGraph
			#endif
			
			hr = mediaCtrl.Run();
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			bool hasTuner = DsUtils.ShowTunerPinDialog( capGraph, capFilter, this.Handle );
			toolBarBtnTune.Enabled = hasTuner;

			return true;
		}
		catch( Exception ee )
		{
			MessageBox.Show( this, "Could not start video stream\r\n" + ee.Message, "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
	}

		/// <summary> make the video preview window to show in videoPanel. </summary>
	bool SetupVideoWindow()
	{
		int hr;
		try {
			// Set the video window to be a child of the main window
			hr = videoWin.put_Owner( videoPanel.Handle );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			// Set video window style
			hr = videoWin.put_WindowStyle( WS_CHILD | WS_CLIPCHILDREN );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			// Use helper function to position video window in client rect of owner window
			ResizeVideoWindow();

			// Make the video window visible, now that it is properly positioned
			hr = videoWin.put_Visible( DsHlp.OATRUE );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			hr = mediaEvt.SetNotifyWindow( this.Handle, WM_GRAPHNOTIFY, IntPtr.Zero );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );
			return true;
		}
		catch( Exception ee )
		{
			MessageBox.Show( this, "Could not setup video window\r\n" + ee.Message, "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
	}


		/// <summary> build the capture graph for grabber. </summary>
	bool SetupGraph()
	{
		int hr;
		try {
			hr = capGraph.SetFiltergraph( graphBuilder );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			hr = graphBuilder.AddFilter( capFilter, "Ds.NET Video Capture Device" );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			DsUtils.ShowCapPinDialog( capGraph, capFilter, this.Handle );

			AMMediaType media = new AMMediaType();
			media.majorType	= MediaType.Video;
			media.subType	= MediaSubType.RGB24;
			media.formatType = FormatType.VideoInfo;		// ???
			hr = sampGrabber.SetMediaType( media );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			hr = graphBuilder.AddFilter( baseGrabFlt, "Ds.NET Grabber" );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			Guid cat = PinCategory.Preview;
			Guid med = MediaType.Video;
			hr = capGraph.RenderStream( ref cat, ref med, capFilter, null, null ); // baseGrabFlt 
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			cat = PinCategory.Capture;
			med = MediaType.Video;
			hr = capGraph.RenderStream( ref cat, ref med, capFilter, null, baseGrabFlt ); // baseGrabFlt 
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			media = new AMMediaType();
			hr = sampGrabber.GetConnectedMediaType( media );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );
			if( (media.formatType != FormatType.VideoInfo) || (media.formatPtr == IntPtr.Zero) )
				throw new NotSupportedException( "Unknown Grabber Media Format" );

			videoInfoHeader = (VideoInfoHeader) Marshal.PtrToStructure( media.formatPtr, typeof(VideoInfoHeader) );
			Marshal.FreeCoTaskMem( media.formatPtr ); media.formatPtr = IntPtr.Zero;

			hr = sampGrabber.SetBufferSamples( false );
			if( hr == 0 )
				hr = sampGrabber.SetOneShot( false );
			if( hr == 0 )
				hr = sampGrabber.SetCallback( null, 0 );
			if( hr < 0 )
				Marshal.ThrowExceptionForHR( hr );

			return true;
		}
		catch( Exception ee )
		{
			
			return false;
		}
	}


		/// <summary> create the used COM components and get the interfaces. </summary>
	bool GetInterfaces()
	{
		Type comType = null;
		object comObj = null;
		try {
			comType = Type.GetTypeFromCLSID( Clsid.FilterGraph );
			if( comType == null )
				throw new NotImplementedException( @"DirectShow FilterGraph not installed/registered!" );
			comObj = Activator.CreateInstance( comType );
			graphBuilder = (IGraphBuilder) comObj; comObj = null;

			Guid clsid = Clsid.CaptureGraphBuilder2;
			Guid riid = typeof(ICaptureGraphBuilder2).GUID;
			comObj = DsBugWO.CreateDsInstance( ref clsid, ref riid );
			capGraph = (ICaptureGraphBuilder2) comObj; comObj = null;

			comType = Type.GetTypeFromCLSID( Clsid.SampleGrabber );
			if( comType == null )
				throw new NotImplementedException( @"DirectShow SampleGrabber not installed/registered!" );
			comObj = Activator.CreateInstance( comType );
			sampGrabber = (ISampleGrabber) comObj; comObj = null;

			mediaCtrl	= (IMediaControl)	graphBuilder;
			videoWin	= (IVideoWindow)	graphBuilder;
			mediaEvt	= (IMediaEventEx)	graphBuilder;
			baseGrabFlt	= (IBaseFilter)		sampGrabber;
			return true;
		}
		catch( Exception ee )
		{
			MessageBox.Show( this, "Could not get interfaces\r\n" + ee.Message, "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
		finally
		{
			if( comObj != null )
				Marshal.ReleaseComObject( comObj ); comObj = null;
		}
	}

		/// <summary> create the user selected capture device. </summary>
	bool CreateCaptureDevice( UCOMIMoniker mon )
	{
		object capObj = null;
		try {
			Guid gbf = typeof( IBaseFilter ).GUID;
			mon.BindToObject( null, null, ref gbf, out capObj );
			capFilter = (IBaseFilter) capObj; capObj = null;
			return true;
		}
		catch( Exception ee )
		{
			MessageBox.Show( this, "Could not create capture device\r\n" + ee.Message, "DirectShow.NET", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
		finally
		{
			if( capObj != null )
				Marshal.ReleaseComObject( capObj ); capObj = null;
		}

	}



		/// <summary> do cleanup and release DirectShow. </summary>
	void CloseInterfaces()
	{
		int hr;
		try {
			#if DEBUG
				if( rotCookie != 0 )
					DsROT.RemoveGraphFromRot( ref rotCookie );
			#endif

			if( mediaCtrl != null )
			{
				hr = mediaCtrl.Stop();
				mediaCtrl = null;
			}

			if( mediaEvt != null )
			{
				hr = mediaEvt.SetNotifyWindow( IntPtr.Zero, WM_GRAPHNOTIFY, IntPtr.Zero );
				mediaEvt = null;
			}

			if( videoWin != null )
			{
				hr = videoWin.put_Visible( DsHlp.OAFALSE );
				hr = videoWin.put_Owner( IntPtr.Zero );
				videoWin = null;
			}

			baseGrabFlt = null;
			if( sampGrabber != null )
				Marshal.ReleaseComObject( sampGrabber ); sampGrabber = null;

			if( capGraph != null )
				Marshal.ReleaseComObject( capGraph ); capGraph = null;

			if( graphBuilder != null )
				Marshal.ReleaseComObject( graphBuilder ); graphBuilder = null;

			if( capFilter != null )
				Marshal.ReleaseComObject( capFilter ); capFilter = null;
			
			if( capDevices != null )
			{
				foreach( DsDevice d in capDevices )
					d.Dispose();
				capDevices = null;
			}
		}
		catch( Exception )
		{}
	}

		/// <summary> resize preview video window to fill client area. </summary>
	void ResizeVideoWindow()
	{
		if( videoWin != null )
		{
			Rectangle rc = videoPanel.ClientRectangle;
			videoWin.SetWindowPosition( 0, 0, rc.Right, rc.Bottom );
		}
	}

		/// <summary> override window fn to handle graph events. </summary>
	protected override void WndProc( ref Message m )
	{
		if( m.Msg == WM_GRAPHNOTIFY )
			{
			if( mediaEvt != null )
				OnGraphNotify();
			return;
			}
		base.WndProc( ref m );
	}

		/// <summary> graph event (WM_GRAPHNOTIFY) handler. </summary>
	void OnGraphNotify()
	{
		DsEvCode	code;
		int p1, p2, hr = 0;
		do
		{
			hr = mediaEvt.GetEvent( out code, out p1, out p2, 0 );
			if( hr < 0 )
				break;
			hr = mediaEvt.FreeEventParams( code, p1, p2 );
		}
		while( hr == 0 );
	}

		/// <summary> sample callback, NOT USED. </summary>
	int ISampleGrabberCB.SampleCB( double SampleTime, IMediaSample pSample )
	{
		Trace.WriteLine( "!!CB: ISampleGrabberCB.SampleCB" );
		return 0;
	}

		/// <summary> buffer callback, COULD BE FROM FOREIGN THREAD. </summary>
	int ISampleGrabberCB.BufferCB( double SampleTime, IntPtr pBuffer, int BufferLen )
	{
		if( captured || (savedArray == null) )
		{
			Trace.WriteLine( "!!CB: ISampleGrabberCB.BufferCB" );
			return 0;
		}

		captured = true;
		bufferedSize = BufferLen;
		Trace.WriteLine( "!!CB: ISampleGrabberCB.BufferCB  !GRAB! size = " + BufferLen.ToString() );
		if( (pBuffer != IntPtr.Zero) && (BufferLen > 1000) && (BufferLen <= savedArray.Length) )
			Marshal.Copy( pBuffer, savedArray, 0, BufferLen );
		else
			Trace.WriteLine( "    !!!GRAB! failed " );
		this.BeginInvoke( new CaptureDone( this.OnCaptureDone ) );
		return 0;
	}


		/// <summary> flag to detect first Form appearance </summary>
	private bool					firstActive;

		/// <summary> base filter of the actually used video devices. </summary>
	private IBaseFilter				capFilter;

		/// <summary> graph builder interface. </summary>
	private IGraphBuilder			graphBuilder;

		/// <summary> capture graph builder interface. </summary>
	private ICaptureGraphBuilder2	capGraph;
	private ISampleGrabber			sampGrabber;

		/// <summary> control interface. </summary>
	private IMediaControl			mediaCtrl;

		/// <summary> event interface. </summary>
	private IMediaEventEx			mediaEvt;

		/// <summary> video window interface. </summary>
	private IVideoWindow			videoWin;

		/// <summary> grabber filter interface. </summary>
	private IBaseFilter				baseGrabFlt;

		/// <summary> structure describing the bitmap to grab. </summary>
	private	VideoInfoHeader			videoInfoHeader;
	private	bool					captured = true;
	private	int						bufferedSize;

		/// <summary> buffer for bitmap data. </summary>
	private	byte[]					savedArray;

		/// <summary> list of installed video devices. </summary>
	private ArrayList				capDevices;

	private const int WM_GRAPHNOTIFY	= 0x00008001;	// message from graph

	private const int WS_CHILD			= 0x40000000;	// attributes for video window
	private const int WS_CLIPCHILDREN	= 0x02000000;
	private const int WS_CLIPSIBLINGS	= 0x04000000;

		/// <summary> event when callback has finished (ISampleGrabberCB.BufferCB). </summary>
	private delegate void CaptureDone();

	#if DEBUG
		private int		rotCookie = 0;

	private void MainForm_Load(object sender, System.EventArgs e)
	{
	
	}

	private void menuItem1_Click(object sender, System.EventArgs e)
	{
		int hr;
		int size = videoInfoHeader.BmiHeader.ImageSize;
		savedArray = new byte[ size + 64000 ];
		captured = false;
		hr = sampGrabber.SetCallback( this, 1 );
		timer1.Enabled = true;
		menuItem1.Enabled = false;
		menuItem2.Enabled = true;
		textBox1.ReadOnly = true;
		label2.Text = "Sending ...";
	}

	private void timer1_Tick(object sender, System.EventArgs e)
	{

		try
		{
			int hr;
			int size = videoInfoHeader.BmiHeader.ImageSize;
			savedArray = new byte[ size + 64000 ];
			captured = false;
			hr = sampGrabber.SetCallback( this, 1 );

			MemoryStream ms = new MemoryStream();// Store it in Binary Array as Stream
			pictureBox.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] arrImage = ms.GetBuffer();
			ms.Close();
				
			Socket server = new Socket(AddressFamily.InterNetwork,
				SocketType.Dgram, ProtocolType.Udp);
			IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 5020);
   
			server.SendTo(arrImage, iep);
			server.Close();

		}
		catch (Exception){}
	}

	private void menuItem2_Click(object sender, System.EventArgs e)
	{
	timer1.Enabled = false;
	menuItem2.Enabled = false;
	menuItem1.Enabled = true;
	textBox1.ReadOnly = false;
	label2.Text = "Paused";
	}

	private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
	{
	if ((e.KeyChar <48||e.KeyChar >57)&& (e.KeyChar !=8) && (e.KeyChar !=46))  e.Handled = true;
	}

	private void menuItem4_Click(object sender, System.EventArgs e)
	{
		this.Show ();
	}

	private void menuItem3_Click(object sender, System.EventArgs e)
	{
		this.Hide ();
	}

	private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
	{
		this.Show ();
	}
	#endif
}

internal enum PlayState
{
	Init, Stopped, Paused, Running
}

}
