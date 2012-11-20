using System;
using Gtk;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Main class.
/// </summary>
namespace EvernoteOAuthTest
{
	/// <summary>
	/// Main class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
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
