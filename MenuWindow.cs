using System;
using Gtk;
using System.Timers;
using Menu;
using System.Diagnostics;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	// privatne variable
	private TimeSpan _placeboTimeout = new TimeSpan(0, 15, 0);
	//

	// Init ///////////////////////////////////////////////////////////////////////////////////
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.DefaultHeight = 480;
		this.DefaultWidth = 800;

		timedateLabel.Text = DateTime.Now.ToString("HH:mm dd.MM.yyyy");

		//Timer t = new Timer (1000);
		//t.AutoReset = true;

		//t.Elapsed -= T_Elapsed;
		//t.Elapsed += T_Elapsed;

		//t.Start ();
	}

	// eventovi ///////////////////////////////////////////////////////////////////////////////////
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;

	}

	void T_Elapsed (object sender, ElapsedEventArgs e)
	{
		
		//_placeboTimeout = _placeboTimeout.Subtract(new TimeSpan(0, 0, 1));
		//timeoutLabel.Text = _placeboTimeout.ToString();
	}

	// public ///////////////////////////////////////////////////////////////////////////////////
	public static void Show(string Msg)
	{
		MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, Msg);
		md.Run ();
		md.Destroy();
	}

	protected void OnExitActionClicked (object sender, EventArgs e)
	{
		ZazoviSH ("/home/pi/ugasisve.sh");
	}

	PhoneWindow win;

	protected void OnPhoneButtonClicked (object sender, EventArgs e)
	{
		if (win != null) {
			win.Show ();
		} else {
			win = new PhoneWindow ();
			win.Show ();
			win.Decorated = false;
		}
	}

	protected void OnButton13Clicked (object sender, EventArgs e)
	{
		Process pipe = new Process();
		string tmpScript = "/home/pi/upalichrome.sh";
		pipe.StartInfo.FileName = "sh";
		pipe.StartInfo.Arguments = tmpScript; 
		pipe.Start();
	}

protected void OnButton14Clicked (object sender, EventArgs e)
{
		Process pipe = new Process();
		string tmpScript = "/home/pi/upaliinfo.sh";
		pipe.StartInfo.FileName = "sh";
		pipe.StartInfo.Arguments = tmpScript; 
		pipe.Start();
}
protected void OnSkypeButtonClicked (object sender, EventArgs e)
{
		Process pipe = new Process();
		string tmpScript = "/home/pi/upaliskype.sh";
		pipe.StartInfo.FileName = "sh";
		pipe.StartInfo.Arguments = tmpScript; 
		pipe.Start();
}


protected void OnMailButtonClicked (object sender, EventArgs e)
{
		Process pipe = new Process();
		string tmpScript = "/home/pi/upalimail.sh";
		pipe.StartInfo.FileName = "sh";
		pipe.StartInfo.Arguments = tmpScript; 
		pipe.Start();
}
	protected void ZazoviSH(String File)
	{
		Process pipe = new Process();
		string tmpScript = File;
		pipe.StartInfo.FileName = "sh";
		pipe.StartInfo.Arguments = tmpScript; 
		pipe.Start();
	}
}