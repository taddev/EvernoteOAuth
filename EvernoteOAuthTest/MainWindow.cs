using System;
using Gtk;
using GtkSharp;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Console.WriteLine( "Window Built\n" );
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected virtual void OnFileMenuQuitActived (object sender, System.EventArgs e)
	{
		Application.Quit ();
	}

	protected void OnLoginButtonClicked (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (this, 
		                                      DialogFlags.DestroyWithParent,
		                                      MessageType.Error, 
		                                      ButtonsType.Close, "Error loading file");
		
		md.Run ();
		md.Destroy();

	}

}