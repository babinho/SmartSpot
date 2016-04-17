using System;

namespace Menu
{
	public partial class PhoneWindow : Gtk.Window
	{
		public PhoneWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnExitPhoneButtonClicked (object sender, EventArgs e)
		{
			//ProcessEvent (Gdk.EventHelper.New (Gdk.EventType.Delete));
			Hide ();
			//Destroy ();
			//Dispose ();
		}

		protected void OnButton28Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

