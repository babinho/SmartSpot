﻿using System;
using Gtk;

namespace Menu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			win.Fullscreen ();
			win.Decorated = false;
			Application.Run ();
		}
	}
}