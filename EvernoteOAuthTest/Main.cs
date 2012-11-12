using System;
using Gtk;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace EvernoteOAuthTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Console.WriteLine( "Drawing Window\n" );
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
